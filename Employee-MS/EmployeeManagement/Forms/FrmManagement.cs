using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement;

namespace EmployeeManagement.Forms
{
    public partial class FrmManagement : Form
    {
        public FrmManagement()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsManagement = new DataSet();
        int ManagementId, cr = -1;

        //=====================Functions======================
        void GetFillData()
        {
            SqlConClass.sqlQuery = "SELECT Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N, ManagementName FROM TblManagement ORDER BY ManagementName";

            SqlConClass sqlCon = new SqlConClass();

            dsManagement = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);

            if (FunctionsClass.DsHasTables(dsManagement))
            {
                dgvManagement.DataSource = dsManagement.Tables[0];
                dgvManagement.ClearSelection();
            }
            else
                this.Close();
        }

        void displayData()
        {
            ManagementId = (int)dgvManagement.Rows[cr].Cells[0].Value;
            txtManagement.Text = dgvManagement.Rows[cr].Cells[2].Value.ToString();
            txtManagement.Focus();
        }

        void clearData()
        {
            cr = -1;
            ManagementId = 0;
            dgvManagement.ClearSelection();

            txtManagement.Clear();
            txtManagement.Focus();
        }

        void saveManagement()
        {
            if (txtManagement.Text.Trim() == "")
                return;

            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@Id", ManagementId),
                new SqlParameter("@ManagementName", txtManagement.Text.Trim())
            };

            SqlConClass sqlCon = new SqlConClass();

            sqlCon.cmdExecute("SaveManagement", 1, param);

            GetFillData();
            btnRefresh.PerformClick();
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }

        //==================
        private void FrmManagement_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetFillData();
            SetPermissions();

        }

        private void dgvManagement_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
                return;

            cr = dgvManagement.CurrentRow.Index;
            displayData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData();
            GetFillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ManagementId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveManagement();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ManagementId != 0)
                btnRefresh.PerformClick();

            saveManagement();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ManagementId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف الإدارة" + Environment.NewLine + Environment.NewLine + txtManagement.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", ManagementId) };

                sqlCon.cmdExecute("DeleteManagement", 1, param);

                btnRefresh.PerformClick();
            }
        }

        private void txtManagement_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtManagement_TextChanged(object sender, EventArgs e)
        {
            if (ManagementId == 0)
            {
                dsManagement.Tables[0].DefaultView.RowFilter = "ManagementName Like '%" + txtManagement.Text.Trim() + "%'";
                dgvManagement.ClearSelection();
            }
        }
    }
}
