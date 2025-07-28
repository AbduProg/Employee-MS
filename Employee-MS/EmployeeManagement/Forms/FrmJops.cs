using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement;

namespace EmployeeManagement.Forms
{
    public partial class FrmJobs : Form
    {
        public FrmJobs()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsJops = new DataSet();
        int JopsId, cr = -1;

        //=====================Functions======================
        void GetFillData()
        {
            SqlConClass.sqlQuery = "SELECT Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N, JobName FROM TblJobs ORDER BY JobName";

            SqlConClass sqlCon = new SqlConClass();

            dsJops = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);

            if (FunctionsClass.DsHasTables(dsJops))
            {
                dgvJops.DataSource = dsJops.Tables[0];
                dgvJops.ClearSelection();
            }
            else
                this.Close();
        }

        void displayData()
        {
            JopsId = (int)dgvJops.Rows[cr].Cells[0].Value;
            txtJops.Text = dgvJops.Rows[cr].Cells[2].Value.ToString();
            txtJops.Focus();
        }

        void clearData()
        {
            cr = -1;
            JopsId = 0;
            dgvJops.ClearSelection();

            txtJops.Clear();
            txtJops.Focus();
        }

        void saveJops()
        {
            if (txtJops.Text.Trim() == "")
                return;

            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@Id", JopsId),
                new SqlParameter("@JobName", txtJops.Text.Trim())
            };

            SqlConClass sqlCon = new SqlConClass();

            sqlCon.cmdExecute("SaveJobs", 1, param);

            GetFillData();
            btnRefresh.PerformClick();
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //========================
        private void FrmJobs_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetFillData();
            SetPermissions();

        }

        private void dgvJops_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
                return;

            cr = dgvJops.CurrentRow.Index;
            displayData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData();
            GetFillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (JopsId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveJops();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (JopsId != 0)
                btnRefresh.PerformClick();

            saveJops();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (JopsId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف الوظيفة" + Environment.NewLine + Environment.NewLine + txtJops.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", JopsId) };

                sqlCon.cmdExecute("DeleteJobs", 1, param);

                btnRefresh.PerformClick();
            }
        }

        private void txtJops_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtJops_TextChanged(object sender, EventArgs e)
        {
            if (JopsId == 0)
            {
                dsJops.Tables[0].DefaultView.RowFilter = "JobName Like '%" + txtJops.Text.Trim() + "%'";
                dgvJops.ClearSelection();
            }
        }
    }
}
