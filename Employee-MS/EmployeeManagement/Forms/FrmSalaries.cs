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
    public partial class FrmSalaries : Form
    {
        public FrmSalaries()
        {
            InitializeComponent();
        }

        //======================Variables====================
        DataSet dsSalaries = new DataSet();
        int SalarieId, EmpId = 0, DgreeId = 0, cr = -1;
        bool DgvSwCr = false;

        //=====================Functions======================
        void GetFillData()
        {


            SqlConClass sqlCon = new SqlConClass();

            dsSalaries = sqlCon.selectData("SelectSalarieData", 1, null);

            if (FunctionsClass.DsHasTables(dsSalaries))
            {
                dgvSalarie.DataSource = dsSalaries.Tables[2];

                FunctionsClass.FillCmb(dsSalaries.Tables[1], cmbEmployeeName, "EmployeeName");
                FunctionsClass.FillCmb(dsSalaries.Tables[0], cmbDegrees, "Degrees");
                dgvSalarie.ClearSelection();
            }
            else
                this.Close();
        }


        void FindEmpData(int Id)
        {

            DataRow[] foundRows = dsSalaries.Tables[1].Select("Id = " + Id);
            if (foundRows.Length > 0)
            {
                FillEmpData(foundRows[0]);
            }


        }

        void FillEmpData(DataRow row)
        {
            txtBank.Text = row["FullBankName"].ToString();
            txtAccountNumber.Text = row["AccountNumber"].ToString();
            txtPaymentMethod.Text = row["MethodName"].ToString();
        }

        void FindDegreesData(int Id)
        {
            DataRow[] foundRows = dsSalaries.Tables[0].Select("Id = " + Id);
            if (foundRows.Length > 0)
            {
                FillDegreesData(foundRows[0]);
            }
        }

        void FillDegreesData(DataRow row)
        {
            txtDegreesValue.Text = row["DegreesValue"].ToString();
            txtBonusvalue.Text = row["Bonusvalue"].ToString();
        }


        void displayData()
        {
            if (DgvSwCr)
            {
                FindEmpData(EmpId);
                DgvSwCr = false;
            }
            else
            {
                cmbEmployeeName.SelectedValue = dgvSalarie.Rows[cr].Cells["Id"].Value;
                cmbEmployeeName_SelectionChangeCommitted(default, default);
            }

            cmbDegrees.SelectedValue = dgvSalarie.Rows[cr].Cells["DegreesId"].Value;
            cmbEmployeeName.SelectedValue = dgvSalarie.Rows[cr].Cells["Id"].Value;

            cmbDegrees_SelectionChangeCommitted(default, default);


            txtBonus.Text = dgvSalarie.Rows[cr].Cells["Bonus"].Value.ToString();
            TimeSpan fromTime = (TimeSpan)dgvSalarie.Rows[cr].Cells["From"].Value;
            dtpFrom.Value = DateTime.Today.Add(fromTime);

            TimeSpan toTime = (TimeSpan)dgvSalarie.Rows[cr].Cells["To"].Value;
            dtpTo.Value = DateTime.Today.Add(toTime);

            TimeSpan permissionToAttend = (TimeSpan)dgvSalarie.Rows[cr].Cells["PermissionToAttend"].Value;
            dtpPermissionToAttend.Value = DateTime.Today.Add(permissionToAttend);

            TimeSpan permissivenessOfExchange = (TimeSpan)dgvSalarie.Rows[cr].Cells["PermissivenessOfTheExchange"].Value;
            dtpPermissivenessOfTheExchange.Value = DateTime.Today.Add(permissivenessOfExchange);

            chkSunday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Sunday"].Value;
            chkMonday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Monday"].Value;
            chkTuesday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Tuesday"].Value;
            chkWednesday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Wednesday"].Value;
            chkThursday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Thursday"].Value;
            chkFriday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Friday"].Value;
            chkSaturday.Checked = (bool)dgvSalarie.Rows[cr].Cells["Saturday"].Value;


            dtpYearOfAmendment.Value = Convert.ToDateTime(dgvSalarie.Rows[cr].Cells["YearOfAmendment"].Value);
            dtpYearOfEntitlement.Value = Convert.ToDateTime(dgvSalarie.Rows[cr].Cells["YearOfEntitlement"].Value);

        }

        void clearData()
        {
            cr = -1;
            EmpId = 0;
            DgreeId = 0;
            DgvSwCr = false;
            dgvSalarie.ClearSelection();
            FunctionsClass.Clear(panel1);
            FunctionsClass.Clear(panel2);
            FunctionsClass.Clear(panel4);

        }
        void clearDataSup()
        {
            cr = -1;
            DgreeId = 0;
            DgvSwCr = false;

            dgvSalarie.ClearSelection();

            FunctionsClass.Clear(panel2);
            FunctionsClass.Clear(panel4);

        }
        bool CheckDays()
        {
            bool anyChecked = false;

            foreach (Control ctrl in panel4.Controls)
            {
                if (ctrl is CheckBox chk && chk.Checked)
                {
                    anyChecked = true;
                    break;
                }
            }

            if (!anyChecked)
            {
                MessageBox.Show("❌ الرجاء اختيار يوم واحد على الأقل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        void saveEmployeeFullDetails()
        {
            if (EmpId == 0)
            {
                MessageBox.Show("❌ الرجاء اختيار الموظف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DgreeId == 0)
            {
                MessageBox.Show("❌ الرجاء اختيار الدرجة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBonus.Text == string.Empty)
            {
                MessageBox.Show("❌ الرجاء إدخال قيمة العلاوة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (!CheckDays())
            {
                return;
            }


            SqlParameter[] param = new SqlParameter[]
            {
        // --- Salaries ---
        new SqlParameter("@YearOfEntitlement", dtpYearOfEntitlement.Value.Date), // من DateTimePicker
        new SqlParameter("@YearOfAmendment", dtpYearOfAmendment.Value.Date),
        new SqlParameter("@Bonus", int.Parse(txtBonus.Text)),
        new SqlParameter("@DegreesId", int.Parse(cmbDegrees.SelectedValue.ToString())),

        // --- Work ---
        new SqlParameter("@From", dtpFrom.Value), // مثال: "08:00"
        new SqlParameter("@To", dtpTo.Value),     // مثال: "14:00"
        new SqlParameter("@PermissionToAttend", dtpPermissionToAttend.Value),
        new SqlParameter("@PermissivenessOfTheExchange", dtpPermissivenessOfTheExchange.Value),

        // --- WeekDays ---
        new SqlParameter("@Sunday", chkSunday.Checked),
        new SqlParameter("@Monday", chkMonday.Checked),
        new SqlParameter("@Tuesday", chkTuesday.Checked),
        new SqlParameter("@Wednesday", chkWednesday.Checked),
        new SqlParameter("@Thursday", chkThursday.Checked),
        new SqlParameter("@Friday", chkFriday.Checked),
        new SqlParameter("@Saturday", chkSaturday.Checked),

        // --- Common ---
        new SqlParameter("@EmployeeId",     EmpId), // معرف الموظف الحالي
        new SqlParameter("@UserId",VariablesClass.userId),

            };

            SqlConClass sqlCon = new SqlConClass();
            sqlCon.cmdExecute("SaveEmployeeFullDetails", 1, param);


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
            FunctionsClass.SetupResizeControls(this, dgvSalarie);
            FunctionsClass.SetFormSize(this);

           // FunctionsClass.ApplyDateTimePickerFormat(this);
            GetFillData();
            SetPermissions();

        }

        private void dgvBanks_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvErrorWhithOutCheckSelect(dgvSalarie))
                return;

            if (!DgvSwCr)
            {
                cr = dgvSalarie.CurrentRow.Index;
                DgvSwCr = false;
            }

            displayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            saveEmployeeFullDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EmpId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveEmployeeFullDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EmpId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف بيانات الموظف" + Environment.NewLine + Environment.NewLine + cmbEmployeeName.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConClass sqlCon = new SqlConClass();

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@EmployeeId", EmpId) };

                sqlCon.cmdExecute("DeleteEmployeeFullDetails", 1, param);

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

        private void cmbDegrees_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (FunctionsClass.IsComboBoxValueNull(cmbDegrees))
            {
                return;
            }
            DgreeId = (int)cmbDegrees.SelectedValue;
            FindDegreesData(DgreeId);
        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.IsPositiveIntNum(e);
        }

        private void picDegree_Click(object sender, EventArgs e)
        {

            FrmDegrees frmDegrees = new FrmDegrees();
            frmDegrees.ShowDialog();
            GetFillData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmployeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (FunctionsClass.IsComboBoxValueNull(cmbEmployeeName))
            {
                return;
            }

            EmpId = (int)cmbEmployeeName.SelectedValue;
            DataRow[] item = dsSalaries.Tables[2].Select($"Id = {EmpId}");
            if (item.Length > 0)
            {

                cr = Convert.ToInt32(item[0][1]) - 1;

                dgvSalarie.ClearSelection();
                dgvSalarie.Rows[cr].Selected = true;
                dgvSalarie.FirstDisplayedScrollingRowIndex = cr;

                DgvSwCr = true;

                dgvBanks_Click(default, default);
                return;
            }
            clearDataSup();
            FindEmpData(EmpId);

        }

        private void txtBanks_KeyPress(object sender, KeyPressEventArgs e)
        {
            FunctionsClass.IsLetterOrDigit(e);
        }

    }
}
