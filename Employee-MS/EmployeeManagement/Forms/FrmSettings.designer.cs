
namespace EmployeeManagement.Forms
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.cmbDateFormat = new System.Windows.Forms.ComboBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSQLPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnAsyncBackup = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.btnRestoeDatabase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.par = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.par.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDateFormat
            // 
            this.cmbDateFormat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDateFormat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateFormat.FormattingEnabled = true;
            this.cmbDateFormat.Location = new System.Drawing.Point(156, 49);
            this.cmbDateFormat.Name = "cmbDateFormat";
            this.cmbDateFormat.Size = new System.Drawing.Size(297, 29);
            this.cmbDateFormat.TabIndex = 310;
            // 
            // txtAdminName
            // 
            this.txtAdminName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdminName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.ForeColor = System.Drawing.Color.Black;
            this.txtAdminName.Location = new System.Drawing.Point(155, 22);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdminName.Size = new System.Drawing.Size(298, 29);
            this.txtAdminName.TabIndex = 48;
            this.txtAdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "كلمة المرور";
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdminPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.Location = new System.Drawing.Point(156, 58);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '*';
            this.txtAdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdminPass.Size = new System.Drawing.Size(297, 29);
            this.txtAdminPass.TabIndex = 49;
            this.txtAdminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "اسم المسؤل";
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSQLUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLUser.ForeColor = System.Drawing.Color.Black;
            this.txtSQLUser.Location = new System.Drawing.Point(153, 119);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSQLUser.Size = new System.Drawing.Size(300, 29);
            this.txtSQLUser.TabIndex = 44;
            this.txtSQLUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(19, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "كلمة المرور";
            // 
            // txtSQLPassword
            // 
            this.txtSQLPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSQLPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLPassword.Location = new System.Drawing.Point(153, 160);
            this.txtSQLPassword.Name = "txtSQLPassword";
            this.txtSQLPassword.PasswordChar = '*';
            this.txtSQLPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSQLPassword.Size = new System.Drawing.Size(300, 29);
            this.txtSQLPassword.TabIndex = 45;
            this.txtSQLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "اسم المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "اسم قاعدة البيانات";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDatabase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(153, 74);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatabase.Size = new System.Drawing.Size(300, 29);
            this.txtDatabase.TabIndex = 35;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(21, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "اسم الخادم";
            // 
            // sfd
            // 
            this.sfd.Filter = "Bakup files (*.Bak)|*.Bak";
            // 
            // ofd
            // 
            this.ofd.Filter = "Bakup files (*.Bak)|*.Bak";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.Color.Black;
            this.txtServer.Location = new System.Drawing.Point(153, 36);
            this.txtServer.Name = "txtServer";
            this.txtServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServer.Size = new System.Drawing.Size(300, 29);
            this.txtServer.TabIndex = 34;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(17, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 311;
            this.label11.Text = "تنسيق التاريخ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTestConnection);
            this.groupBox5.Controls.Add(this.txtSQLUser);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtSQLPassword);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtServer);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtDatabase);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new System.Drawing.Point(507, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(471, 265);
            this.groupBox5.TabIndex = 304;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "اعدادات الاتصال بقاعدة البيانات";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTestConnection.FlatAppearance.BorderSize = 0;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.White;
            this.btnTestConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnTestConnection.Image")));
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(25, 206);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(429, 40);
            this.btnTestConnection.TabIndex = 282;
            this.btnTestConnection.Text = "اختبار الاتصال";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 302;
            this.label7.Text = "اسم الشركة";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(156, 13);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompany.Size = new System.Drawing.Size(297, 29);
            this.txtCompany.TabIndex = 303;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWait);
            this.groupBox1.Controls.Add(this.btnAsyncBackup);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnBackupPath);
            this.groupBox1.Controls.Add(this.btnRestoeDatabase);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBackupName);
            this.groupBox1.Controls.Add(this.txtBackupPath);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(472, 265);
            this.groupBox1.TabIndex = 306;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نسخ الاحتياطي";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(211)))), ((int)(((byte)(170)))));
            this.lblWait.Location = new System.Drawing.Point(152, 230);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(191, 22);
            this.lblWait.TabIndex = 281;
            this.lblWait.Text = "الرجاء الانظار تتم المعابجة....";
            this.lblWait.Visible = false;
            // 
            // btnAsyncBackup
            // 
            this.btnAsyncBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAsyncBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsyncBackup.FlatAppearance.BorderSize = 0;
            this.btnAsyncBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsyncBackup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsyncBackup.ForeColor = System.Drawing.Color.White;
            this.btnAsyncBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsyncBackup.Location = new System.Drawing.Point(147, 125);
            this.btnAsyncBackup.Name = "btnAsyncBackup";
            this.btnAsyncBackup.Size = new System.Drawing.Size(310, 40);
            this.btnAsyncBackup.TabIndex = 280;
            this.btnAsyncBackup.Text = "اخد نسخة احتياطية";
            this.btnAsyncBackup.UseVisualStyleBackColor = false;
            this.btnAsyncBackup.Click += new System.EventHandler(this.btnAsyncBackup_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(29, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 279;
            this.label10.Text = "اسم النسخة";
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnBackupPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupPath.FlatAppearance.BorderSize = 0;
            this.btnBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupPath.ForeColor = System.Drawing.Color.White;
            this.btnBackupPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupPath.Location = new System.Drawing.Point(11, 43);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(131, 30);
            this.btnBackupPath.TabIndex = 278;
            this.btnBackupPath.Text = "مسار النسخ";
            this.btnBackupPath.UseVisualStyleBackColor = false;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // btnRestoeDatabase
            // 
            this.btnRestoeDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnRestoeDatabase.FlatAppearance.BorderSize = 0;
            this.btnRestoeDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoeDatabase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoeDatabase.ForeColor = System.Drawing.Color.White;
            this.btnRestoeDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoeDatabase.Image")));
            this.btnRestoeDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoeDatabase.Location = new System.Drawing.Point(147, 175);
            this.btnRestoeDatabase.Name = "btnRestoeDatabase";
            this.btnRestoeDatabase.Size = new System.Drawing.Size(308, 40);
            this.btnRestoeDatabase.TabIndex = 263;
            this.btnRestoeDatabase.Text = "استعادة نسخة احتياطية";
            this.btnRestoeDatabase.UseVisualStyleBackColor = false;
            this.btnRestoeDatabase.Click += new System.EventHandler(this.btnRestoeDatabase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // txtBackupName
            // 
            this.txtBackupName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBackupName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupName.Location = new System.Drawing.Point(147, 84);
            this.txtBackupName.MaxLength = 50;
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(312, 29);
            this.txtBackupName.TabIndex = 52;
            this.txtBackupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupPath.Location = new System.Drawing.Point(147, 42);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(312, 29);
            this.txtBackupPath.TabIndex = 50;
            this.txtBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAdminName);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtAdminPass);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(507, 339);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(471, 96);
            this.groupBox6.TabIndex = 285;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbDateFormat);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtCompany);
            this.groupBox7.Location = new System.Drawing.Point(11, 339);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(474, 96);
            this.groupBox7.TabIndex = 312;
            this.groupBox7.TabStop = false;
            // 
            // par
            // 
            this.par.BackColor = System.Drawing.SystemColors.Control;
            this.par.Controls.Add(this.btnExit);
            this.par.Controls.Add(this.label15);
            this.par.Dock = System.Windows.Forms.DockStyle.Top;
            this.par.Location = new System.Drawing.Point(0, 0);
            this.par.Margin = new System.Windows.Forms.Padding(4);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(992, 46);
            this.par.TabIndex = 712;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(939, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 46);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Hacen Saudi Arabia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(432, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 31);
            this.label15.TabIndex = 26;
            this.label15.Text = "الإعدادات";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(507, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(471, 40);
            this.btnSave.TabIndex = 307;
            this.btnSave.Text = "حفظ الاعدادات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.bntCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancel.FlatAppearance.BorderSize = 0;
            this.bntCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.ForeColor = System.Drawing.Color.White;
            this.bntCancel.Image = ((System.Drawing.Image)(resources.GetObject("bntCancel.Image")));
            this.bntCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancel.Location = new System.Drawing.Point(11, 441);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(474, 40);
            this.bntCancel.TabIndex = 308;
            this.bntCancel.Text = "الغاء";
            this.bntCancel.UseVisualStyleBackColor = false;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 496);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.par);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الضبط";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.par.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbDateFormat;
        internal System.Windows.Forms.TextBox txtAdminName;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtAdminPass;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtSQLUser;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtSQLPassword;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtDatabase;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.SaveFileDialog sfd;
        internal System.Windows.Forms.OpenFileDialog ofd;
        internal System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button bntCancel;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtCompany;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btnBackupPath;
        internal System.Windows.Forms.Button btnRestoeDatabase;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox txtBackupName;
        internal System.Windows.Forms.TextBox txtBackupPath;
        internal System.Windows.Forms.Button btnAsyncBackup;
        internal System.Windows.Forms.Label lblWait;
        internal System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.Panel par;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label label15;
    }
}