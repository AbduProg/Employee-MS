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
    public partial class FrmViewOrAddRewards : Form
    {
        public FrmViewOrAddRewards()
        {
            InitializeComponent();
        }


        //======================Variables====================

        DataSet ds, dsSwap;
        int EmployeeId, RewardId, cr;

        //===================================================

        //=====================Funcsions======================

        void GetData()
        {
            SqlConClass.sqlQuery = @"
                                       SELECT E.Id,E.EmployeeName FROM TblEmployee E WHERE E.EmployeeStatus=1 ORDER BY E.EmployeeName;
                                       SELECT
                                       R.Id,
                                       ROW_NUMBER()OVER(ORDER BY (SELECT 1))N,
                                       E.EmployeeName,
                                       J.JobName,
                                       R.RewardDate,
                                       R.Value,
                                       R.Note,
                                       U.UserName,
                                       E.Id AS EmployeeIdDgv
                                       FROM TblReward R
                                       INNER JOIN TblEmployee E ON R.EmployeeId   =E.Id
                                       INNER JOIN      TblJobs J      ON      E.JobId         =J.Id
                                       INNER JOIN    TblUseres U   ON     R.UserId        =U.Id 
                                       ORDER BY R.RewardDate;
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
                FunctionsClass.FillCmb(ds.Tables[0], cmbNamesOfEmployee, "EmployeeName");
                dgvRewards.DataSource = ds.Tables[1];
                dgvRewards.ClearSelection(); cmbNamesOfEmployee.Select(); cmbNamesOfEmployee.Focus();
                RefreshVariable();
            }
        }

        void GetFillCmb()
        {
            SqlConClass.sqlQuery = @"
                                    SELECT E.Id,E.EmployeeName FROM TblEmployee E WHERE E.EmployeeStatus=1 ORDER BY E.EmployeeName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 0, 0);
                FunctionsClass.FillCmb(ds.Tables[0], cmbNamesOfEmployee, "EmployeeName");
                RefreshVariable();
            }
        }

        void Filldgv(ref DataSet dsSwap)
        {
            FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 1, 0);
            dgvRewards.DataSource = ds.Tables[1];
            RefreshVariable();
        }

        void RefreshVariable()
        {
            EmployeeId = RewardId = 0; cr = -1;
            ds.Tables[1].DefaultView.RowFilter = null;
            FunctionsClass.ApplyDateFormatToDataGridViewColumns(dgvRewards);
            dgvRewards.ClearSelection();
            FunctionsClass.Clear(panel2);
        }

        void SaveRewards()
        {
            SqlParameter[] param = {
             new SqlParameter("@EmployeeId", EmployeeId),
             new SqlParameter("@DateAdded", dtpAdd.Value),
             new SqlParameter("@Value", Convert.ToDouble(txtValue.Text.Trim())),
             new SqlParameter("@Note", txtNote.Text.Trim()),
             new SqlParameter("@UserId", VariablesClass.userId),
                                  };

            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.cmdExecute("InsertForTblRewareds", param);
            Filldgv(ref dsSwap);
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;


            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //===================================================

        private void FrmViewOrAddRewards_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetData();
            FunctionsClass.ApplyDateTimePickerFormat(this);
            SetPermissions();

        }

        private void dgvRewards_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
            { return; }
            cr = dgvRewards.CurrentRow.Index;
            RewardId = (int)dgvRewards.Rows[cr].Cells[0].Value;
        }

        private void cmbNamesOfEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbNamesOfEmployee.SelectedValue == null)
            {
                return;
            }
            EmployeeId = (int)cmbNamesOfEmployee.SelectedValue;
            ds.Tables[1].DefaultView.RowFilter = $"EmployeeIdDgv = {EmployeeId}";
            dgvRewards.ClearSelection();
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

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsPositiveRealNum((TextBox)sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EmployeeId == 0 || txtValue.Text.Trim() == string.Empty || cmbNamesOfEmployee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((Convert.ToDouble(txtValue.Text) <= 0))
            {
                MessageBox.Show("الرجاء التحقق من القيمة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtpAdd.Value.Date > DateTime.Now)
            {
                if (MessageBox.Show("التاريخ الذي قمت باإدخالة غير منطقي هل تريد اسناد تاريخ اليوم ؟", "إدخال البيانات",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                dtpAdd.Value = DateTime.Now;
            }
            SaveRewards();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RewardId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($" هل انت متأكد من حذف الخصم ؟", "حذف البيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                SqlConClass sqlcon = new SqlConClass();
                SqlParameter[] para =
                {
            new SqlParameter("@Id",RewardId)
        };
                dsSwap = sqlcon.cmdExecute("DeleteForTblRewaeds", para);
                Filldgv(ref dsSwap);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            FunctionsClass.ExportToExcel(dgvRewards, "المكافئات");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee Frm = new FrmEmployee();
            Frm.ShowDialog();
            GetFillCmb();
        }

    }
}
