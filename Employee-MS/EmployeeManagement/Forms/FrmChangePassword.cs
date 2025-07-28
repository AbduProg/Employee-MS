using EmployeeManagement;
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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = VariablesClass.userName;
            txtOldPass.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور الحالية", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();
                return;
            }
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور الجديدة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Focus();
                return;
            }

            // تحقق من كلمة المرور القديمة
            if (txtOldPass.Text != VariablesClass.userPassword)
            {
                MessageBox.Show("كلمة المرور الحالية غير صحيحة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();
                return;
            }

            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@UserPass", txtNewPass.Text);
                param[1] = new SqlParameter("@Id", VariablesClass.userId);

                SqlConClass sql = new SqlConClass();
                int result = sql.cmdExecute("UPDATE TblUseres SET UserPassword=@UserPass WHERE Id=@Id", 0, param);

                if (result > 0)
                {
                    MessageBox.Show("تم تعديل كلمة المرور بنجاح", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VariablesClass.userPassword = txtNewPass.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("لم يتم تعديل كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اتصال" + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1.Checked;
            txtOldPass.UseSystemPasswordChar = !show;
            txtNewPass.UseSystemPasswordChar = !show;
        }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtOldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtOldPass.Text != VariablesClass.userPassword)
            {
                txtOldPass.Text = "";
                txtOldPass.Focus();
                lblError.Visible = true;
            }
        }
        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            txtNewPass_Enter(sender, e);
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = false;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
    }
}
