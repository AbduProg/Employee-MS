using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement;

namespace EmployeeManagement.Forms
{
    public partial class FrmPaymentMethod : Form
    {
        public FrmPaymentMethod()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsPaymentMethod = new DataSet();
        int PaymentMethodId, cr = -1;

        //=====================Functions======================
        void GetFillData()
        {
            SqlConClass.sqlQuery = "SELECT Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N, MethodName FROM TblPaymentMethod ORDER BY MethodName";

            SqlConClass sqlCon = new SqlConClass();

            dsPaymentMethod = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);

            if (FunctionsClass.DsHasTables(dsPaymentMethod))
            {
                dgvPaymentMethod.DataSource = dsPaymentMethod.Tables[0];
                dgvPaymentMethod.ClearSelection();
            }
            else
                   this.Close();
        }

        void displayData()
        {
            PaymentMethodId = (int)dgvPaymentMethod.Rows[cr].Cells[0].Value;
            txtPaymentMethod.Text = dgvPaymentMethod.Rows[cr].Cells[2].Value.ToString();
            txtPaymentMethod.Focus();
        }

        void clearData()
        {
            cr = -1;
            PaymentMethodId = 0;
            dgvPaymentMethod.ClearSelection();

            txtPaymentMethod.Clear();
            txtPaymentMethod.Focus();
        }

        void savePaymentMethod()
        {
            if (txtPaymentMethod.Text.Trim() == "")
                return;

            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@Id", PaymentMethodId),
                new SqlParameter("@MethodName", txtPaymentMethod.Text.Trim())
            };

            SqlConClass sqlCon = new SqlConClass();

            sqlCon.cmdExecute("SavePaymentMethod", 1, param);

            GetFillData();
            btnRefresh.PerformClick();
        }

        void SetPermissions()
        {


            btnAdd.Enabled = VariablesClass.insertPermission;

            btnSave.Enabled = VariablesClass.updatePermission;

            btnDelete.Enabled = VariablesClass.updatePermission;
        }
        //============
        private void FrmPaymentMethod_Load(object sender, EventArgs e)
        {
            VariablesClass.functionsClass.MoveForm(this);

            GetFillData();
            SetPermissions();

        }

        private void dgvPaymentMethod_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
                return;

            cr = dgvPaymentMethod.CurrentRow.Index;
            displayData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData();
            GetFillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PaymentMethodId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            savePaymentMethod();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PaymentMethodId != 0)
                btnRefresh.PerformClick();

            savePaymentMethod();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PaymentMethodId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف طريقة الدفع" + Environment.NewLine + Environment.NewLine + txtPaymentMethod.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", PaymentMethodId) };

                sqlCon.cmdExecute("DeletePaymentMethod", 1, param);

                btnRefresh.PerformClick();
            }
        }

        private void txtPaymentMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            if (PaymentMethodId == 0)
            {
                dsPaymentMethod.Tables[0].DefaultView.RowFilter = "MethodName Like '%" + txtPaymentMethod.Text.Trim() + "%'";
                dgvPaymentMethod.ClearSelection();
            }
        }
    }
}
