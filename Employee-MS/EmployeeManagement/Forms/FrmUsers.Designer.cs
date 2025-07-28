namespace EmployeeManagement.Forms
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeletePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpPermissions = new System.Windows.Forms.TableLayoutPanel();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.chkSettings = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpPic = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserJob = new System.Windows.Forms.TextBox();
            this.tlpBtns = new System.Windows.Forms.TableLayoutPanel();
            this.BtnResetPass = new System.Windows.Forms.Button();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tlpPermissions.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpPic.SuspendLayout();
            this.tlpBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "منظومة الارشفة";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "إشعار";
            this.notifyIcon1.Visible = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeletePicture});
            this.contextMenuStrip1.Name = "ContextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // cmsDeletePicture
            // 
            this.cmsDeletePicture.Name = "cmsDeletePicture";
            this.cmsDeletePicture.Size = new System.Drawing.Size(136, 22);
            this.cmsDeletePicture.Text = "مسح الصورة";
            this.cmsDeletePicture.Click += new System.EventHandler(this.cmsDeletePicture_Click);
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 5;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpContainer.Controls.Add(this.dgvUsers, 1, 5);
            this.tlpContainer.Controls.Add(this.tlpPermissions, 1, 3);
            this.tlpContainer.Controls.Add(this.grpUserInfo, 2, 1);
            this.tlpContainer.Controls.Add(this.tlpBtns, 1, 1);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(2);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 7;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpContainer.Size = new System.Drawing.Size(1015, 687);
            this.tlpContainer.TabIndex = 956;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowDrop = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.UserName,
            this.UserPassword,
            this.UserJob,
            this.Id,
            this.column5});
            this.tlpContainer.SetColumnSpan(this.dgvUsers, 3);
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.Gray;
            this.dgvUsers.Location = new System.Drawing.Point(21, 375);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 102;
            this.dgvUsers.RowTemplate.DividerHeight = 3;
            this.dgvUsers.RowTemplate.Height = 33;
            this.dgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(973, 293);
            this.dgvUsers.TabIndex = 955;
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            this.dgvUsers.Sorted += new System.EventHandler(this.dgvUsers_Sorted);
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 35.53299F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ت";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "اسم المستخدم";
            this.UserName.MinimumWidth = 12;
            this.UserName.Name = "UserName";
            // 
            // UserPassword
            // 
            this.UserPassword.HeaderText = "كلمة المرور";
            this.UserPassword.MinimumWidth = 12;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserJob
            // 
            this.UserJob.HeaderText = "الوظيفة";
            this.UserJob.MinimumWidth = 12;
            this.UserJob.Name = "UserJob";
            // 
            // Id
            // 
            this.Id.HeaderText = "رقم التسجيل";
            this.Id.MinimumWidth = 12;
            this.Id.Name = "Id";
            // 
            // column5
            // 
            this.column5.HeaderText = "الصورة";
            this.column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.column5.MinimumWidth = 12;
            this.column5.Name = "column5";
            // 
            // tlpPermissions
            // 
            this.tlpPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.tlpPermissions.ColumnCount = 7;
            this.tlpContainer.SetColumnSpan(this.tlpPermissions, 3);
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPermissions.Controls.Add(this.chkAdmin, 5, 0);
            this.tlpPermissions.Controls.Add(this.chkInsert, 0, 0);
            this.tlpPermissions.Controls.Add(this.chkSettings, 4, 0);
            this.tlpPermissions.Controls.Add(this.chkUpdate, 1, 0);
            this.tlpPermissions.Controls.Add(this.chkUsers, 3, 0);
            this.tlpPermissions.Controls.Add(this.chkPrint, 2, 0);
            this.tlpPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPermissions.Location = new System.Drawing.Point(19, 291);
            this.tlpPermissions.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPermissions.Name = "tlpPermissions";
            this.tlpPermissions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpPermissions.RowCount = 1;
            this.tlpPermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPermissions.Size = new System.Drawing.Size(977, 63);
            this.tlpPermissions.TabIndex = 230;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkAdmin.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkAdmin.ForeColor = System.Drawing.Color.Firebrick;
            this.chkAdmin.Location = new System.Drawing.Point(33, 3);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAdmin.Size = new System.Drawing.Size(123, 57);
            this.chkAdmin.TabIndex = 59;
            this.chkAdmin.Text = "جميع الصلاحيات";
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkInsert.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkInsert.ForeColor = System.Drawing.Color.Black;
            this.chkInsert.Location = new System.Drawing.Point(823, 3);
            this.chkInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInsert.Size = new System.Drawing.Size(102, 57);
            this.chkInsert.TabIndex = 54;
            this.chkInsert.Text = "إضافة بيانات";
            this.chkInsert.UseVisualStyleBackColor = true;
            this.chkInsert.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkSettings
            // 
            this.chkSettings.AutoSize = true;
            this.chkSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSettings.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkSettings.ForeColor = System.Drawing.Color.Black;
            this.chkSettings.Location = new System.Drawing.Point(191, 3);
            this.chkSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSettings.Name = "chkSettings";
            this.chkSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSettings.Size = new System.Drawing.Size(127, 57);
            this.chkSettings.TabIndex = 58;
            this.chkSettings.Text = "إعدادات المنظومة";
            this.chkSettings.UseVisualStyleBackColor = true;
            this.chkSettings.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkUpdate.ForeColor = System.Drawing.Color.Black;
            this.chkUpdate.Location = new System.Drawing.Point(665, 3);
            this.chkUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUpdate.Size = new System.Drawing.Size(108, 57);
            this.chkUpdate.TabIndex = 55;
            this.chkUpdate.Text = "تعديل البيانات";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkUsers.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkUsers.ForeColor = System.Drawing.Color.Black;
            this.chkUsers.Location = new System.Drawing.Point(349, 3);
            this.chkUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUsers.Size = new System.Drawing.Size(123, 57);
            this.chkUsers.TabIndex = 57;
            this.chkUsers.Text = "إدارة المستخدمين";
            this.chkUsers.UseVisualStyleBackColor = true;
            this.chkUsers.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkPrint.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkPrint.ForeColor = System.Drawing.Color.Black;
            this.chkPrint.Location = new System.Drawing.Point(507, 3);
            this.chkPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPrint.Size = new System.Drawing.Size(107, 57);
            this.chkPrint.TabIndex = 56;
            this.chkPrint.Text = "طباعة التقارير";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // grpUserInfo
            // 
            this.tlpContainer.SetColumnSpan(this.grpUserInfo, 2);
            this.grpUserInfo.Controls.Add(this.tableLayoutPanel2);
            this.grpUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserInfo.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.grpUserInfo.ForeColor = System.Drawing.Color.Black;
            this.grpUserInfo.Location = new System.Drawing.Point(209, 19);
            this.grpUserInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpUserInfo.Size = new System.Drawing.Size(785, 251);
            this.grpUserInfo.TabIndex = 951;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "بيانات المستخدم";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Controls.Add(this.txtUserName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tlpPic, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtUserPassword, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUserJob, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnResetPass, 4, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 218);
            this.tableLayoutPanel2.TabIndex = 230;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(505, 30);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(147, 34);
            this.txtUserName.TabIndex = 229;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(660, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 94);
            this.label1.TabIndex = 222;
            this.label1.Text = "اسم المستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPic
            // 
            this.tlpPic.ColumnCount = 1;
            this.tlpPic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPic.Controls.Add(this.btnLoadPic, 0, 0);
            this.tlpPic.Controls.Add(this.picUser, 0, 1);
            this.tlpPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPic.Location = new System.Drawing.Point(21, 2);
            this.tlpPic.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPic.Name = "tlpPic";
            this.tlpPic.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tlpPic, 3);
            this.tlpPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.3112F));
            this.tlpPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.6888F));
            this.tlpPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPic.Size = new System.Drawing.Size(180, 198);
            this.tlpPic.TabIndex = 952;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(660, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 94);
            this.label3.TabIndex = 225;
            this.label3.Text = "كلمة المرور";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserPassword.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtUserPassword.ForeColor = System.Drawing.Color.Black;
            this.txtUserPassword.Location = new System.Drawing.Point(505, 138);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.ReadOnly = true;
            this.txtUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserPassword.Size = new System.Drawing.Size(147, 34);
            this.txtUserPassword.TabIndex = 226;
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(384, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 94);
            this.label2.TabIndex = 223;
            this.label2.Text = "الوظيفة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserJob
            // 
            this.txtUserJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserJob.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserJob.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtUserJob.ForeColor = System.Drawing.Color.Black;
            this.txtUserJob.Location = new System.Drawing.Point(229, 30);
            this.txtUserJob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserJob.Name = "txtUserJob";
            this.txtUserJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserJob.Size = new System.Drawing.Size(147, 34);
            this.txtUserJob.TabIndex = 224;
            this.txtUserJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpBtns
            // 
            this.tlpBtns.ColumnCount = 4;
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpBtns.Controls.Add(this.picUpdate, 0, 1);
            this.tlpBtns.Controls.Add(this.picDelete, 0, 3);
            this.tlpBtns.Controls.Add(this.picRefresh, 2, 3);
            this.tlpBtns.Controls.Add(this.picAdd, 2, 1);
            this.tlpBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBtns.Location = new System.Drawing.Point(19, 18);
            this.tlpBtns.Margin = new System.Windows.Forms.Padding(2);
            this.tlpBtns.Name = "tlpBtns";
            this.tlpBtns.RowCount = 4;
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpBtns.Size = new System.Drawing.Size(184, 253);
            this.tlpBtns.TabIndex = 953;
            // 
            // BtnResetPass
            // 
            this.BtnResetPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.tableLayoutPanel2.SetColumnSpan(this.BtnResetPass, 2);
            this.BtnResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetPass.FlatAppearance.BorderSize = 2;
            this.BtnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetPass.ForeColor = System.Drawing.Color.Black;
            this.BtnResetPass.Image = ((System.Drawing.Image)(resources.GetObject("BtnResetPass.Image")));
            this.BtnResetPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnResetPass.Location = new System.Drawing.Point(325, 134);
            this.BtnResetPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnResetPass.Name = "BtnResetPass";
            this.BtnResetPass.Size = new System.Drawing.Size(155, 41);
            this.BtnResetPass.TabIndex = 228;
            this.BtnResetPass.Text = "ضبط كلمة المرور";
            this.BtnResetPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.BtnResetPass, "ضبط كلمة المرور الى: 0000");
            this.BtnResetPass.UseVisualStyleBackColor = false;
            this.BtnResetPass.Click += new System.EventHandler(this.BtnResetPass_Click);
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnLoadPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPic.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnLoadPic.ForeColor = System.Drawing.Color.Black;
            this.btnLoadPic.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPic.Image")));
            this.btnLoadPic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPic.Location = new System.Drawing.Point(4, 4);
            this.btnLoadPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(172, 41);
            this.btnLoadPic.TabIndex = 954;
            this.btnLoadPic.Text = "تحميل الصورة";
            this.btnLoadPic.UseVisualStyleBackColor = false;
            this.btnLoadPic.Click += new System.EventHandler(this.btnLoadPic_Click);
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUser.Location = new System.Drawing.Point(4, 53);
            this.picUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(172, 142);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 953;
            this.picUser.TabStop = false;
            this.picUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picUser_MouseUp);
            // 
            // picUpdate
            // 
            this.picUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUpdate.Image = global::EmployeeManagement.Properties.Resources.document;
            this.picUpdate.Location = new System.Drawing.Point(4, 71);
            this.picUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(69, 81);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 797;
            this.picUpdate.TabStop = false;
            this.toolTip1.SetToolTip(this.picUpdate, "تعديل");
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDelete.Image = global::EmployeeManagement.Properties.Resources.document__2_;
            this.picDelete.Location = new System.Drawing.Point(4, 170);
            this.picDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(69, 80);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 799;
            this.picDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.picDelete, "حذف");
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRefresh.Image = global::EmployeeManagement.Properties.Resources.document__3_;
            this.picRefresh.Location = new System.Drawing.Point(93, 170);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(69, 80);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 798;
            this.picRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.picRefresh, "تحديث");
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAdd.Image = global::EmployeeManagement.Properties.Resources.document__1_;
            this.picAdd.Location = new System.Drawing.Point(93, 71);
            this.picAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(69, 81);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 800;
            this.picAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.picAdd, "اضافة");
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 687);
            this.Controls.Add(this.tlpContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1031, 708);
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المستخدمين";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tlpPermissions.ResumeLayout(false);
            this.tlpPermissions.PerformLayout();
            this.grpUserInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpPic.ResumeLayout(false);
            this.tlpBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.PictureBox picDelete;
        internal System.Windows.Forms.PictureBox picUpdate;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem cmsDeletePicture;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpBtns;
        internal System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn column5;
        private System.Windows.Forms.TableLayoutPanel tlpPermissions;
        internal System.Windows.Forms.CheckBox chkAdmin;
        internal System.Windows.Forms.CheckBox chkInsert;
        internal System.Windows.Forms.CheckBox chkSettings;
        internal System.Windows.Forms.CheckBox chkUpdate;
        internal System.Windows.Forms.CheckBox chkUsers;
        internal System.Windows.Forms.CheckBox chkPrint;
        internal System.Windows.Forms.PictureBox picRefresh;
        internal System.Windows.Forms.PictureBox picAdd;
        internal System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpPic;
        internal System.Windows.Forms.Button btnLoadPic;
        internal System.Windows.Forms.PictureBox picUser;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtUserPassword;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtUserJob;
        internal System.Windows.Forms.Button BtnResetPass;
    }
}