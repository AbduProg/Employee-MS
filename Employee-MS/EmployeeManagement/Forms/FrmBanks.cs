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
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsJops = new DataSet();
        int BankId, cr = -1;

        //=====================Functions======================
        void GetFillData()
        {
            SqlConClass.sqlQuery = @"
                                     SELECT Id,ROW_NUMBER()OVER(ORDER BY(SELECT 1))N,BankName
                                     FROM TblBanks
                                     ORDER BY BankName;
                                     ";

            SqlConClass sqlCon = new SqlConClass();

            dsJops = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);

            if (FunctionsClass.DsHasTables(dsJops))
            {
                dgvBanks.DataSource = dsJops.Tables[0];
                dgvBanks.ClearSelection();
            }
            else
                this.Close();
        }

        void displayData()
        {
            BankId = (int)dgvBanks.Rows[cr].Cells[0].Value;
            txtBanks.Text = dgvBanks.Rows[cr].Cells[2].Value.ToString();
            txtBanks.Focus();
        }

        void clearData()
        {
            cr = -1;
            BankId = 0;
            dgvBanks.ClearSelection();

            txtBanks.Clear();
            txtBanks.Focus();
        }

  

        void saveJops()
        {
            if (txtBanks.Text.Trim() == "")
                return;

            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@Id", BankId),
                new SqlParameter("@BankName", txtBanks.Text.Trim())
            };

            SqlConClass sqlCon = new SqlConClass();

            sqlCon.cmdExecute("InsertAndUpdateDataForTblBanks", 1, param);

          
            btnRefresh.PerformClick();
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //====================================================

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetFillData();
            SetPermissions();

        }

        private void dgvBanks_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
                return;
            cr = dgvBanks.CurrentRow.Index;
            displayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BankId != 0)
                btnRefresh.PerformClick();

            saveJops();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BankId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveJops();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BankId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف المصرف" + Environment.NewLine + Environment.NewLine + txtBanks.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", BankId) };

                sqlCon.cmdExecute("DeleteForTblBanks", 1, param);

                btnRefresh.PerformClick();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData();
            GetFillData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBanks_TextChanged(object sender, EventArgs e)
        {
            if (BankId == 0)
            {
                dsJops.Tables[0].DefaultView.RowFilter = "BankName Like '%" + txtBanks.Text.Trim() + "%'";
                dgvBanks.ClearSelection();
            }
        }

        private void txtBanks_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

    }
}
