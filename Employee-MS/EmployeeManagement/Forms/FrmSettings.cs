using Microsoft.Win32;
using EmployeeManagement.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement.Properties;

namespace EmployeeManagement.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        bool testCon = true;
       

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            //txtAdmnGmail.Text = Settings.Default.ManagerAccount;
            //txtDiscount.Text = Settings.Default.DiscountPercent.ToString();
            txtServer.Text = Settings.Default.Server;
            txtDatabase.Text = Settings.Default.Database;
            txtSQLUser.Text = Settings.Default.SQLLogin;
            txtSQLPassword.Text = Settings.Default.SQLPassword;

            txtAdminName.Text = Settings.Default.AdminName;
            txtAdminPass.Text = Settings.Default.AdminPassword;

            if (VariablesClass.userId != 1)
            {
                txtAdminName.ReadOnly = true;
                txtAdminName.UseSystemPasswordChar = true;
                txtAdminPass.ReadOnly = true;
            }

            //txtCompany.Text = Settings.Default.Company;
            //txtAutoBackupPath.Text = Settings.Default.AutoBackupPath;

            //if (Settings.Default.BackupFiles == 0)
            //    chkFiles.Checked = true;
            //else
            //    txtBackupFiles.Text = Settings.Default.BackupFiles.ToString();

            //if (Settings.Default.BackupDays == 0)
            //    chkDays.Checked = true;
            //else
            //    txtBackupDays.Text = Settings.Default.BackupDays.ToString();

            //radYes.Checked = Settings.Default.AutoBackup;

            cmbDateFormat.Items.Add("dd-MM-yyyy");
            cmbDateFormat.Items.Add("dd.MM.yyyy");
            cmbDateFormat.Items.Add("dd/MM/yyyy");

            cmbDateFormat.Text = Settings.Default.DateFormat;

            txtBackupPath.Select();
           // FunctionsClass.SetFormSize(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Do you want to Save the settings?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Settings.Default.Server == txtServer.Text.Trim() & Settings.Default.Database == txtDatabase.Text.Trim() & Settings.Default.SQLLogin == txtSQLUser.Text.Trim() & Settings.Default.SQLPassword == txtSQLPassword.Text)
                    testCon = true;  //  bool testCon = true;
                else
                    btnTestConnection_Click(sender, e);

                if (testCon == false)
                {
                    MessageBox.Show("Cannot Save The Settings, Error in system Conncetion ", "Failed to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Settings.Default.ManagerAccount = txtAdmnGmail.Text.Trim();
                Settings.Default.Server = txtServer.Text.Trim();
                Settings.Default.Database = txtDatabase.Text.Trim();
                Settings.Default.SQLLogin = txtSQLUser.Text.Trim();
                Settings.Default.SQLPassword = txtSQLPassword.Text;

                Settings.Default.AdminName = txtAdminName.Text.Trim();
                Settings.Default.AdminPassword = txtAdminPass.Text;
               // Settings.Default.Company = txtCompany.Text.Trim();
                // -------------------------------------------------
                //Settings.Default.AutoBackup = radYes.Checked; // True Or False
                //Settings.Default.AutoBackupPath = txtAutoBackupPath.Text; // D:\StudentBak
                int backupFiles, backupDays;
                //double discount;
               // double.TryParse(txtDiscount.Text, out discount);
                //Settings.Default.DiscountPercent = discount;
                //int.TryParse(txtBackupFiles.Text, out backupFiles);
                //Settings.Default.BackupFiles = backupFiles;
                //int.TryParse(txtBackupDays.Text, out backupDays);
                //Settings.Default.BackupDays = backupDays;
                // --------------------------------------------------------
                Settings.Default.DateFormat = cmbDateFormat.Text;

                //Settings.Default.StartUp = true;
                Settings.Default.Save();

                MessageBox.Show("Settings saved successfully", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@Database", txtDatabase.Text.Trim())};

            SqlConClass.sqlQuery = "SELECT * FROM sys.databases WHERE name =@Database";

            SqlConClass sqlCon = new SqlConClass();
            sqlCon.TestCon(SqlConClass.sqlQuery, param, txtServer.Text.Trim(), txtSQLUser.Text.Trim(), txtSQLPassword.Text);
        }
        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\" & folderBrowserDialog1.SelectedPath != DeskTopPath)
                    txtBackupPath.Text = folderBrowserDialog1.SelectedPath;
                else
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
            }
        }
        void backupDatabase()
        {
            SqlConClass.sqlQuery = "BACKUP DATABASE " + Settings.Default.Database + " TO DISK ='" + txtBackupPath.Text.Trim() + @"\" + txtBackupName.Text.Trim() + ".bak' WITH INIT";
            SqlConClass sqlCon = new SqlConClass();
            if (sqlCon.BackupDatabase(SqlConClass.sqlQuery) == 1)
            {
                Thread.Sleep(10000);
                MessageBox.Show("Database Backup successfully ", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void btnAsyncBackup_Click(object sender, EventArgs e)
        {
            if (txtBackupPath.Text == "")
            {
                btnBackupPath.PerformClick();
                return;
            }
            if (txtBackupName.Text == "")
            {
                MessageBox.Show("Please insert Backup name", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBackupName.Focus();
                return;
            }

            Task task = new Task(backupDatabase);
            task.Start();

            lblWait.Visible = true;
            this.UseWaitCursor = true;
            VariablesClass.backupProcess = true;
            await task;
            VariablesClass.backupProcess = false;
            this.UseWaitCursor = false;
            lblWait.Visible = false;

        }
        private void btnRestoeDatabase_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bakup files (*.Bak)|*.Bak|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SqlConClass.sqlQuery = "Use master Restore Database " + Settings.Default.Database + " From Disk= '" + ofd.FileName + "' WITH REPLACE";
                //SqlConClass.sqlQuery = "Use master Restore Database StudentDB From Disk= 'D:\\bak\\test1.bak' WITH REPLACE";

                SqlConClass sqlCon = new SqlConClass();
                if (sqlCon.BackupDatabase(SqlConClass.sqlQuery) == 1)
                {
                    MessageBox.Show("تم استعادة النسخة الإحتياطية من قواعد البيانات بنجاح", "انشاء نسخة أحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnAutoBackupPath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\" & folderBrowserDialog1.SelectedPath != DeskTopPath)
                {
                    //txtAutoBackupPath.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    //MessageBox.Show("لا يمكن وضع النسخة الإحتياطية على القرص الصلب" + Environment.NewLine + @"C:\" + "مباشرة أو على سطح المكتب");
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
                }
            }
        }
        private void bntCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
