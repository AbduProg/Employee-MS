using EmployeeManagement.Properties;
using EmployeeManagement.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class FrmAttendanceAnddeparture : Form
    {
        public FrmAttendanceAnddeparture()
        {
            InitializeComponent();
        }

        //===============
        DataSet dsAllData;



        //===============
        void GetData(DateTime dateTime)
        {

            SqlConClass sqlCon = new SqlConClass();

            dsAllData = new DataSet();
            dsAllData = sqlCon.selectData("GetAttendanceAndWorkSchedule", 1, new SqlParameter[] { new SqlParameter("@TargetDate", dateTime) });

            if (FunctionsClass.DsHasTables(dsAllData))
            {
                dgvAttendanceAndDeparture.DataSource = dsAllData.Tables[0];
            }


        }

        bool CheckDgvListAttendanceAnddeparture()
        {
            foreach (DataGridViewRow row in dgvAttendanceAndDeparture.Rows)
            {
                var presentVal = row.Cells["Present"].Value;
                var absentVal = row.Cells["absent"].Value;

                if (!(presentVal is bool present && present) && !(absentVal is bool absent && absent))
                {
                    MessageBox.Show("الرجاء ملء جميع الصفوف.");
                    return false;
                }
            }

            return true;
        }

        void SetPermissions()
        {

            btnPrint.Enabled = VariablesClass.printPermission;
            btnExport.Enabled = VariablesClass.printPermission;
            btnAdd.Enabled = VariablesClass.insertPermission;


        }
        //==============================



        private void FrmAttendanceAnddeparture_Load(object sender, EventArgs e)
        {
            FunctionsClass.SetupResizeControls(this, dgvAttendanceAndDeparture);
            FunctionsClass.SetFormSize(this);
            FunctionsClass.ApplyDateTimePickerFormat(this);
            GetData(DateTime.Now);
            SetPermissions();

        }

        private void dgvAttendanceAndDeparture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex >= 0))
            {
                DataGridView grid = dgvAttendanceAndDeparture;
                string columnName = grid.Columns[e.ColumnIndex].Name;

                if (columnName == "Present" || columnName == "absent")
                {
                    DataGridViewCheckBoxCell clickedCell = (DataGridViewCheckBoxCell)grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    bool isChecked = Convert.ToBoolean(clickedCell.Value ?? false);
                    clickedCell.Value = !isChecked;

                    if (columnName == "Present")
                    {
                        grid.Rows[e.RowIndex].Cells["absent"].Value = false;
                    }
                    else if (columnName == "absent")
                    {
                        grid.Rows[e.RowIndex].Cells["Present"].Value = false;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDgvListAttendanceAnddeparture())
            {
                return;
            }


            DataTable dt = new DataTable();
            dt.Columns.Add("PresentOrAbsent", typeof(bool));
            dt.Columns.Add("EmployeeId", typeof(int));



            foreach (DataGridViewRow item in dgvAttendanceAndDeparture.Rows)
            {

                bool present = (item.Cells["Present"].Value == null) ? false : (bool)item.Cells["Present"].Value;
                dt.Rows.Add(
                    present,
                    (int)item.Cells["Id"].Value
                    );
            }


            SqlParameter[] param = new SqlParameter[]
            {

                new SqlParameter("@AttendanceList",dt),
                new SqlParameter("@TargetDate",dtpSer.Value),
                new SqlParameter("@UserId",VariablesClass.userId),

            };

            SqlConClass sqlCon = new SqlConClass();
            sqlCon.cmdExecute("SaveAttendanceAndDeparture", 1, param);


            btnRefresh.PerformClick();

        }

        private void dtpSer_ValueChanged(object sender, EventArgs e)
        {
            if (dtpSer.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("لا يمكن تحديث البيانات لتاريخ مستقبلي.");
                GetData(DateTime.Now);
                return;
            }
            GetData(dtpSer.Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            GetData(DateTime.Now);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FunctionsClass.ExportToExcel(dgvAttendanceAndDeparture, "تقرير الحضور والغياب");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvAttendanceAndDeparture.Rows.Count == 0)
            {
                FunctionsClass.MsgTool("لا توجد بيانات في القائمة للطباعة", 0);
                return;
            }

            FrmPrint f = new FrmPrint();
            CRAttendanceAnddeparture c = new CRAttendanceAnddeparture();

            c.SetDataSource(dsAllData.Tables[0].DefaultView.ToTable());
            f.crystalReportViewer1.ReportSource = c;

            c.SetParameterValue(0, "كلية تقتية المعلومات _غريان");
            c.SetParameterValue(1, VariablesClass.userName);
            c.SetParameterValue(2, DateTime.Now);
            c.SetParameterValue(3, dtpSer.Value.ToString(Settings.Default.DateFormat));

            f.crystalReportViewer1.Refresh();
            f.Text = "طباعة القائمة ";
            f.crystalReportViewer1.Zoom(100);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
