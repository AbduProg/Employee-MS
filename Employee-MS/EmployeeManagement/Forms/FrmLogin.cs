using EmployeeManagement;
using EmployeeManagement.Forms;
using EmployeeManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        int timerCount;

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            //if (DateTime.Now.Date >= Convert.ToDateTime("7/13/2025"))
            //{
            //    MessageBox.Show("انتهت فترة استخدام البرنامج، يرجى التواصل مع الدعم الفني لتجديد الفترة", "انتهاء الفترة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Environment.Exit(0);
            //}



            try
            {
                SqlConClass sql = new SqlConClass();
                DataSet ds = sql.selectData("SELECT * FROM TblUseres", 0, null);
                dt = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();

                cmbUserName.DataSource = dt;
                cmbUserName.DisplayMember = "userName";
                cmbUserName.ValueMember = "Id";

                txtPassword.Select();
                cmbUserName.SelectedValue = Settings.Default.SelectedUser;
                cmbUserName_SelectionChangeCommitted(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" +
                    Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                FrmAdmin frmAdmin = new FrmAdmin();
                frmAdmin.ShowDialog();
            }

            this.Top = -this.Height;
            timer1.Enabled = true;
            txtPassword.Select();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Top = this.Top + 30;
            if (this.Top > (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2)
            {
                timer1.Enabled = false;
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();

            int cr = cmbUserName.SelectedIndex;
            if (cr == -1)
                return;

            if (!(dt.Rows[cr][4] is DBNull))
            {
                byte[] img = (byte[])dt.Rows[cr][4];
                picUser.Image = FunctionsClass.ByteToImage(img);
            }
            else
            {
                picUser.Image = null;
            }
        }

        private void cmbUserName_TextChanged(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedValue == null)
            {
                lblUser.Text = "";
                picUser.Image = null;
            }
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedValue == null)
            {
                lblUser.Text = "";
                return;
            }
            lblUser.Text = "رقم التسجيل >> " + cmbUserName.SelectedValue;

            Settings.Default.SelectedUser = Convert.ToInt32(cmbUserName.SelectedValue);
            Settings.Default.Save();
        }

        private void cmbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbUserName_SelectionChangeCommitted(sender, e);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbUserName.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ادخال اسم المستخدم", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (cmbUserName.Text.Trim() == dt.Rows[i][1].ToString())
                {
                    if (txtPassword.Text == dt.Rows[i][2].ToString())
                    {
                        VariablesClass.userId = (int)dt.Rows[i][0];
                        VariablesClass.userName = Convert.ToString(dt.Rows[i][1]);
                        VariablesClass.userPassword = dt.Rows[i][2].ToString();
                        VariablesClass.userJob = (string)dt.Rows[i][3];

                        VariablesClass.updatePermission = (bool)dt.Rows[i][5];
                        VariablesClass.insertPermission = (bool)dt.Rows[i][6];
                        VariablesClass.printPermission = (bool)dt.Rows[i][7];
                        VariablesClass.usersPermission = (bool)dt.Rows[i][8];
                        VariablesClass.settingsPermission = Convert.ToBoolean(dt.Rows[i][9]);

                        if (txtPassword.Text == "0000")
                        {
                            MessageBox.Show("يرجى تغيير كلمة المرور الإفتراضية");
                            FrmChangePassword frmChangePassword = new FrmChangePassword();
                            frmChangePassword.ShowDialog();
                            if (VariablesClass.userPassword == "0000")
                            {
                                MessageBox.Show("لم يتم تغيير كلمة المرور الافتراضية، سيتم اغلاق النظام", "رفض الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Environment.Exit(0);
                            }
                        }
                        Settings.Default.ErrorLoginCount = 0;
                        Settings.Default.Save();
                        this.Hide();
                        FrmMain frmMain = new FrmMain();
                        frmMain.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        Settings.Default.ErrorLoginCount++;
                        Settings.Default.Save();
                        if (Settings.Default.ErrorLoginCount < 3)
                        {
                            MessageBox.Show("كلمة المرور غير صحيحة لقد استنفذت " + Settings.Default.ErrorLoginCount + " من 3 محاولات", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Clear();
                            txtPassword.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("لقد استنفذت جميع المحاولات", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            timerCount = 30;
                            btnOk.Text = timerCount.ToString();
                            this.Enabled = false;
                            timer2.Enabled = true;
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("اسم المستخدم غير مسجل في المنظومة", "خطأ في الدخول", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cmbUserName.SelectAll();
            cmbUserName.Focus();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerCount--;
            btnOk.Text = timerCount.ToString();
            if (timerCount == 0)
            {
                this.Enabled = true;
                timer2.Enabled = false;
                btnOk.Text = "موافق";
                txtPassword.Text = "";
                txtPassword.Focus();
                Settings.Default.ErrorLoginCount = 0;
                Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
