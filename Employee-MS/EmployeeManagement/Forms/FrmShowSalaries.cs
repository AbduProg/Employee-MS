using EmployeeManagement.Properties;
using EmployeeManagement.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class FrmShowSalaries : Form
    {
        public FrmShowSalaries()
        {
            InitializeComponent();
        }

        //======================Variables====================

        DataSet ds;
        int EmpId =0 , cr = -1;
        //===================================================

        //=====================Funcsions=====================


        void GetData()
        {
            SqlConClass sqlCon = new SqlConClass();
            ds = sqlCon.selectData("usp_UpsertAndGetMonthlySalaries", 1, null);
            FillData();
        }



        void FillData()
        {
            if (FunctionsClass.DsHasTables(ds))
            {
                dgvSalaries.DataSource = ds.Tables[0];
                RefreshVariable();

                string currentMonth = DateTime.Now.ToString("yyyy-MM");
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = $"Period = '{currentMonth}'";
                dgvSalaries.DataSource = dv;


                FunctionsClass.FillCmb(ds.Tables[1], cmbNamesOfEmployee, "EmployeeName");
                CalculateTotalsFromDGV();
                dgvSalaries.ClearSelection();
            }
        }


        private void CalculateTotalsFromDGV()
        {
            decimal totalSalaries = 0;
            decimal totalDiscounts = 0;
            decimal totalRewards = 0;
            decimal totalNet = 0;

            foreach (DataGridViewRow row in dgvSalaries.Rows)
            {
                if (row.IsNewRow) continue;


                totalSalaries += Convert.ToDecimal(row.Cells["SalaryValue"].Value ?? 0);
                totalDiscounts += Convert.ToDecimal(row.Cells["DiscountsValue"].Value ?? 0);
                totalRewards += Convert.ToDecimal(row.Cells["RewardsValue"].Value ?? 0);
                totalNet += Convert.ToDecimal(row.Cells["NetSalary"].Value ?? 0);
            }

            txtCountEmployee.Text = GetUniqueEmployeeCountFromDGV().ToString();
            txtSalaryValue.Text = totalSalaries.ToString("N2");
            txtDiscountValue.Text = totalDiscounts.ToString("N2");
            txtRewardeValue.Text = totalRewards.ToString("N2");
            txtNetValue.Text = totalNet.ToString("N2");
        }

        private int GetUniqueEmployeeCountFromDGV()
        {
            HashSet<int> uniqueEmployeeIds = new HashSet<int>();

            foreach (DataGridViewRow row in dgvSalaries.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["IdEmployees"].Value != null)
                {
                    int empId = Convert.ToInt32(row.Cells["IdEmployees"].Value);
                    uniqueEmployeeIds.Add(empId);
                }
            }

            return uniqueEmployeeIds.Count;
        }


        void RefreshVariable()
        {
            EmpId = 0; cr = -1;
            ds.Tables[0].DefaultView.RowFilter = null;
            FunctionsClass.ApplyDateFormatToDataGridViewColumns(dgvSalaries);
            FunctionsClass.ApplyDateTimePickerFormat(this);
        }

        void DisPlay()
        {
            EmpId = (int)dgvSalaries.Rows[cr].Cells[3].Value;
            cmbNamesOfEmployee.SelectedValue = EmpId;
            cmbNamesOfEmployee_SelectionChangeCommitted(default, default);
        }

       
        //===================================================
        void SetPermissions()
        {

            btnPrint.Enabled = VariablesClass.printPermission;
            btnExcel.Enabled = VariablesClass.printPermission;


        }
        private void FrmShowSalaries_Load(object sender, EventArgs e)
        {
            FunctionsClass.SetupResizeControls(this, dgvSalaries);
            FunctionsClass.SetFormSize(this);

            GetData();
            SetPermissions();

        }

        private void cmbNamesOfEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbNamesOfEmployee.SelectedValue == null)
            {
                return;
            }
            EmpId = (int)cmbNamesOfEmployee.SelectedValue;
            ds.Tables[0].DefaultView.RowFilter = $"IdEmployees = {EmpId}";
            dgvSalaries.ClearSelection();
            CalculateTotalsFromDGV();
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

        private void dgvSalaries_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.CheckDgvError((DataGridView)sender) == true)
            { return; }
            cr = dgvSalaries.CurrentRow.Index;
            DisPlay();
        }

        private void btnRefresh_Clic(object sender, EventArgs e)
        {
            if (ds.Tables[0] == null || ds.Tables[0].Rows.Count == 0)
                return;

            // تحديد من بداية الشهر إلى نهايته
            DateTime fromDate = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, 1);
            DateTime toDate = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, DateTime.DaysInMonth(dtpTo.Value.Year, dtpTo.Value.Month));

            // إنشاء شرط الفلترة
            string filterExpression = string.Format("[Period] >= #{0}# AND [Period] <= #{1}#",
                                                    fromDate.ToString("MM/dd/yyyy"),
                                                    toDate.ToString("MM/dd/yyyy"));

            if (EmpId > 0)
            {
                filterExpression += $" AND [IdEmployees] = {EmpId}";
            }

            // تعيين الفلترة مباشرة على DefaultView
            ds.Tables[0].DefaultView.RowFilter = filterExpression;

            // ربط البيانات المفلترة بالـ DataGridView
            dgvSalaries.DataSource = ds.Tables[0].DefaultView;
            dgvSalaries.ClearSelection();
            CalculateTotalsFromDGV();

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
            dtpFrom.Value = dtpTo.Value = DateTime.Now;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            if (dgvSalaries.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لتصديرها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel File (*.csv)|*.csv";
            saveFile.FileName = "تقرير المرتبات.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
                {
                    // كتابة رؤوس الأعمدة
                    for (int i = 0; i < dgvSalaries.Columns.Count; i++)
                    {
                        sw.Write(dgvSalaries.Columns[i].HeaderText);
                        if (i < dgvSalaries.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // كتابة البيانات
                    foreach (DataGridViewRow row in dgvSalaries.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < dgvSalaries.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString());
                            if (i < dgvSalaries.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("تم تصدير البيانات بنجاح", "تصدير بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvSalaries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvSalaries.Rows.Count == 0)
            {
                FunctionsClass.MsgTool("لا توجد بيانات في القائمة للطباعة", 0);
                return;
            }

            FrmPrint f = new FrmPrint();
            CRSalaris c = new CRSalaris();

            c.SetDataSource(ds.Tables[0].DefaultView.ToTable());
            f.crystalReportViewer1.ReportSource = c;

            c.SetParameterValue(0, "كلية تقتية المعلومات _غريان");
            c.SetParameterValue(1, VariablesClass.userName);
            c.SetParameterValue(2, DateTime.Now);

            f.crystalReportViewer1.Refresh();
            f.Text = "طباعة القائمة ";
            f.crystalReportViewer1.Zoom(100);
            f.WindowState = FormWindowState.Maximized;
            f.Show();   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
