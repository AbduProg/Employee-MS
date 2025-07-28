
using EmployeeManagement.Forms;
using EmployeeManagement.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    class FunctionsClass
    {
        public static void MsgTool(string msg, int style)
        {
            FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
            if (frmMain != null)
            {
                if (style == 1)//succesfull
                    frmMain.statusStrip1.BackColor = Color.FromArgb(128, 255, 128);
                else if (style == 2)//warning
                    frmMain.statusStrip1.BackColor = Color.FromArgb(255, 255, 128);
                else if (style == 0)// Error
                    frmMain.statusStrip1.BackColor = Color.FromArgb(255, 128, 128);

                frmMain.tslMessage.Visible = true;
                frmMain.tslMessage.Text = msg;

                frmMain.timer1.Tag = 1;

            }
        }
        public static byte[] ImageToByte(PictureBox pic)
        {
            var ms = new MemoryStream();
            if (!(pic.Image == null))
                pic.Image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        public static Image ByteToImage(byte[] img)
        {
            var ms = new MemoryStream(img);
            return Image.FromStream(ms);

        }
        public static bool CheckDgvError(DataGridView dgv)
        {
            try
            {
                if (dgv.CurrentRow == null) return true;
                if (dgv.CurrentRow.Index == dgv.Rows.Count
                    | dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value == null
                    | dgv.Rows[dgv.CurrentRow.Index].Selected == false)
                    return true;
            }
            catch
            {
                return true;
            }
            return false;
        }
        public static bool CheckDgvErrorWhithOutCheckSelect(DataGridView dgv)
        {
            try
            {
                if (dgv.CurrentRow == null) return true;
                if (dgv.CurrentRow.Index == dgv.Rows.Count
                    | dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value == null)
                    // | dgv.Rows[dgv.CurrentRow.Index].Selected == false)
                    return true;
            }
            catch
            {
                return true;
            }
            return false;
        }
        public static void Clear(GroupBox g) // tag=1 for exception
        {
            ComboBox cmb;
            PictureBox p;

            foreach (Control c in g.Controls)
            {
                int tagVal = 0;

                if (c is TextBox)
                {
                    if (c.Tag != null)
                        int.TryParse(c.Tag.ToString(), out tagVal);
                    if (tagVal != 1)
                        c.Text = "";
                }

                else if (c is ComboBox)
                {
                    cmb = (ComboBox)c;
                    if (cmb.Tag != null)
                        int.TryParse(cmb.Tag.ToString(), out tagVal);
                    if (tagVal != 1)
                        cmb.SelectedIndex = -1;
                }
                else if (c is PictureBox)
                {
                    p = (PictureBox)c;
                    if (p.Tag != null)
                        int.TryParse(p.Tag.ToString(), out tagVal);
                    if (tagVal != 1)
                        p.Image = null;
                }
            }
        }
        //-------------------------------------------------------
        public static void Clear(Panel g) // tag=1 for exception
        {
            ComboBox cmb;
            PictureBox p;
            CheckBox chk;
            DateTimePicker dtp;
            RadioButton rd;
            foreach (Control c in g.Controls)
            {
                int tagVal = 0;

                if (c is TextBox)
                {
                    if (c.Tag != null)
                        int.TryParse(c.Tag.ToString(), out tagVal);
                    if (tagVal != 1)
                        c.Text = "";
                }

                else if (c is ComboBox)
                {
                    cmb = (ComboBox)c;
                    if (cmb.Tag != null)
                        int.TryParse(cmb.Tag.ToString(), out tagVal);
                    if (tagVal != 1)
                        cmb.SelectedIndex = -1;
                    cmb.Text = string.Empty;
                }
                else if (c is PictureBox)
                {
                    p = (PictureBox)c;
                    if (p.Tag != null)
                        int.TryParse(p.Tag.ToString(), out tagVal);
                    if (tagVal != 1)
                        p.Image = null;
                }
                else if (c is CheckBox)
                {
                    chk = (CheckBox)c;
                    chk.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    dtp = (DateTimePicker)c;
                    dtp.Value = DateTime.Now;
                }
                else if (c is RadioButton)
                {
                    rd = (RadioButton)c;
                    rd.Checked = false;
                }
            }
        }
        //--------------------------------------------------
        public static bool CheckEmptyInput(GroupBox g) // tag=2 for exception
        {
            ComboBox cmb = default;

            foreach (Control c in g.Controls)
            {
                int tagVal = 0;
                if (c is TextBox)
                {
                    if (c.Tag != null)
                        int.TryParse(c.Tag.ToString(), out tagVal);

                    if (c.Text.Trim() == "" & tagVal != 2)
                    {
                        c.Focus();
                        return true;
                    }
                }

                else if (c is ComboBox)
                {
                    cmb = (ComboBox)c;

                    if (cmb.Tag != null)
                        int.TryParse(cmb.Tag.ToString(), out tagVal);

                    if (cmb.Text == string.Empty & tagVal != 2)
                    {
                        cmb.Focus();
                        //cmb.DroppedDown = true;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckEmptyInput(Panel g) // tag=2 for exception
        {
            ComboBox cmb = default;

            foreach (Control c in g.Controls)
            {
                int tagVal = 0;
                if (c is TextBox)
                {
                    if (c.Tag != null)
                        int.TryParse(c.Tag.ToString(), out tagVal);

                    if (c.Text.Trim() == "" & tagVal != 2)
                    {
                        c.Focus();
                        return true;
                    }
                }

                else if (c is ComboBox)
                {
                    cmb = (ComboBox)c;

                    if (cmb.Tag != null)
                        int.TryParse(cmb.Tag.ToString(), out tagVal);

                    if (cmb.Text == "" & tagVal != 2)
                    {
                        cmb.Focus();
                        //cmb.DroppedDown = true;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool DsHasTablesAndData(DataSet ds)
        {
            if (ds == null)
                return false;

            if (ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.Rows.Count == 0)
                        return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public static bool DsHasTablesAndData(DataSet ds, int tablesCount)
        {
            if (ds == null)
                return false;

            if (ds.Tables.Count == tablesCount)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.Rows.Count == 0)
                        return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public static bool DsHasTables(DataSet ds)
        {
            if (ds == null)
                return false;

            if (ds.Tables.Count > 0)
                return true;
            else
                return false;
        }
        public static bool DsHasTables(DataSet ds, int tablesCount)
        {
            if (ds == null)
                return false;

            if (ds.Tables.Count == tablesCount)
                return true;
            else
                return false;
        }
        public static bool DtHasData(DataTable dt)
        {
            if (dt == null)
                return false;

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static string Trim(string text)
        {
            while (text.Contains("  "))
                text = text.Replace("  ", " ");

            return text.Trim();
        }

        public static DataTable ColumnHeaderMouseClick(DataGridView dgv, DataTable dt)
        {
            if (dgv.SortOrder.ToString() == "Ascending")
                dt.DefaultView.Sort = dgv.SortedColumn.Name + " ASC";
            else if (dgv.SortOrder.ToString() == "Descending")
                dt.DefaultView.Sort = dgv.SortedColumn.Name + " DESC";

            dgv.ClearSelection();

            dt = dt.DefaultView.ToTable();
            return dt;
        }

        //===============================
        public static void BarMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                VariablesClass.sw = true;
                VariablesClass.pos = e.Location;
            }
        }
        public static void BarMouseMove(Form f, MouseEventArgs e)
        {
            if (VariablesClass.sw == true)
                f.Location = new Point(f.Location.X + (e.X - VariablesClass.pos.X), f.Location.Y + (e.Y - VariablesClass.pos.Y));
        }
        public static void BarMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                VariablesClass.sw = false;
        }
        //هاذي اصدار جديد من الدالة الي تحرك في الفورم استدعيها في load بس وضروري يكون tag =10 متع البانل الي تبي تحركها
        public void MoveForm(Form f)
        {

            foreach (var item in f.Controls)
            {
                if (item is Panel p && p.Tag?.ToString() == "10")
                {
                    p.MouseDown += (s, e) => BarMouseDown(e);
                    p.MouseMove += (s, e) => BarMouseMove(f, e);
                    p.MouseUp += (s, e) => BarMouseUp(e);

                    foreach (var c in p.Controls)
                    {
                        if (c is Label l && l.Tag?.ToString() == "10")
                        {
                            l.MouseDown += (s, e) => BarMouseDown(e);
                            l.MouseMove += (s, e) => BarMouseMove(f, e);
                            l.MouseUp += (s, e) => BarMouseUp(e);
                        }
                    }

                }
            }
        }
        //=========تكبير الخط في البوتون وتصغيره==========

        public void EditFontButton(Form f)
        {

            foreach (var item in f.Controls)
            {
                if (item is Panel p)
                {
                    foreach (var c in p.Controls)
                    {
                        if (c is Button b1 && b1.Tag?.ToString() == "10")
                        {
                            b1.MouseEnter += (s, e) => EditFont_MouseEnter(b1);
                            b1.MouseLeave += (s, e) => EditFont_MouseLeave(b1);
                        }

                    }
                }
                if (item is Button b && b.Tag?.ToString() == "10")
                {
                    b.MouseEnter += (s, e) => EditFont_MouseEnter(b);
                    b.MouseLeave += (s, e) => EditFont_MouseLeave(b);
                }
            }
        }
        //================================================
        public static bool IsPositiveIntNum(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | (Keys)e.KeyChar == Keys.Back)
                return true;
            else
                return false;
        }
        public static void IsPositiveIntNum1(KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;


            //if (char.IsNumber(e.KeyChar) | (Keys)e.KeyChar == Keys.Back)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }
        public static void IsPositiveRealNum(TextBox sender, KeyPressEventArgs e)
        {
            bool swi = false;
            //---------------نفس الكود غير مختصر ---------------------------
            // e.Handled = sender.Text.IndexOf(".") != -1 && sender.Text.Substring(sender.Text.IndexOf(".") + 1).Length > 3;
            //------------- كود الاضافي الي يوقف في الكتابة بعد الفاصلة بي 3 الرقام وتقدر اتعدلة هاذا درته اني-------------
            if (sender.Text.IndexOf(".") != -1)
            {
                swi = e.Handled = (sender.Text.Substring(sender.Text.IndexOf(".") + 1).Length > 2) ? true : false;
            }

            if (!swi || (Keys)e.KeyChar == Keys.Back)
                if (char.IsNumber((char)e.KeyChar)
                    | (Keys)e.KeyChar == Keys.Back
                    | ((Keys)e.KeyChar == (Keys)46 & sender.Text.IndexOf(".") == -1 & sender.Text.Length != 0)
                    )
                    e.Handled = false;
                else
                    e.Handled = true;

        }
        public static void IsPositiveRealNumLessThan100(TextBox sender, KeyPressEventArgs e)
        {
            bool swi = false;

            // السماح بحذف النص باستخدام Backspace
            if ((Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;
                return;
            }

            // التحقق إذا كان الإدخال رقمًا أو نقطة عشرية (وعدم وجود نقطة مسبقًا)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' || (e.KeyChar == '.' && sender.Text.Contains(".")))
            {
                e.Handled = true; // منع الإدخال إذا كان غير مسموح
                return;
            }

            // النص المتوقع إذا تم إدخال الحرف الحالي
            string newText = sender.Text.Insert(sender.SelectionStart, e.KeyChar.ToString());

            // محاولة تحويل النص المتوقع إلى رقم
            if (decimal.TryParse(newText, out decimal newValue))
            {
                // التحقق من أن القيمة أقل من أو تساوي 100
                if (newValue > 100)
                {
                    e.Handled = true; // منع الإدخال
                    return;
                }
            }
            else
            {
                e.Handled = true; // منع الإدخال إذا كان النص غير صالح
            }

            // التحقق من أن النص لا يحتوي على أكثر من خانتين عشريتين
            if (newText.Contains("."))
            {
                int decimalPlaces = newText.Length - newText.IndexOf(".") - 1;
                if (decimalPlaces > 2)
                {
                    e.Handled = true; // منع الإدخال
                }
            }
        }
        public static bool IsRealNum(TextBox sender, KeyPressEventArgs e)
        {
            if (char.IsNumber((char)e.KeyChar)
                | (Keys)e.KeyChar == Keys.Back
                | ((Keys)e.KeyChar == (Keys)46 & sender.Text.IndexOf(".") == -1 & sender.Text.Length != 0)
                | ((Keys)e.KeyChar == (Keys)45 & sender.Text.Length == 0))
                return true;
            else
                return false;

        }

        public static void IsLetterOrDigit(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)
                 & (Keys)e.KeyChar != Keys.Back
                 & (Keys)e.KeyChar != (Keys)46
                  & (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }

        }

        //-------------------هاذهي الدوال خاصة بيا اني خادمهم------------------------
        private void PicMouseEnter(PictureBox p)
        {
            p.SetBounds(p.Left - 3, p.Top - 3, p.Width + 6, p.Height + 6);
        }
        private void PicMouseLeave(PictureBox p)
        {
            p.SetBounds(p.Left + 3, p.Top + 3, p.Width - 6, p.Height - 6);
        }
        //هاذي اصداؤ جديد من بروحها تبدا دور على العناصر الي tag=5 طبق عليهم الدوال الي فوق
        public static void ApplyPicMouseEvents(Form f)
        {
            foreach (Control ctrl in f.Controls) // التكرار على جميع العناصر داخل الفورم
            {
                if (ctrl is PictureBox pic && pic.Tag?.ToString() == "5") // التأكد من أن العنصر PictureBox و Tag = "5"
                {
                    pic.MouseEnter += (s, e) =>
                    {
                        pic.SetBounds(pic.Left - 3, pic.Top - 3, pic.Width + 6, pic.Height + 6);
                    }; // إضافة الحدث عند دخول الماوس
                    pic.MouseLeave += (s, e) =>
                    {

                        pic.SetBounds(pic.Left + 3, pic.Top + 3, pic.Width - 6, pic.Height - 6);

                    };// إضافة الحدث عند خروج الماوس
                }
            }
        }


        //--------------------------------------------------------------------------
        void EditFont_MouseEnter(Button b)
        {
            Font f;
            f = b.Font;
            b.Font = new Font(f.Name, f.Size + 2, FontStyle.Regular);
        }
        void EditFont_MouseLeave(Button b)
        {
            Font f;
            f = b.Font;
            b.Font = new Font(f.Name, f.Size - 2, FontStyle.Regular);
        }
        //----------------نهاية الدوال الخاصة بيا باش ما نتلخبطش-------------------------------------------


        public static void SetFormSize(Form frm)
        {
            FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
            if (frmMain != null)
            {
                frm.Size = frmMain.Size - new Size(15, 80);
                frm.Left = frmMain.Left +7;
                frm.Top = frmMain.Top + 30;
            }
        }
        //public static void SetPermissions()
        //{
        //    FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault(); //using System.Linq;
        //    FrmPatientReceipts frmPatientReceipts = Application.OpenForms.OfType<FrmPatientReceipts>().FirstOrDefault();
        //    FrmServices frmServices = Application.OpenForms.OfType<FrmServices>().FirstOrDefault();
        //    FrmEmployee frmEmployee = Application.OpenForms.OfType<FrmEmployee>().FirstOrDefault();
        //    FrmClinics frmClinics = Application.OpenForms.OfType<FrmClinics>().FirstOrDefault();

        //    DataRow[] perm;

        //    // ----1---- - إعدادات النظام والنسخ الإحتياطي-------------------- -
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=1");

        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage6.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage6.Enabled = true;
        //        }
        //    }
        //    // ----2-----إدارة المستخدمين---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=2");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage4.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage4.Enabled = true;
        //        }
        //    }
        //    // ----3-----إدارة التقارير---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=3");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage2.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage2.Enabled = true;
        //        }
        //    }
        //    // ----4-----إدارة المشتريات والموردين---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=4");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage3.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage3.Enabled = true;
        //        }
        //    }
        //    // ----5-----إدارة شئون الموظفين---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=5");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage7.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage7.Enabled = true;
        //        }
        //    }
        //    // ----6-----إدارة الحسابات---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=6");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage5.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage5.Enabled = true;
        //        }
        //    }
        //    // ----7-----إدارة المبيعات والمرضى---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=7");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage8.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage8.Enabled = true;
        //        }
        //    }
        //    // ----8-----إدارة الإيواء---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=7");
        //        if ((bool)perm[0]["InsertP"] == false)
        //        {
        //            frmMain.tabPage9.Enabled = false;
        //        }
        //        else
        //        {
        //            frmMain.tabPage9.Enabled = true;
        //        }
        //    }
        //    // ----9-----إدارة الإستعلامات---------------------
        //    {
        //        perm = VariablesClass.dtUserPermissions.Select("OperationId=9");

        //        if ((bool)perm[0]["DeleteP"] == false)
        //        {
        //            if (frmPatientReceipts != null)
        //                frmPatientReceipts.button1.Enabled = false;
        //        }
        //        else
        //        {
        //            if (frmPatientReceipts != null)
        //                frmPatientReceipts.button1.Enabled = true;
        //        }
        //        //if ((bool)perm[0]["PrintP"] == false)
        //        //{
        //        //    if (frmPatientReceipts != null)
        //        //        frmPatientReceipts.picPrint.Enabled = false;
        //        //}
        //        //else
        //        //{
        //        //    if (frmPatientReceipts != null)
        //        //        frmPatientReceipts.picPrint.Enabled = true;
        //        //}
        //        //if ((bool)perm[0]["UpdateP"] == false)
        //        //{
        //        //    if (frmPatientReceipts != null)
        //        //        frmPatientReceipts.btnSave.Enabled = false;
        //        //}
        //        //else
        //        //{
        //        //    if (frmPatientReceipts != null)
        //        //        frmPatientReceipts.btnSave.Enabled = true;
        //        //}
        //        if ((bool)perm[0]["Freezing"] == false)
        //        {
        //            if (frmPatientReceipts != null)
        //                frmPatientReceipts.btnFreezingReceipt.Enabled = false;
        //        }
        //        else
        //        {
        //            if (frmPatientReceipts != null)
        //                frmPatientReceipts.btnFreezingReceipt.Enabled = true;
        //        }
        //        if ((bool)perm[0]["Discount"] == false)
        //        {
        //            if (frmPatientReceipts != null)
        //            {
        //                frmPatientReceipts.label14.Enabled = false;
        //                frmPatientReceipts.txtDiscount.Enabled = false;
        //                frmPatientReceipts.chkDiscount.Enabled = false;
        //            }
        //        }
        //        else
        //        {
        //            if (frmPatientReceipts != null)
        //            {
        //                frmPatientReceipts.label14.Enabled = true;
        //                frmPatientReceipts.txtDiscount.Enabled = true;
        //                frmPatientReceipts.chkDiscount.Enabled = true;
        //            }
        //        }
        //    }

        //    if (frmEmployee != null)
        //    {
        //        SetFormPermissions(10, frmEmployee, new Dictionary<string, Control>
        //        {
        //            { "DeleteP", frmEmployee.btnDelete },
        //            { "UpdateP", frmEmployee.btnEdit },
        //            { "InsertP", frmEmployee.btnAdd }
        //        });
        //    }

        //    if (frmServices != null)
        //    {
        //        SetFormPermissions(11, frmServices, new Dictionary<string, Control>
        //        {
        //            { "DeleteP", frmServices.btnDelete },
        //            { "UpdateP", frmServices.btnSave },
        //            { "InsertP", frmServices.btnAdd }
        //        });
        //    }

        //    if (frmClinics != null)
        //    {
        //        SetFormPermissions(12, frmClinics, new Dictionary<string, Control>
        //        {
        //            { "DeleteP", frmClinics.btnDelete },
        //            { "UpdateP", frmClinics.btnEdite },
        //            { "InsertP", frmClinics.btnAdd }
        //        });

        //    }
        //}

        private static void SetFormPermissions(int operationId, Form form, Dictionary<string, Control> controlPermissions)
        {
            if (form == null) return;

            DataRow[] perm = VariablesClass.dtUserPermissions.Select($"OperationId={operationId}");
            if (perm.Length == 0) return;

            foreach (var permission in controlPermissions)
            {
                bool isEnabled = (bool)perm[0][permission.Key];
                permission.Value.Enabled = isEnabled;
            }
        }

        public static void EnterCode(Control c, KeyEventArgs e)
        {
            TextBox t;
            ComboBox Cb;
            DateTimePicker dtp;
            RadioButton rad;
            if (e.KeyCode == Keys.Enter)
            {
                if (c is TextBox)
                {
                    t = (TextBox)c;
                    t.Focus();
                }
                else if (c is ComboBox)
                {
                    Cb = (ComboBox)c;
                    Cb.Focus();
                    Cb.DroppedDown = true;
                }
                else if (c is DateTimePicker)
                {
                    dtp = (DateTimePicker)c;
                    dtp.Focus();
                }
                else if (c is RadioButton)
                {
                    rad = (RadioButton)c;
                    rad.Focus();
                }
            }

        }


        public static void FillCmb(DataTable dt, ComboBox combo, string ColumName)
        {
            combo.DataSource = dt;
            combo.DisplayMember = ColumName;
            combo.ValueMember = "Id";
            combo.SelectedIndex = -1;
        }
        //-----طبعا هاذي الدالة اني درتها +يارد+ تعطي في تنسيق التاريخ لي فورم كامل-----

        //دالة تقوم بالبحث عن كل DateTimePicker داخل الفورم

        public static void ApplyDateTimePickerFormat(Form form)
        {
            foreach (Control control in form.Controls)
            {
                // استدعاء دالة البحث عن العناصر الفرعية كذلك
                SetDateTimePickerFormatRecursive(control, Settings.Default.DateFormat);
            }
        }

        // دالة تبحث داخل كل عنصر تحكم وأي عناصر تحكم فرعية بداخلها
        private static void SetDateTimePickerFormatRecursive(Control control, string customFormat)
        {
            if (control is DateTimePicker dateTimePicker)
            {
                // تطبيق التنسيق المخصص على DateTimePicker
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = customFormat;
            }

            // البحث في العناصر الفرعية بداخل العنصر الحالي
            foreach (Control childControl in control.Controls)
            {
                SetDateTimePickerFormatRecursive(childControl, customFormat);
            }
        }


        //  دالة تقوم بتطبيق تنسيق التاريخ على الأعمدة التي تحتوي على تواريخ في DataGridView

        public static void ApplyDateFormatToDataGridViewColumns(DataGridView dataGridView)
        {
            // تمر على كل الأعمدة في DataGridView
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                // إذا كان العمود يحتوي على تواريخ، نقوم بتعيين التنسيق المخصص
                if (column is DataGridViewTextBoxColumn)
                {
                    // تأكد من أن العمود يحتوي على قيم يمكن أن تكون تواريخ
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[column.Index].Value != null && DateTime.TryParse(row.Cells[column.Index].Value.ToString(), out DateTime _) && double.TryParse(row.Cells[column.Index].Value.ToString(), out double _) != true)
                        {
                            // تعيين تنسيق التاريخ المخزن في الإعدادات
                            column.DefaultCellStyle.Format = Settings.Default.DateFormat;
                            break; // نخرج من الحلقة لأننا نعلم أن العمود يحتوي على تواريخ
                        }
                    }
                }
            }
        }

        public static void ApplyDateFormatToDataGridViewColumns(DataGridView dataGridView, string Format)
        {
            // تمر على كل الأعمدة في DataGridView
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                // إذا كان العمود يحتوي على تواريخ، نقوم بتعيين التنسيق المخصص
                if (column is DataGridViewTextBoxColumn)
                {
                    // تأكد من أن العمود يحتوي على قيم يمكن أن تكون تواريخ
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[column.Index].Value != null && DateTime.TryParse(row.Cells[column.Index].Value.ToString(), out DateTime _) && double.TryParse(row.Cells[column.Index].Value.ToString(), out double _) != true)
                        {
                            // تعيين تنسيق التاريخ المخزن في الإعدادات
                            column.DefaultCellStyle.Format = Format;
                            break; // نخرج من الحلقة لأننا نعلم أن العمود يحتوي على تواريخ
                        }
                    }
                }
            }
        }

        public static void FocusTextBox(TextBox t)
        {
            t.Select();
            t.Focus();
            t.SelectAll();
        }



        //هاذهي الدالة قمت بي اضافتها وهي//by reference iam Yared

        public static void UpdateDataset(ref DataSet targetDataSet, ref DataSet sourceDataSet, int targetIndex, int sourceIndex)
        {
            if (targetDataSet == null || sourceDataSet == null)
                return;

            if (targetDataSet.Tables.Count == 0 || sourceDataSet.Tables.Count == 0)
                return;

            targetDataSet.Tables[targetIndex].Clear();
            targetDataSet.Tables[targetIndex].Merge(sourceDataSet.Tables[sourceIndex]);
            sourceDataSet.Tables[sourceIndex].Clear();
        }

        public static bool IsComboBoxValueNull(ComboBox comboBox)
        {
            return comboBox.SelectedValue == null;
        }
        //هاذهي الدال اني درتها Yared تقوم بي تطبيق resize على الفورم استدعي الدالة في load بس وهي تهتم بي البياقي
        public static void SetupResizeControls(Form form, DataGridView dataGrid)
        {
            ResizeControls resize = new ResizeControls();
            resize.Container = form;

            form.Resize += (s, e) =>
            {
                resize.ResizeControl();
                dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 12, FontStyle.Regular);
                dataGrid.DefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Regular);
            };

            form.HandleCreated += (s, e) =>
            {
                resize.Container = form;
            };
        }


        //دالة التصدير الى اكسل Yared الكود دارة عبدالله واني حولتها لي الدالة باش معاش نكرروه

        public static void ExportToExcel(DataGridView dgv, string fileName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لتصديرها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel File (*.csv)|*.csv";
            saveFile.FileName = $"{fileName}.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
                {
                    // كتابة رؤوس الأعمدة
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(dgv.Columns[i].HeaderText);
                        if (i < dgv.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // كتابة البيانات
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString());
                            if (i < dgv.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("تم تصدير البيانات بنجاح", "تصدير بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
