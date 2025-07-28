using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class FrmTypeOfLeave : Form
    {
        public FrmTypeOfLeave()
        {
            InitializeComponent();
        }


        //======================Variables====================

        DataSet ds, dsSwap;
        int LeaveId, cr, _Gender;

        //===================================================

        //=====================Funcsions======================

        void GetData()
        {
            SqlConClass.sqlQuery = @"
                                        SELECT 
                                        T.Id,
                                        T.TypeOfLeaveName
                                        FROM TblTypeOfLeave T
                                        ORDER BY T.TypeOfLeaveName;
                                                                               
                                        SELECT 
                                        T.Id,
                                        ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N,
                                        T.TypeOfLeaveName,
                                        T.Opponent,
                                              CASE 
                                              WHEN T.Gender = 0 THEN N'أنثى'
                                              WHEN T.Gender = 1 THEN N''
                                              ELSE N'غير محدد'
                                              END AS Gender
                                       FROM TblTypeOfLeave T
                                       ORDER BY T.TypeOfLeaveName
                                     ";
            SqlConClass sqlCon = new SqlConClass();
            ds = new DataSet();
            ds = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            FillData();
        }



        void FillData()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.FillCmb(ds.Tables[0], cmbLeave, "TypeOfLeaveName");
                dgvTypeOfLeaves.DataSource = ds.Tables[1];
                dgvTypeOfLeaves.ClearSelection(); cmbLeave.Select(); cmbLeave.Focus();
                RefreshVariable();
            }
        }


        void Filldgv(ref DataSet dsSwap)
        {
            FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 1, 0);
            dgvTypeOfLeaves.DataSource = ds.Tables[1];
            RefreshVariable();
        }


        void RefreshVariable()
        {
            LeaveId = 0; _Gender = -1; cr = -1;
            ds.Tables[1].DefaultView.RowFilter = null;
            FunctionsClass.ApplyDateFormatToDataGridViewColumns(dgvTypeOfLeaves);
            dgvTypeOfLeaves.ClearSelection();
            FunctionsClass.Clear(panel2);
        }

        void SaveTypeOfLeave()
        {
            SqlParameter[] param = {
             new SqlParameter("@TypeOfLeaveName", cmbLeave.Text.Trim()),
             new SqlParameter("@Opponent", txtOpponent.Text.Trim()),
             new SqlParameter("@Gender", _Gender),
                                  };

            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.cmdExecute("InsertForTblTypeOfLeave", param);
            Filldgv(ref dsSwap);
        }


        void UpdateTypeOfLeave()
        {
            SqlParameter[] param = {
             new SqlParameter("@Id", LeaveId),
             new SqlParameter("@TypeOfLeaveName", cmbLeave.Text.Trim()),
             new SqlParameter("@Opponent", txtOpponent.Text.Trim()),
             new SqlParameter("@Gender", _Gender),
                                  };

            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.cmdExecute("UpdateForTblTypeOfLeave", param);
            Filldgv(ref dsSwap);
        }

        void displayData()
        {
            LeaveId = (int)dgvTypeOfLeaves.Rows[cr].Cells[0].Value;
            cmbLeave.Text = dgvTypeOfLeaves.Rows[cr].Cells[2].Value.ToString();
            txtOpponent.Text = dgvTypeOfLeaves.Rows[cr].Cells[3].Value.ToString();
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnEdit.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //===================================================


        private void FrmTypeOfLeave_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetData();
            FunctionsClass.ApplyDateTimePickerFormat(this);
            SetPermissions();

        }

        private void dgvDiscounts_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
            { return; }
            cr = dgvTypeOfLeaves.CurrentRow.Index;
            displayData();
        }

        private void cmbNamesOfEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbLeave.SelectedValue == null)
            {
                return;
            }
            LeaveId = (int)cmbLeave.SelectedValue;
            ds.Tables[1].DefaultView.RowFilter = $"Id = {LeaveId}";
            dgvTypeOfLeaves.ClearSelection();
        }

        private void cmbNamesOfEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbNamesOfEmployee_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbNamesOfEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);

        }

        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsPositiveIntNum1(e);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (LeaveId != 0 || _Gender == -1 || txtOpponent.Text.Trim() == string.Empty || cmbLeave.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveTypeOfLeave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (LeaveId == 0 || _Gender == -1 || txtOpponent.Text.Trim() == string.Empty || cmbLeave.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateTypeOfLeave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LeaveId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($" هل انت متأكد من حذف الإجازة ؟", "حذف البيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                SqlConClass sqlcon = new SqlConClass();
                SqlParameter[] para =
                {
              new SqlParameter("@Id",LeaveId)
          };
                dsSwap = sqlcon.cmdExecute("DeleteForTblTypeOfLeave", para);
                Filldgv(ref dsSwap);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            _Gender = 1;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            _Gender = 0;
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            _Gender = 1;
        }

    }
}
