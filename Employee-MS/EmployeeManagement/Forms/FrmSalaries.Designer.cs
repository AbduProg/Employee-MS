namespace EmployeeManagement.Forms
{
    partial class FrmSalaries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSalarie = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degrees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DegreesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfEntitlement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfAmendment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissivenessOfTheExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionToAttend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpYearOfEntitlement = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpYearOfAmendment = new System.Windows.Forms.DateTimePicker();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBonusvalue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDegreesValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDegrees = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.dtpPermissivenessOfTheExchange = new System.Windows.Forms.DateTimePicker();
            this.dtpPermissionToAttend = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.picDegree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarie)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1223, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 680;
            this.label2.Text = "الموظف";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvSalarie
            // 
            this.dgvSalarie.AllowDrop = true;
            this.dgvSalarie.AllowUserToAddRows = false;
            this.dgvSalarie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalarie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvSalarie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalarie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalarie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.N,
            this.EmployeeName,
            this.Degrees,
            this.Bonus,
            this.From,
            this.To,
            this.Saturday,
            this.Sunday,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.UserName,
            this.DegreesId,
            this.YearOfEntitlement,
            this.YearOfAmendment,
            this.PermissivenessOfTheExchange,
            this.PermissionToAttend});
            this.dgvSalarie.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalarie.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalarie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSalarie.EnableHeadersVisualStyles = false;
            this.dgvSalarie.GridColor = System.Drawing.Color.Gray;
            this.dgvSalarie.Location = new System.Drawing.Point(5, 475);
            this.dgvSalarie.MultiSelect = false;
            this.dgvSalarie.Name = "dgvSalarie";
            this.dgvSalarie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalarie.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSalarie.RowHeadersVisible = false;
            this.dgvSalarie.RowHeadersWidth = 102;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvSalarie.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSalarie.RowTemplate.Height = 25;
            this.dgvSalarie.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalarie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalarie.Size = new System.Drawing.Size(1317, 302);
            this.dgvSalarie.TabIndex = 679;
            this.dgvSalarie.Click += new System.EventHandler(this.dgvBanks_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // N
            // 
            this.N.DataPropertyName = "N";
            this.N.FillWeight = 142.132F;
            this.N.HeaderText = "ت";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.FillWeight = 96.75908F;
            this.EmployeeName.HeaderText = "الموظف";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Degrees
            // 
            this.Degrees.DataPropertyName = "Degrees";
            this.Degrees.FillWeight = 96.75908F;
            this.Degrees.HeaderText = "الدرجة";
            this.Degrees.MinimumWidth = 6;
            this.Degrees.Name = "Degrees";
            // 
            // Bonus
            // 
            this.Bonus.DataPropertyName = "Bonus";
            this.Bonus.FillWeight = 96.75908F;
            this.Bonus.HeaderText = "العلاوة";
            this.Bonus.MinimumWidth = 6;
            this.Bonus.Name = "Bonus";
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.FillWeight = 96.75908F;
            this.From.HeaderText = "من";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.FillWeight = 96.75908F;
            this.To.HeaderText = "الى";
            this.To.Name = "To";
            // 
            // Saturday
            // 
            this.Saturday.DataPropertyName = "Saturday";
            this.Saturday.FillWeight = 96.75908F;
            this.Saturday.HeaderText = "السبت";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sunday
            // 
            this.Sunday.DataPropertyName = "Sunday";
            this.Sunday.FillWeight = 96.75908F;
            this.Sunday.HeaderText = "الأحد";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.FillWeight = 96.75908F;
            this.Monday.HeaderText = "الإثنين";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Tuesday
            // 
            this.Tuesday.DataPropertyName = "Tuesday";
            this.Tuesday.FillWeight = 96.75908F;
            this.Tuesday.HeaderText = "الثلاثاء";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Wednesday
            // 
            this.Wednesday.DataPropertyName = "Wednesday";
            this.Wednesday.FillWeight = 96.75908F;
            this.Wednesday.HeaderText = "الأربعاء";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Thursday
            // 
            this.Thursday.DataPropertyName = "Thursday";
            this.Thursday.FillWeight = 96.75908F;
            this.Thursday.HeaderText = "الخميس";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Friday
            // 
            this.Friday.DataPropertyName = "Friday";
            this.Friday.FillWeight = 96.75908F;
            this.Friday.HeaderText = "الجمعة";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 96.75908F;
            this.UserName.HeaderText = "المستخدم";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // DegreesId
            // 
            this.DegreesId.DataPropertyName = "DegreesId";
            this.DegreesId.HeaderText = "Column1";
            this.DegreesId.MinimumWidth = 6;
            this.DegreesId.Name = "DegreesId";
            this.DegreesId.Visible = false;
            // 
            // YearOfEntitlement
            // 
            this.YearOfEntitlement.DataPropertyName = "YearOfEntitlement";
            this.YearOfEntitlement.HeaderText = "سنة الاستحقاق";
            this.YearOfEntitlement.Name = "YearOfEntitlement";
            this.YearOfEntitlement.Visible = false;
            // 
            // YearOfAmendment
            // 
            this.YearOfAmendment.DataPropertyName = "YearOfAmendment";
            this.YearOfAmendment.HeaderText = "سنة التعديل";
            this.YearOfAmendment.Name = "YearOfAmendment";
            this.YearOfAmendment.Visible = false;
            // 
            // PermissivenessOfTheExchange
            // 
            this.PermissivenessOfTheExchange.DataPropertyName = "PermissivenessOfTheExchange";
            this.PermissivenessOfTheExchange.HeaderText = "Column1";
            this.PermissivenessOfTheExchange.Name = "PermissivenessOfTheExchange";
            this.PermissivenessOfTheExchange.Visible = false;
            // 
            // PermissionToAttend
            // 
            this.PermissionToAttend.DataPropertyName = "PermissionToAttend";
            this.PermissionToAttend.HeaderText = "Column1";
            this.PermissionToAttend.Name = "PermissionToAttend";
            this.PermissionToAttend.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "0";
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
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1276, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 44);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlInfo.Controls.Add(this.btnExit);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1329, 44);
            this.pnlInfo.TabIndex = 685;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(620, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "المرتبات والدوام";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPaymentMethod);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBank);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbEmployeeName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 70);
            this.panel1.TabIndex = 686;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.BackColor = System.Drawing.Color.LightGray;
            this.txtPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentMethod.Location = new System.Drawing.Point(3, 21);
            this.txtPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(212, 32);
            this.txtPaymentMethod.TabIndex = 773;
            this.txtPaymentMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(218, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 772;
            this.label6.Text = "طريقة الدفع";
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.LightGray;
            this.txtBank.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(323, 21);
            this.txtBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBank.Name = "txtBank";
            this.txtBank.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(298, 32);
            this.txtBank.TabIndex = 773;
            this.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(624, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 772;
            this.label5.Text = "المصرف";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtAccountNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(700, 18);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.ReadOnly = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(189, 32);
            this.txtAccountNumber.TabIndex = 773;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(892, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 772;
            this.label10.Text = "رقم الحساب";
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployeeName.BackColor = System.Drawing.Color.White;
            this.cmbEmployeeName.DisplayMember = "Id";
            this.cmbEmployeeName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.IntegralHeight = false;
            this.cmbEmployeeName.Location = new System.Drawing.Point(997, 21);
            this.cmbEmployeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmployeeName.Size = new System.Drawing.Size(222, 31);
            this.cmbEmployeeName.TabIndex = 771;
            this.cmbEmployeeName.TabStop = false;
            this.cmbEmployeeName.ValueMember = "Id";
            this.cmbEmployeeName.SelectionChangeCommitted += new System.EventHandler(this.cmbEmployeeName_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1113, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 680;
            this.label3.Text = "البيانات الرئيسية";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpYearOfEntitlement
            // 
            this.dtpYearOfEntitlement.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearOfEntitlement.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpYearOfEntitlement.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpYearOfEntitlement.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpYearOfEntitlement.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpYearOfEntitlement.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearOfEntitlement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearOfEntitlement.Location = new System.Drawing.Point(98, 67);
            this.dtpYearOfEntitlement.Margin = new System.Windows.Forms.Padding(2);
            this.dtpYearOfEntitlement.Name = "dtpYearOfEntitlement";
            this.dtpYearOfEntitlement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpYearOfEntitlement.RightToLeftLayout = true;
            this.dtpYearOfEntitlement.Size = new System.Drawing.Size(210, 29);
            this.dtpYearOfEntitlement.TabIndex = 772;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(330, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 680;
            this.label4.Text = "سنة الاستحقاق";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picDegree);
            this.panel2.Controls.Add(this.dtpYearOfAmendment);
            this.panel2.Controls.Add(this.dtpYearOfEntitlement);
            this.panel2.Controls.Add(this.txtBonus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtBonusvalue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDegreesValue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbDegrees);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 116);
            this.panel2.TabIndex = 686;
            // 
            // dtpYearOfAmendment
            // 
            this.dtpYearOfAmendment.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearOfAmendment.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpYearOfAmendment.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpYearOfAmendment.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpYearOfAmendment.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpYearOfAmendment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearOfAmendment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearOfAmendment.Location = new System.Drawing.Point(483, 67);
            this.dtpYearOfAmendment.Margin = new System.Windows.Forms.Padding(2);
            this.dtpYearOfAmendment.Name = "dtpYearOfAmendment";
            this.dtpYearOfAmendment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpYearOfAmendment.RightToLeftLayout = true;
            this.dtpYearOfAmendment.Size = new System.Drawing.Size(208, 29);
            this.dtpYearOfAmendment.TabIndex = 772;
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.Color.White;
            this.txtBonus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(846, 65);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(373, 32);
            this.txtBonus.TabIndex = 773;
            this.txtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonus_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1223, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 772;
            this.label7.Text = "العلاوات";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(734, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 680;
            this.label13.Text = "سنة التعديل";
            this.label13.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBonusvalue
            // 
            this.txtBonusvalue.BackColor = System.Drawing.Color.LightGray;
            this.txtBonusvalue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonusvalue.Location = new System.Drawing.Point(483, 19);
            this.txtBonusvalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBonusvalue.Name = "txtBonusvalue";
            this.txtBonusvalue.ReadOnly = true;
            this.txtBonusvalue.Size = new System.Drawing.Size(332, 32);
            this.txtBonusvalue.TabIndex = 773;
            this.txtBonusvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(818, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 772;
            this.label8.Text = "قيمة العلاوة";
            // 
            // txtDegreesValue
            // 
            this.txtDegreesValue.BackColor = System.Drawing.Color.LightGray;
            this.txtDegreesValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreesValue.Location = new System.Drawing.Point(22, 19);
            this.txtDegreesValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDegreesValue.Name = "txtDegreesValue";
            this.txtDegreesValue.ReadOnly = true;
            this.txtDegreesValue.Size = new System.Drawing.Size(343, 32);
            this.txtDegreesValue.TabIndex = 773;
            this.txtDegreesValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(368, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 772;
            this.label9.Text = "قيمة الدرجة";
            // 
            // cmbDegrees
            // 
            this.cmbDegrees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDegrees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDegrees.BackColor = System.Drawing.Color.White;
            this.cmbDegrees.DisplayMember = "Id";
            this.cmbDegrees.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDegrees.FormattingEnabled = true;
            this.cmbDegrees.IntegralHeight = false;
            this.cmbDegrees.Location = new System.Drawing.Point(985, 19);
            this.cmbDegrees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDegrees.Name = "cmbDegrees";
            this.cmbDegrees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDegrees.Size = new System.Drawing.Size(249, 31);
            this.cmbDegrees.TabIndex = 771;
            this.cmbDegrees.TabStop = false;
            this.cmbDegrees.ValueMember = "Id";
            this.cmbDegrees.SelectionChangeCommitted += new System.EventHandler(this.cmbDegrees_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1238, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 25);
            this.label11.TabIndex = 680;
            this.label11.Text = "الدرجة";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1134, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 680;
            this.label12.Text = "بيانات المرتب";
            this.label12.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel3.Location = new System.Drawing.Point(20, 414);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 2);
            this.panel3.TabIndex = 786;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chkFriday);
            this.panel4.Controls.Add(this.chkThursday);
            this.panel4.Controls.Add(this.chkWednesday);
            this.panel4.Controls.Add(this.chkTuesday);
            this.panel4.Controls.Add(this.chkMonday);
            this.panel4.Controls.Add(this.chkSunday);
            this.panel4.Controls.Add(this.chkSaturday);
            this.panel4.Controls.Add(this.dtpPermissivenessOfTheExchange);
            this.panel4.Controls.Add(this.dtpPermissionToAttend);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.dtpTo);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.dtpFrom);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(12, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1305, 116);
            this.panel4.TabIndex = 686;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriday.Location = new System.Drawing.Point(87, 74);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFriday.Size = new System.Drawing.Size(82, 29);
            this.chkFriday.TabIndex = 773;
            this.chkFriday.Text = "الجمعة";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThursday.Location = new System.Drawing.Point(269, 74);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkThursday.Size = new System.Drawing.Size(89, 29);
            this.chkThursday.TabIndex = 773;
            this.chkThursday.Text = "الخميس";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWednesday.Location = new System.Drawing.Point(456, 74);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkWednesday.Size = new System.Drawing.Size(79, 29);
            this.chkWednesday.TabIndex = 773;
            this.chkWednesday.Text = "الاربعاء";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuesday.Location = new System.Drawing.Point(627, 74);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTuesday.Size = new System.Drawing.Size(75, 29);
            this.chkTuesday.TabIndex = 773;
            this.chkTuesday.Text = "الثلاثاء";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonday.Location = new System.Drawing.Point(792, 74);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMonday.Size = new System.Drawing.Size(73, 29);
            this.chkMonday.TabIndex = 773;
            this.chkMonday.Text = "الاثنين";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunday.Location = new System.Drawing.Point(985, 74);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSunday.Size = new System.Drawing.Size(64, 29);
            this.chkSunday.TabIndex = 773;
            this.chkSunday.Text = "الاحد";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaturday.Location = new System.Drawing.Point(1161, 74);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSaturday.Size = new System.Drawing.Size(75, 29);
            this.chkSaturday.TabIndex = 773;
            this.chkSaturday.Text = "السبت";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // dtpPermissivenessOfTheExchange
            // 
            this.dtpPermissivenessOfTheExchange.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPermissivenessOfTheExchange.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpPermissivenessOfTheExchange.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpPermissivenessOfTheExchange.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpPermissivenessOfTheExchange.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpPermissivenessOfTheExchange.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPermissivenessOfTheExchange.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPermissivenessOfTheExchange.Location = new System.Drawing.Point(32, 21);
            this.dtpPermissivenessOfTheExchange.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPermissivenessOfTheExchange.Name = "dtpPermissivenessOfTheExchange";
            this.dtpPermissivenessOfTheExchange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpPermissivenessOfTheExchange.RightToLeftLayout = true;
            this.dtpPermissivenessOfTheExchange.ShowUpDown = true;
            this.dtpPermissivenessOfTheExchange.Size = new System.Drawing.Size(208, 29);
            this.dtpPermissivenessOfTheExchange.TabIndex = 772;
            // 
            // dtpPermissionToAttend
            // 
            this.dtpPermissionToAttend.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPermissionToAttend.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpPermissionToAttend.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpPermissionToAttend.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpPermissionToAttend.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpPermissionToAttend.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPermissionToAttend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPermissionToAttend.Location = new System.Drawing.Point(373, 21);
            this.dtpPermissionToAttend.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPermissionToAttend.Name = "dtpPermissionToAttend";
            this.dtpPermissionToAttend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpPermissionToAttend.RightToLeftLayout = true;
            this.dtpPermissionToAttend.ShowUpDown = true;
            this.dtpPermissionToAttend.Size = new System.Drawing.Size(208, 29);
            this.dtpPermissionToAttend.TabIndex = 772;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(242, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 25);
            this.label17.TabIndex = 680;
            this.label17.Text = "سماحية الانصراف";
            this.label17.Click += new System.EventHandler(this.label2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(593, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 25);
            this.label16.TabIndex = 680;
            this.label16.Text = "سماحية الحضور";
            this.label16.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpTo.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpTo.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpTo.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpTo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTo.Location = new System.Drawing.Point(729, 21);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTo.RightToLeftLayout = true;
            this.dtpTo.ShowUpDown = true;
            this.dtpTo.Size = new System.Drawing.Size(222, 29);
            this.dtpTo.TabIndex = 772;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(953, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 25);
            this.label15.TabIndex = 680;
            this.label15.Text = "الى";
            this.label15.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpFrom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFrom.Location = new System.Drawing.Point(1010, 21);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.ShowUpDown = true;
            this.dtpFrom.Size = new System.Drawing.Size(224, 29);
            this.dtpFrom.TabIndex = 772;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1236, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 25);
            this.label14.TabIndex = 680;
            this.label14.Text = "من";
            this.label14.Click += new System.EventHandler(this.label2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(1140, 278);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 25);
            this.label20.TabIndex = 680;
            this.label20.Text = "بيانات الدوام";
            this.label20.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDelete.FlatAppearance.BorderSize = 4;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::EmployeeManagement.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(536, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(257, 52);
            this.btnDelete.TabIndex = 683;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnRefresh.FlatAppearance.BorderSize = 4;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::EmployeeManagement.Properties.Resources.RefRech;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(12, 421);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(257, 52);
            this.btnRefresh.TabIndex = 682;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSave.FlatAppearance.BorderSize = 4;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::EmployeeManagement.Properties.Resources.Update;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(798, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(257, 52);
            this.btnSave.TabIndex = 681;
            this.btnSave.Text = "تعديل";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAdd.FlatAppearance.BorderSize = 4;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::EmployeeManagement.Properties.Resources.insert;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(1060, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(257, 52);
            this.btnAdd.TabIndex = 684;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnExport.FlatAppearance.BorderSize = 3;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(274, 421);
            this.btnExport.Name = "btnExport";
            this.btnExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExport.Size = new System.Drawing.Size(257, 52);
            this.btnExport.TabIndex = 797;
            this.btnExport.Text = "تصدير الى اكسل";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // picDegree
            // 
            this.picDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDegree.Image = global::EmployeeManagement.Properties.Resources.add;
            this.picDegree.Location = new System.Drawing.Point(940, 20);
            this.picDegree.Name = "picDegree";
            this.picDegree.Size = new System.Drawing.Size(38, 30);
            this.picDegree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDegree.TabIndex = 793;
            this.picDegree.TabStop = false;
            this.picDegree.Tag = "1";
            this.picDegree.Click += new System.EventHandler(this.picDegree_Click);
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 780);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSalarie);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmSalaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarie)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvSalarie;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Panel pnlInfo;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpYearOfEntitlement;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNumber;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBank;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBonus;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBonusvalue;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDegreesValue;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cmbDegrees;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpYearOfAmendment;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpPermissionToAttend;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpPermissivenessOfTheExchange;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degrees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sunday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Monday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DegreesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfEntitlement;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfAmendment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissivenessOfTheExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionToAttend;
        internal System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox picDegree;
    }
}