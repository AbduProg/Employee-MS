using EmployeeManagement;
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

namespace EmployeeManagement.Forms
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        int currentUserID = 0, cr = -1;
        DataTable dtUsers = new DataTable();

        void SetPermissions()
        {


            picAdd.Enabled = VariablesClass.insertPermission;

            picUpdate.Enabled = VariablesClass.updatePermission;

            picDelete.Enabled = VariablesClass.updatePermission;
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            FunctionsClass.SetFormSize(this);

            fillDgvUsers();
            setFormSize();
        }

        void setFormSize()
        {
            FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
            if (frmMain != null)
            {
                this.Size = frmMain.Size - new Size(0, 60);
                this.Left = frmMain.Left;
                this.Top = frmMain.Top + 30;
            }
        }

        void fillDgvUsers()
        {
            dgvUsers.Rows.Clear();
            dtUsers.Clear();

            try
            {
                SqlConClass sql = new SqlConClass();
                DataSet ds = sql.selectData("SELECT * FROM TblUseres", 0, null);
                if (FunctionsClass.DsHasTablesAndData(ds))
                {
                    dtUsers = ds.Tables[0];
                    for (int i = 0; i < dtUsers.Rows.Count; i++)
                    {
                        dgvUsers.Rows.Add(dtUsers.Rows[i][0], i + 1, dtUsers.Rows[i][1], "************", dtUsers.Rows[i][3], dtUsers.Rows[i][0], null);

                        dgvUsers.Rows[i].Cells[0].Value = dtUsers.Rows[i][0];
                        dgvUsers.Rows[i].Cells[1].Value = i + 1;
                        dgvUsers.Rows[i].Cells[2].Value = dtUsers.Rows[i][1];
                        dgvUsers.Rows[i].Cells[3].Value = "************";
                        dgvUsers.Rows[i].Cells[4].Value = dtUsers.Rows[i][3];
                        dgvUsers.Rows[i].Cells[5].Value = dtUsers.Rows[i][0];

                        dgvUsers.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                        if ((bool)dtUsers.Rows[i][5] && (bool)dtUsers.Rows[i][6] && (bool)dtUsers.Rows[i][7] && (bool)dtUsers.Rows[i][8] && (bool)dtUsers.Rows[i][9])
                        {
                            dgvUsers.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        }

                        if (!(dtUsers.Rows[i][4] is DBNull))
                        {
                            byte[] img = (byte[])dtUsers.Rows[i][4];
                            dgvUsers.Rows[i].Cells[6].Value = FunctionsClass.ByteToImage(img);
                        }
                    }
                }
                dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow == null) return;
                if (dgvUsers.CurrentRow.Index == dgvUsers.Rows.Count
                    || dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value == null
                    || dgvUsers.Rows[dgvUsers.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            if ((int)dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value == 1 && VariablesClass.userId != 1)
            {
                clearText();
                return;
            }

            cr = dgvUsers.CurrentRow.Index;

            currentUserID = (int)dgvUsers.Rows[cr].Cells[0].Value;
            txtUserName.Text = dgvUsers.Rows[cr].Cells[2].Value.ToString();
            txtUserPassword.Text = dgvUsers.Rows[cr].Cells[3].Value.ToString();
            txtUserJob.Text = dgvUsers.Rows[cr].Cells[4].Value.ToString();
            picUser.Image = (Image)dgvUsers.Rows[cr].Cells[6].Value;

            if (picUser.Image != null)
                picUser.ContextMenuStrip = contextMenuStrip1;
            else
                picUser.ContextMenuStrip = null;

            if (chkAdmin.Checked == true)
                chkAdmin.Checked = false;
            else
                chkAdmin_CheckedChanged(sender, e);

            chkUpdate.Checked = (bool)dtUsers.Rows[cr][5];
            chkInsert.Checked = (bool)dtUsers.Rows[cr][6];
            chkPrint.Checked = (bool)dtUsers.Rows[cr][7];
            chkUsers.Checked = (bool)dtUsers.Rows[cr][8];
            chkSettings.Checked = (bool)dtUsers.Rows[cr][9];
        }

        private void BtnResetPass_Click(object sender, EventArgs e)
        {
            txtUserPassword.Text = "0000";
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked == true)
            {
                foreach (CheckBox c in tlpPermissions.Controls)
                {
                    if (c.Name != "chkAdmin")
                    {
                        c.Checked = true;
                        c.Enabled = false;
                    }
                }
            }
            else if (chkAdmin.Checked == false)
            {
                foreach (CheckBox c in tlpPermissions.Controls)
                {
                    c.Checked = false;
                    c.Enabled = true;
                }
            }
        }

        private void chkInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked && chkInsert.Checked && chkPrint.Checked && chkUsers.Checked && chkSettings.Checked)
                chkAdmin.Checked = true;
        }

        private void picUser_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picUser.Image = Image.FromFile(openFileDialog1.FileName);
                    picUser.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void cmsDeletePicture_Click(object sender, EventArgs e)
        {
            picUser.Image = null;
            picUser.ContextMenuStrip = null;
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            clearText();
            fillDgvUsers();
        }

        void clearText()
        {
            picUser.Image = null;
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }

            foreach (CheckBox c in tlpPermissions.Controls)
            {
                if (c is CheckBox)
                {
                    c.Checked = false;
                    c.Enabled = true;
                }
            }

            currentUserID = 0;
            cr = -1;
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUsers.SortOrder.ToString() == "Ascending")
                dtUsers.DefaultView.Sort = dgvUsers.SortedColumn.Name + " ASC";
            else if (dgvUsers.SortOrder.ToString() == "Descending")
                dtUsers.DefaultView.Sort = dgvUsers.SortedColumn.Name + " DESC";

            dtUsers = dtUsers.DefaultView.ToTable();
        }

        private void dgvUsers_Sorted(object sender, EventArgs e)
        {
            clearText();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
                return;

            if (currentUserID == VariablesClass.userId)
            {
                MessageBox.Show("لا يمكنك حذف نفسك", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(" هل تريد بالتأكيد حذف " + txtUserName.Text, "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@Id", currentUserID);

                    SqlConClass sql = new SqlConClass();
                    int saveState = sql.cmdExecute("UserDelete", 1, param);

                    if (saveState == 1)
                    {
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipText = "تم الحذف بنجاح";
                        notifyIcon1.ShowBalloonTip(1);
                        picRefresh_Click(sender, e);
                    }
                    else if (saveState == 2)
                    {
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                        notifyIcon1.BalloonTipText = "لا يمكن حذف المستخدم" + Environment.NewLine + "يوجد عمليات أرشفة قام بها";
                        notifyIcon1.ShowBalloonTip(1);
                    }
                    else if (saveState == 0)
                    {
                        picRefresh_Click(sender, e);
                        MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (currentUserID != 0)
                return;

            if (txtUserName.Text.Trim() == "" || txtUserPassword.Text == "" || txtUserJob.Text == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@userName", txtUserName.Text.Trim());
            param[1] = new SqlParameter("@UserPass", txtUserPassword.Text);
            param[2] = new SqlParameter("@userJob", txtUserJob.Text.Trim());
            param[3] = new SqlParameter("@UserPic", picUser.Image == null ? null : FunctionsClass.ImageToByte(picUser));
            param[4] = new SqlParameter("@UpdateP", chkUpdate.Checked);
            param[5] = new SqlParameter("@InsertP", chkInsert.Checked);
            param[6] = new SqlParameter("@PrintP", chkPrint.Checked);
            param[7] = new SqlParameter("@UsersP", chkUsers.Checked);
            param[8] = new SqlParameter("@SettingsP", chkSettings.Checked);

            SqlConClass sql = new SqlConClass();
            int saveState = sql.cmdExecute("UserInsert", 1, param);

            if (saveState == 1)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                notifyIcon1.ShowBalloonTip(1);
                picRefresh_Click(sender, e);
            }
            else if (saveState == 2)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "اسم المستخدم مسجل مسبقاً";
                notifyIcon1.ShowBalloonTip(1);
            }
            else if (saveState == 0)
            {
                MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            picUser_MouseUp(sender, (MouseEventArgs)e);
        }

        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
                return;

            if (txtUserName.Text.Trim() == "" || txtUserPassword.Text == "" || txtUserJob.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("@Id", currentUserID);
                param[1] = new SqlParameter("@UserName", txtUserName.Text.Trim());
                param[2] = new SqlParameter("@UserPass", txtUserPassword.Text == "0000" ? txtUserPassword.Text : dtUsers.Rows[cr][2]);
                param[3] = new SqlParameter("@UserJob", txtUserJob.Text.Trim());
                param[4] = new SqlParameter("@UpdateP", chkUpdate.Checked);
                param[5] = new SqlParameter("@InsertP", chkInsert.Checked);
                param[6] = new SqlParameter("@PrintP", chkPrint.Checked);
                param[7] = new SqlParameter("@UsersP", chkUsers.Checked);
                param[8] = new SqlParameter("@SettingsP", chkSettings.Checked);
                param[9] = new SqlParameter("@UserPic", picUser.Image == null ? null: FunctionsClass.ImageToByte(picUser));

                SqlConClass sql = new SqlConClass();
                int saveState = sql.cmdExecute("UserUpdate", 1, param);

                if (saveState == 1)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                    notifyIcon1.ShowBalloonTip(1);
                    picRefresh_Click(sender, e);
                }
                else if (saveState == 2)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "اسم المستخدم مسجل مسبقاً";
                    notifyIcon1.ShowBalloonTip(1);
                }
                else if (saveState == 0)
                {
                    MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
