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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }


        //======================Variables====================

        DataSet ds, dsSwap;
        int EmployeeId, SectionId, JopId, MethodId, BankId, BranchesId, cr;
        ResizeControls ResizeControls = new ResizeControls();
        bool DgvSwCr = false; // DataGridView Switch Current Row
        //===================================================

        //=====================Funcsions======================

        void GetData()
        {
            SqlConClass.sqlQuery = @"
                                     SELECT Id,EmployeeName         FROM TblEmployee   WHERE EmployeeStatus =1     ORDER BY EmployeeName;
                                     SELECT Id,SectionName          FROM TblSections                               ORDER BY SectionName;
                                     SELECT Id,JobName              FROM TblJobs                                   ORDER BY JobName;
                                     SELECT Id,MethodName           FROM TblPaymentMethod                          ORDER BY MethodName;
                                     SELECT Id,BankName             FROM TblBanks                                  ORDER BY BankName;
                                     SELECT Id,BranchesName,BankId  FROM TblBankBranches                           ORDER BY BranchesName ; 
                                     SELECT 
                                     E.Id ,
                                     ROW_NUMBER()OVER(ORDER BY(SELECT 1))N,
                                     E.EmployeeName,
                                     E.NationalNumber,
                                     E.PhoneNumber,
                                     M.ManagementName,
                                     S.SectionName,
                                     J.JobName,
                                     E.DateOfAppointment,
                                     U.UserName,
                                     E.PaymentMethodId,
                                     E.JobId,
                                     SectionId,
                                     BankBranchId,
                                     B.Id AS BankId,
                                     E.AccountNumber
                                     FROM TblEmployee E
                                     INNER JOIN TblPaymentMethod PM  ON E.PaymentMethodId =PM.Id
                                     INNER JOIN TblJobs J                         ON E.JobId =J.Id
                                     INNER JOIN TblSections S                  ON E.SectionId =S.Id
                                     INNER JOIN TblManagement M         ON S.ManagementId =M.Id
                                     INNER JOIN TblBankBranches BB     ON E.BankBranchId =BB.Id
                                     INNER JOIN  TblBanks B                    ON BB.BankId=B.Id
                                     INNER JOIN TblUseres U                    ON E.UserId=U.Id
                                     WHERE E.EmployeeStatus =1
                                     ORDER BY E.DateOfAppointment;
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
                FunctionsClass.FillCmb(ds.Tables[1], cmbSectionName, "SectionName");
                FunctionsClass.FillCmb(ds.Tables[2], cmbJopName, "JobName");
                FunctionsClass.FillCmb(ds.Tables[3], cmbPaymentMethod, "MethodName");
                FunctionsClass.FillCmb(ds.Tables[4], cmbBankName, "BankName");
                FunctionsClass.FillCmb(ds.Tables[5], cmbBranchesName, "BranchesName");
                dgvEmployees.DataSource = ds.Tables[6];
                dgvEmployees.ClearSelection(); cmbNamesOfEmployee.Select(); cmbNamesOfEmployee.Focus();
                RefreshVariable();
            }
        }

        void RefreshVariable()
        {
            EmployeeId = SectionId = JopId = MethodId = BankId = BranchesId = 0; cr = -1;
            ds.Tables[6].DefaultView.RowFilter = null;
            FunctionsClass.ApplyDateFormatToDataGridViewColumns(dgvEmployees);
            dgvEmployees.ClearSelection();

            //=============================
            FunctionsClass.Clear(gropbox);
            FunctionsClass.Clear(gropbox1);
            FunctionsClass.Clear(gropbox2);
        }

        void GetCmbEmployee()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,EmployeeName FROM TblEmployee   WHERE EmployeeStatus =1     ORDER BY EmployeeName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            FillCmbEmployee();
        }

        void FillCmbEmployee()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 0, 1);
                FunctionsClass.FillCmb(ds.Tables[0], cmbNamesOfEmployee, "EmployeeName");
                RefreshVariable();
            }
        }

        void GetFillCmbSection()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,SectionName  FROM TblSections                               ORDER BY SectionName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 1, 0);
                FunctionsClass.FillCmb(ds.Tables[1], cmbSectionName, "SectionName");
                RefreshVariable();
            }
        }

        void GetFillCmbJop()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,JobName      FROM TblJobs                                   ORDER BY JobName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 2, 0);
                FunctionsClass.FillCmb(ds.Tables[2], cmbJopName, "JobName");
                RefreshVariable();
            }
        }

        void GetFillCmbPaymentMethod()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,MethodName   FROM TblPaymentMethod                          ORDER BY MethodName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 3, 0);
                FunctionsClass.FillCmb(ds.Tables[3], cmbPaymentMethod, "MethodName");
                RefreshVariable();
            }
        }

        void GetFillCmbBank()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,BankName     FROM TblBanks                                  ORDER BY BankName;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 4, 0);
                FunctionsClass.FillCmb(ds.Tables[4], cmbBankName, "BankName");
                RefreshVariable();
            }
        }

        void GetFillCmbBranches()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,BranchesName,BankId  FROM TblBankBranches                           ORDER BY BranchesName ;
                                    ";
            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 5, 0);
                FunctionsClass.FillCmb(ds.Tables[5], cmbBranchesName, "BranchesName");
                RefreshVariable();
            }
        }

        //===================================================

        void InsertEmployee()
        {
            SqlParameter[] param = {
                                     new SqlParameter("@EmployeeName", cmbNamesOfEmployee.Text.Trim()),
                                     new SqlParameter("@AccountNumber", txtAccountNumber.Text.Trim()),
                                     new SqlParameter("@NationalNumber", txtNationalNumber.Text.Trim()),
                                     new SqlParameter("@PhoneNumber", txtPhoneNumber.Text.Trim()),
                                     new SqlParameter("@DateOfAppointment", dtpAdd.Value),
                                     new SqlParameter("@PaymentMethodId", MethodId),
                                     new SqlParameter("@JobId", JopId),
                                     new SqlParameter("@SectionId", SectionId),
                                     new SqlParameter("@BankBranchId", BranchesId),
                                     new SqlParameter("@UserId", VariablesClass.userId)
                                  };


            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.cmdExecute("InsertForTblEmployee", param);
            FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 6, 0);
            dgvEmployees.DataSource = ds.Tables[6];
            FillCmbEmployee();
        }

        void UpdateEmployee()
        {
            SqlParameter[] param = {
                                     new SqlParameter("@Id", EmployeeId),
                                     new SqlParameter("@EmployeeName", cmbNamesOfEmployee.Text.Trim()),
                                     new SqlParameter("@AccountNumber", txtAccountNumber.Text.Trim()),
                                     new SqlParameter("@NationalNumber", txtNationalNumber.Text.Trim()),
                                     new SqlParameter("@PhoneNumber", txtPhoneNumber.Text.Trim()),
                                     new SqlParameter("@DateOfAppointment", dtpAdd.Value),
                                     new SqlParameter("@PaymentMethodId", MethodId),
                                     new SqlParameter("@JobId", JopId),
                                     new SqlParameter("@SectionId", SectionId),
                                     new SqlParameter("@BankBranchId", BranchesId),
                                     new SqlParameter("@UserId", VariablesClass.userId)
                                  };


            SqlConClass sqlCon = new SqlConClass();
            dsSwap = sqlCon.cmdExecute("UpdateForTblEmployee", param);
            FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 6, 0);
            dgvEmployees.DataSource = ds.Tables[6];
            FillCmbEmployee();
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnEdit.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //===================================================

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            FunctionsClass.SetupResizeControls(this, dgvEmployees);
            FunctionsClass.SetFormSize(this);

            GetData();
            FunctionsClass.ApplyDateTimePickerFormat(this);
            SetPermissions();
        }

        private void dgvEmployees_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvErrorWhithOutCheckSelect(dgvEmployees))
                return;

            if (!DgvSwCr)
            {
                cr = dgvEmployees.CurrentRow.Index;
                DgvSwCr = false;
            }

            displayData();
        }
        //=================================
        void FindEmpData(int Id)
        {

            DataRow[] foundRows = ds.Tables[6].Select("Id = " + Id);
            if (foundRows.Length > 0)
            {
                FillEmpData(foundRows[0]);
            }


        }
        void FillEmpData(DataRow row)
        {
            txtNationalNumber.Text = row["NationalNumber"].ToString();

            txtPhoneNumber.Text = row["PhoneNumber"].ToString();

            cmbJopName.SelectedValue = (int)row["JobId"];
            cmbJopName_SelectionChangeCommitted(default, default);

            cmbPaymentMethod.SelectedValue = (int)row["PaymentMethodId"];
            cmbPaymentMethod_SelectionChangeCommitted(default, default);
            dtpAdd.Value = Convert.ToDateTime(row["DateOfAppointment"]);

            cmbSectionName.SelectedValue = (int)row["SectionId"];
            cmbSectionName_SelectionChangeCommitted(default, default);

            cmbBankName.SelectedValue = (int)row["BankId"];
            cmbBankName_SelectionChangeCommitted(default, default);

            cmbBranchesName.SelectedValue = (int)row["BankBranchId"];
            cmbBranchesName_SelectionChangeCommitted(default, default);

            txtAccountNumber.Text = row["AccountNumber"].ToString();
        }

        void displayData()
        {
            if (DgvSwCr)
            {
                FindEmpData(EmployeeId);
                DgvSwCr = false;
            }
            else
            {
                cmbNamesOfEmployee.SelectedValue = dgvEmployees.Rows[cr].Cells["Id"].Value;
                cmbNamesOfEmployee_SelectionChangeCommitted(default, default);
            }
        }
        //===================================================

        private void cmbNamesOfEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (FunctionsClass.IsComboBoxValueNull(cmbNamesOfEmployee))
            {
                return;
            }

            EmployeeId = (int)cmbNamesOfEmployee.SelectedValue;
            DataRow[] item = ds.Tables[6].Select($"Id = {EmployeeId}");
            if (item.Length > 0)
            {

                cr = Convert.ToInt32(item[0][1]) - 1;

                dgvEmployees.ClearSelection();
                dgvEmployees.Rows[cr].Selected = true;
                dgvEmployees.FirstDisplayedScrollingRowIndex = cr;

                DgvSwCr = true;

                dgvEmployees_Click(default, default);
                return;
            }
            //clearDataSup();
            FindEmpData(EmployeeId);
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

        private void cmbSectionName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbSectionName.SelectedValue == null)
            {
                return;
            }
            SectionId = (int)cmbSectionName.SelectedValue;
        }

        private void cmbSectionName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSectionName_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbSectionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===================================================

        private void cmbJopName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbJopName.SelectedValue == null)
            {
                return;
            }
            JopId = (int)cmbJopName.SelectedValue;
        }

        private void cmbJopName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbJopName_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbJopName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===================================================

        private void cmbPaymentMethod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.SelectedValue == null)
            {
                return;
            }
            MethodId = (int)cmbPaymentMethod.SelectedValue;
        }

        private void cmbPaymentMethod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPaymentMethod_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbPaymentMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===================================================

        private void cmbBankName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBankName.SelectedValue == null)
            {
                return;
            }
            BankId = (int)cmbBankName.SelectedValue;
            //=================================================================

            DataView dv = new DataView(ds.Tables[5]);
            dv.RowFilter = "BankId = " + BankId;

            cmbBranchesName.DataSource = dv;
            cmbBranchesName.DisplayMember = "BranchesName";
            cmbBranchesName.ValueMember = "Id";
            cmbBranchesName.SelectedIndex = -1;

        }

        private void cmbBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBankName_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbBankName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===================================================

        private void cmbBranchesName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBranchesName.SelectedValue == null)
            {
                return;
            }
            BranchesId = (int)cmbBranchesName.SelectedValue;
        }

        private void cmbBranchesName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBranchesName_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbBranchesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EmployeeId != 0)
            {
                RefreshVariable();
                return;
            }
            if (SectionId == 0 || JopId == 0 || MethodId == 0 || BranchesId == 0
                || txtNationalNumber.Text.Trim() == string.Empty || txtAccountNumber.Text.Trim() == string.Empty
                || txtPhoneNumber.Text.Trim() == string.Empty || cmbNamesOfEmployee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtpAdd.Value.Date > DateTime.Now)
            {
                if (MessageBox.Show("التاريخ الذي قمت باإدخالة غير منطقي هل تريد اسناد تاريخ اليوم ؟", "حذف البيانات",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                dtpAdd.Value = DateTime.Now;
            }
            InsertEmployee();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (EmployeeId == 0 || SectionId == 0 || JopId == 0 || MethodId == 0 || BranchesId == 0
                || txtNationalNumber.Text.Trim() == string.Empty || txtAccountNumber.Text.Trim() == string.Empty
                || txtPhoneNumber.Text.Trim() == string.Empty || cmbNamesOfEmployee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("الرجاء التحقق من البيانات المدخلة", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtpAdd.Value.Date > DateTime.Now)
            {
                if (MessageBox.Show("التاريخ الذي قمت باإدخالة غير منطقي هل تريد اسناد تاريخ اليوم ؟", "حذف البيانات",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                dtpAdd.Value = DateTime.Now;
            }
            UpdateEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EmployeeId == 0)
            {
                MessageBox.Show("الرجاء تحديد الموظف من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshVariable();
                return;
            }
            if (MessageBox.Show($"هل انت متأكد من إجراء عميلة الحذف على الموظف ؟", "حذف البيانات",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlcon = new SqlConClass();
                SqlParameter[] param =
                {
                   new SqlParameter("@Id",EmployeeId)
               };
                SqlConClass sqlCon = new SqlConClass();
                dsSwap = sqlCon.cmdExecute("DeleteForTblEmployee", param);
                FunctionsClass.UpdateDataset(ref ds, ref dsSwap, 6, 0);
                dgvEmployees.DataSource = ds.Tables[6];
                FillCmbEmployee();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {


            FunctionsClass.ExportToExcel(dgvEmployees, "تقرير الموظفين");
        }

        private void gropbox_Enter(object sender, EventArgs e)
        {

        }

        //===================================================

        private void picAddSection_Click(object sender, EventArgs e)
        {
            FrmSections Frm = new FrmSections();
            Frm.ShowDialog();
            GetFillCmbSection();
        }

        private void picAddJop_Click(object sender, EventArgs e)
        {
            FrmJobs Frm = new FrmJobs();
            Frm.ShowDialog();
            GetFillCmbJop();
        }

        private void picAddPaymentMethod_Click(object sender, EventArgs e)
        {
            FrmPaymentMethod Frm = new FrmPaymentMethod();
            Frm.ShowDialog();
            GetFillCmbPaymentMethod();
        }

        private void picAddBank_Click(object sender, EventArgs e)
        {
            FrmBanks Frm = new FrmBanks();
            Frm.ShowDialog();
            GetFillCmbBank();
        }

        private void picAddBranch_Click(object sender, EventArgs e)
        {
            FrmBankBranches Frm = new FrmBankBranches();
            Frm.ShowDialog();
            GetFillCmbBranches();
        }

        //===================================================

        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsPositiveIntNum1(e);
        }

        private void FrmEmployee_Resize(object sender, EventArgs e)
        {

        }

    }
}
