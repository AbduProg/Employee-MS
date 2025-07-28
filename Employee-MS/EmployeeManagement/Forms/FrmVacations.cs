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
    public partial class FrmVacations : Form
    {
        public FrmVacations()
        {
            InitializeComponent();
        }


        //======================Variables====================

        DataSet ds, dsSwap;
        int EmployeeId, TypeOfLevelId, VactionId, cr;

        //===================================================

        //=====================Funcsions======================

        void GetData()
        {
            SqlConClass sqlCon = new SqlConClass();
            ds = new DataSet();
            ds = sqlCon.selectData("ShowVactions", 1, null);
            FillData();
        }



        void FillData()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.FillCmb(ds.Tables[0], cmbNamesOfEmployee, "EmployeeName");
                FunctionsClass.FillCmb(ds.Tables[1], cmbTypeOfLeave, "TypeOfLeaveName");
                dgvVacations.DataSource = ds.Tables[2];
                dgvVacations.ClearSelection(); cmbNamesOfEmployee.Select(); cmbNamesOfEmployee.Focus();
                RefreshVariable();
            }
        }

        void GetFillCmbTypeOfLeave()
        {
            SqlConClass.sqlQuery = @"
                                     SELECT T.Id,T.TypeOfLeaveName    FROM TblTypeOfLeave T    ORDER BY T.TypeOfLeaveName
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 1, 0);
                FunctionsClass.FillCmb(ds.Tables[1], cmbTypeOfLeave, "TypeOfLeaveName");
            }
        }

        void Filldgv(ref DataSet dsSwap)
        {
            FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 2, 0);
            dgvVacations.DataSource = ds.Tables[2];
            RefreshVariable();
        }

        void RefreshVariable()
        {
            EmployeeId = TypeOfLevelId = VactionId = 0; cr = -1;
            ds.Tables[2].DefaultView.RowFilter = null;
            FunctionsClass.ApplyDateFormatToDataGridViewColumns(dgvVacations);
            dgvVacations.ClearSelection();
            FunctionsClass.Clear(panel2);
        }

        void SaveVaction()
        {
            SqlParameter[] param = {
             new SqlParameter("@EmployeeId", EmployeeId),
             new SqlParameter("@TypeOfLeaveId", TypeOfLevelId),
             new SqlParameter("@From", dtpFrom.Value),
             new SqlParameter("@To", dtpTo.Value),
             new SqlParameter("@UserId", VariablesClass.userId),
                                  };

            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.cmdExecute("InsertForTblVacation", param);
            Filldgv(ref dsSwap);
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;


            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //===================================================


        private void FrmVacations_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetData();
            FunctionsClass.ApplyDateTimePickerFormat(this);
            SetPermissions();

        }

        private void dgvVacations_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
            { return; }
            cr = dgvVacations.CurrentRow.Index;
            VactionId = (int)dgvVacations.Rows[cr].Cells[0].Value;
        }

        //===================================================

        private void cmbNamesOfEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbNamesOfEmployee.SelectedValue == null)
            {
                return;
            }
            EmployeeId = (int)cmbNamesOfEmployee.SelectedValue;
            ds.Tables[2].DefaultView.RowFilter = $"EmpId = {EmployeeId}";
            dgvVacations.ClearSelection();
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

        //===================================================

        private void cmbTypeOfLeave_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTypeOfLeave.SelectedValue == null)
            {
                return;
            }
            TypeOfLevelId = (int)cmbTypeOfLeave.SelectedValue;
            //  ds.Tables[1].DefaultView.RowFilter = $"EmployeeIdDgv = {TypeOfLevelId}";
            dgvVacations.ClearSelection();
        }

        private void cmbTypeOfLeave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbTypeOfLeave_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbTypeOfLeave_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EmployeeId == 0 || TypeOfLevelId == 0
                || cmbTypeOfLeave.Text.Trim() == string.Empty || cmbNamesOfEmployee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveVaction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (VactionId == 0)
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
                    new SqlParameter("@Id",VactionId)
                };
                dsSwap = sqlcon.cmdExecute("DeleteForTblVaction", para);
                Filldgv(ref dsSwap);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picTypeOfLeave_Click(object sender, EventArgs e)
        {
            FrmTypeOfLeave Frm = new FrmTypeOfLeave();
            Frm.ShowDialog();
            GetFillCmbTypeOfLeave();
        }


    }
}
