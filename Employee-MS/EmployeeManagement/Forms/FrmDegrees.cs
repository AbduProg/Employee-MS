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
    public partial class FrmDegrees : Form
    {
        public FrmDegrees()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsDegree = new DataSet();
        int DegreeId, cr = -1;

        //=====================Functions======================
        void GetFillData()
        {
            SqlConClass.sqlQuery = @"SELECT Id,ROW_NUMBER()OVER(ORDER BY(SELECT 1))N,[Degrees],DegreesValue,Bonusvalue FROM TblDegrees ORDER BY[Degrees] ";

            SqlConClass sqlCon = new SqlConClass();

            dsDegree = sqlCon.selectData(SqlConClass.sqlQuery, 0, null);

            if (FunctionsClass.DsHasTables(dsDegree))
            {
                dgvDegrees.DataSource = dsDegree.Tables[0];
                dgvDegrees.ClearSelection();
            }
            else
                this.Close();
        }

        void displayData()
        {
            DegreeId = (int)dgvDegrees.Rows[cr].Cells[0].Value;
            txtDegrees.Text = dgvDegrees.Rows[cr].Cells[2].Value.ToString();
            txtDegreesValue.Text = dgvDegrees.Rows[cr].Cells[3].Value.ToString();
            txtBonusValue.Text = dgvDegrees.Rows[cr].Cells[4].Value.ToString();
            txtDegrees.Focus();
        }

        void clearData()
        {
            cr = -1;
            DegreeId = 0;
            dgvDegrees.ClearSelection();

            txtDegrees.Clear();
            txtDegrees.Focus();

            txtDegreesValue.Clear();
            txtBonusValue.Clear();

        }



        void saveDegrees()
        {
            if (txtDegrees.Text.Trim() == "" || txtDegreesValue.Text.Trim() == "" || txtBonusValue.Text.Trim() == "")
                return;

            SqlParameter[] param = new SqlParameter[] {
        new SqlParameter("@Id", DegreeId),
        new SqlParameter("@Degrees", int.Parse(txtDegrees.Text.Trim())),
        new SqlParameter("@DegreesValue", int.Parse(txtDegreesValue.Text.Trim())),
        new SqlParameter("@Bonusvalue", int.Parse(txtBonusValue.Text.Trim())),

    };

            SqlConClass sqlCon = new SqlConClass();
            sqlCon.cmdExecute("SaveDegrees", 1, param);

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
            cr = dgvDegrees.CurrentRow.Index;
            displayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DegreeId != 0)
                btnRefresh.PerformClick();

            saveDegrees();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DegreeId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveDegrees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DegreeId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف الدرجة" + Environment.NewLine + Environment.NewLine + txtDegrees.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", DegreeId) };

                sqlCon.cmdExecute("DeleteTblDegrees", 1, param);

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

        }

        private void txtBanks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.IsPositiveIntNum(e);
        }

    }
}
