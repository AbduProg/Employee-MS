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
    public partial class FrmBankBranches : Form
    {
        public FrmBankBranches()
        {
            InitializeComponent();
        }


        //============================Variables============================
        int BranchesId, BankId, cr;
        DataSet ds = new DataSet();

        //=================================================================


        //============================Functions============================

        void GetData()
        {
            SqlConClass.sqlQuery = @"
                                       SELECT Id,BankName FROM TblBanks
                                       ORDER BY BankName
                                       SELECT BB.Id,ROW_NUMBER()OVER(ORDER BY(SELECT 1))N,BB.BranchesName,B.Id AS BNId 
                                       FROM TblBankBranches BB
                                       INNER JOIN TblBanks B ON BB.BankId =B.Id
									   ORDER BY BB.BranchesName
                                       ";
            SqlConClass sql = new SqlConClass();
            ds = sql.selectData(SqlConClass.sqlQuery, 0, null); FillData();
        }

        void FillData()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                FunctionsClass.FillCmb(ds.Tables[0], cmbBanks, "BankName");
                dgvBankBranches.DataSource = ds.Tables[1];
                dgvBankBranches.ClearSelection();
                txtBanks.Text = string.Empty;
                cmbBanks.Select();
                cmbBanks.Focus();
                BankId = BranchesId = 0; cr = -1;
            }
            else { this.Close(); }
        }

        void GetFillCmb()
        {
            SqlConClass.sqlQuery = @"
                                      SELECT Id,BankName FROM TblBanks
                                      ORDER BY BankName
                                    ";
            SqlConClass sql = new SqlConClass(); DataSet dscmb = new DataSet();
            dscmb = sql.selectData(SqlConClass.sqlQuery, 0, null);
            if (FunctionsClass.DsHasTables(dscmb))
            {
                FunctionsClass.UpdateDataset(ref ds, ref dscmb, 0, 0);
                FunctionsClass.FillCmb(ds.Tables[0], cmbBanks, "BankName");
            }
            else { this.Close(); }
        }


        void SaveData()
        {
            if (txtBanks.Text.Trim() == string.Empty || BankId == 0)
            {
                MessageBox.Show("الرجاء التأكد من تعبة الحقل", "إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information); txtBanks.Focus(); return;
            }
            SqlParameter[] Para =
            {
                new SqlParameter("@Id",BranchesId),
                new SqlParameter("@BankId",BankId),
                new SqlParameter("@BranchesName",txtBanks.Text.Trim())
            };
            SqlConClass sql = new SqlConClass(); ds.Clear();
            ds = sql.cmdExecute("InsertAndUpdateDataForTblBankBranches", Para); FillData();
        }

        void DisPlay()
        {
            BranchesId = (int)dgvBankBranches.Rows[cr].Cells[0].Value;
            txtBanks.Text = dgvBankBranches.Rows[cr].Cells[2].Value.ToString(); txtBanks.Focus();
            //=============================CMB=================================
            var row = dgvBankBranches.Rows[cr];
            BankId = (int)row.Cells[3].Value;
            cmbBanks.SelectedValue = BankId;
            cmbBanks_SelectionChangeCommitted(default, default);
        }

        void SetPermissions()
        {

      
            btnAdd.Enabled = VariablesClass.insertPermission;

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //=================================================================


        private void FrmBankBranches_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);
            GetData();
            SetPermissions();

        }

        private void dgvBanks_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true) return;
            cr = dgvBankBranches.CurrentRow.Index; DisPlay();
        }

        //=================================================================

        private void cmbBanks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (FunctionsClass.IsComboBoxValueNull(cmbBanks)) return;
            BankId = (int)cmbBanks.SelectedValue;
            ds.Tables[1].DefaultView.RowFilter = $"BNId = {BankId}";
            dgvBankBranches.ClearSelection();
        }

        private void cmbBanks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBanks_SelectionChangeCommitted(default, default);
                return;
            }
        }

        private void cmbBanks_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        //===============================Btn==============================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BranchesId != 0)
            {
                btnRefresh_Click(default, default);
                return;
            }
            SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BranchesId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BranchesId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBankBranches.ClearSelection();
                return;
            }
            if (MessageBox.Show($"هل انت متأكد من إجراء عميلة الحذف على الفرع؟{Environment.NewLine}{txtBanks.Text.Trim()}", "حذف البيانات",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlcon = new SqlConClass();
                SqlParameter[] para =
                {
            new SqlParameter("@Id",BranchesId)
        }; ds.Clear();
                ds = sqlcon.cmdExecute("DeleteForTblBankBranches", para); FillData();
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

        private void picAddBank_Click(object sender, EventArgs e)
        {
            FrmBanks Frm = new FrmBanks();
            Frm.ShowDialog();
            GetFillCmb();
        }

        //=================================================================

        private void txtBanks_TextChanged(object sender, EventArgs e)
        {
            if (BranchesId == 0)
            {
                ds.Tables[1].DefaultView.RowFilter = $"BranchesName Like '%{txtBanks.Text.Trim()}%'";
                dgvBankBranches.ClearSelection();
            }
        }

        private void txtBanks_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }
    }
}
