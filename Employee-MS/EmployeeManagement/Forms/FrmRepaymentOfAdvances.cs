using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement;

namespace EmployeeManagement.Forms
{
    public partial class FrmRepaymentOfAdvances : Form
    {
        public FrmRepaymentOfAdvances()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsJops = new DataSet();
        int JopsId, cr = -1;

        //=====================Functions======================
        void GetFillData()
        {
            SqlConClass.sqlQuery = $@"SELECT R.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N,[Value],Note,UserName FROM TblRepaymentOfAdvances R
                                    INNER JOIN TblUseres U ON U.Id = R.UserId
                                    WHERE  R.PredecessorId = {VariablesClass.PredecessorId};

                                    SELECT InstallmentValue,Value FROM TblPredecessor
                                    WHERE Id = {VariablesClass.PredecessorId};";

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
        }

        void clearData()
        {
            cr = -1;
            JopsId = 0;
            dgvJops.ClearSelection();

            txtEmpName.Clear();
            txtEmpName.Focus();
        }

        void saveJops()
        {
            if (Convert.ToDouble(txtValue.Text) <= 0)
            {
                return;
            }

            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@PredecessorId", VariablesClass.PredecessorId),
                new SqlParameter("@UserId", VariablesClass.userId),
                new SqlParameter("@Note", txtNote.Text),
                new SqlParameter("@Value",Convert.ToDouble(txtValue.Text.Trim()) )
            };

            SqlConClass sqlCon = new SqlConClass();

            sqlCon.cmdExecute("InsertForTblRepaymentOfAdvances", 1, param);

            GetFillData();
            btnRefresh.PerformClick();
        }

        void SetValue()
        {
            if (dgvJops.Rows.Count == 0)
            {
                txtValue.Text = dsJops.Tables[1].Rows[0][0].ToString();
                return;
            }
            double val = 0;
            foreach (DataGridViewRow item in dgvJops.Rows)
            {
                val += Convert.ToDouble(item.Cells["Value"].Value);
            }
            double val1 = Convert.ToDouble(dsJops.Tables[1].Rows[0][1]);

            if ((val1 - val) > Convert.ToDouble(dsJops.Tables[1].Rows[0][0]))
            {
                txtValue.Text = Convert.ToDouble(dsJops.Tables[1].Rows[0][0]).ToString();
            }
            else
            {
                txtValue.Text = (val1 - val).ToString();
            }
        }

        void SetPermissions()
        {


           

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //===================

        private void FrmJobs_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetFillData();
            SetValue();
            txtEmpName.Text = VariablesClass.EmpName;
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

            SetValue();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
            if (MessageBox.Show("هل تريد حذف قيمة السداد" + Environment.NewLine + Environment.NewLine + txtEmpName.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", JopsId) };

                sqlCon.cmdExecute("DeleteRepaymentOfAdvances", 1, param);

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
           
        }
    }
}
