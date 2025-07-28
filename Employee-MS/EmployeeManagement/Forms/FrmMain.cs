using EmployeeManagement.Properties;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        ResizeControls resize = new ResizeControls();

        //=========
    
        //=============
        private void timer1_Tick(object sender, EventArgs e)
        {
            //-----------------------msgTool----------------------

            if (Convert.ToInt32(timer1.Tag) >= 1)
                timer1.Tag = (int)(timer1.Tag) + 1;

            if (Convert.ToInt32(timer1.Tag) == 5)
            {
                timer1.Tag = 0;
                tslMessage.Visible = false;
                statusStrip1.BackColor = Color.White;
            }

            tslDateTime.Text = DateTime.Now.ToString();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            resize.ResizeControl();
        }

        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            resize.Container = this;
        }

        void SetPermissions()
        {
        picSettings.Enabled = VariablesClass.settingsPermission;
            picUsers.Enabled = VariablesClass.usersPermission;
            picSettings.Enabled = VariablesClass.printPermission;

            tsmSettings.Enabled = VariablesClass.settingsPermission;
            tspUsers.Enabled = VariablesClass.usersPermission;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //VariablesClass.PicEvent.ApplyPicMouseEvents(this);
            tslUser.Text = VariablesClass.userName;
            SetPermissions();
            FunctionsClass.ApplyPicMouseEvents(this);

        }

      

        private void picUsers_Click(object sender, EventArgs e)
        {

            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {

            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }


        private void tsmSettings_Click(object sender, EventArgs e)
        {

            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }

        private void tspUsers_Click(object sender, EventArgs e)
        {

            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void tspChangePassword_Click(object sender, EventArgs e)
        {

            FrmChangePassword frm = new FrmChangePassword();
            frm.ShowDialog();
        }

        private void tspExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل أنت متأكد تريد تسجيل الخروج سيتم اغلاق  المنظومة", "تأكيد طلب إغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                    this.WindowState = FormWindowState.Minimized;
            }
            else
                e.Cancel = true;
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {

            FrmEmployee frm = new FrmEmployee();
            frm.ShowDialog();
        }

        private void picAttendanceAnddeparture_Click(object sender, EventArgs e)
        {

            FrmAttendanceAnddeparture frm = new FrmAttendanceAnddeparture();
            frm.ShowDialog();
        }

        private void picSalaries_Click(object sender, EventArgs e)
        {
               
            FrmSalaries frm = new FrmSalaries();
            frm.ShowDialog();
        }

        private void picShowSalaries_Click(object sender, EventArgs e)
        {

            FrmShowSalaries frm = new FrmShowSalaries();
            frm.ShowDialog();
        }

        private void picPredecessor_Click(object sender, EventArgs e)
        {

            FrmPredecessor frm = new FrmPredecessor();
            frm.ShowDialog();
        }

        private void picViewOrAddRewards_Click(object sender, EventArgs e)
        {

            FrmViewOrAddRewards frm = new FrmViewOrAddRewards();
            frm.ShowDialog();
        }

        private void picViewOrAddDiscounts_Click(object sender, EventArgs e)
        {
            
            FrmViewOrAddDiscounts frm = new FrmViewOrAddDiscounts();
            frm.ShowDialog();
        }

        private void picVacations_Click(object sender, EventArgs e)
        {

            FrmVacations frm = new FrmVacations();
            frm.ShowDialog();
        }

        private void picDegrees_Click(object sender, EventArgs e)
        {

            FrmDegrees frm = new FrmDegrees();
            frm.ShowDialog();
        }

        private void tsmBanks_Click(object sender, EventArgs e)
        {

            FrmBanks frm = new FrmBanks();
            frm.ShowDialog();
        }

        private void tsmBankBranches_Click(object sender, EventArgs e)
        {

            FrmBankBranches frm = new FrmBankBranches();
            frm.ShowDialog();
        }

        private void tsmSections_Click(object sender, EventArgs e)
        {

            FrmSections frm = new FrmSections();
            frm.ShowDialog();
        }

        private void tsmManagement_Click(object sender, EventArgs e)
        {

            FrmManagement frm = new FrmManagement();
            frm.ShowDialog();
        }

        private void tsmPaymentMethod_Click(object sender, EventArgs e)
        {

            FrmPaymentMethod frm = new FrmPaymentMethod();
            frm.ShowDialog();
        }

        private void tsmTypeOfLeave_Click(object sender, EventArgs e)
        {
               
            FrmTypeOfLeave frm = new FrmTypeOfLeave();
            frm.ShowDialog();
        }
    }
}
