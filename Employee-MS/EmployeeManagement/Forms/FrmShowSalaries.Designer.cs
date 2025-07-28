namespace EmployeeManagement.Forms
{
    partial class FrmShowSalaries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNamesOfEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountEmployee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalaryValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRewardeValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNetValue = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.AllowUserToAddRows = false;
            this.dgvSalaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvSalaries.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSalaries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.N,
            this.NameOfEmployee,
            this.EmployeeName,
            this.NationalNumber,
            this.PhoneNumber,
            this.Period,
            this.SalaryValue,
            this.DiscountsValue,
            this.RewardsValue,
            this.NetSalary,
            this.IdEmployees,
            this.FullNameBank});
            this.dgvSalaries.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSalaries.EnableHeadersVisualStyles = false;
            this.dgvSalaries.GridColor = System.Drawing.Color.Gray;
            this.dgvSalaries.Location = new System.Drawing.Point(6, 290);
            this.dgvSalaries.MultiSelect = false;
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaries.RowHeadersVisible = false;
            this.dgvSalaries.RowHeadersWidth = 102;
            this.dgvSalaries.RowTemplate.DividerHeight = 3;
            this.dgvSalaries.RowTemplate.Height = 33;
            this.dgvSalaries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaries.Size = new System.Drawing.Size(1441, 302);
            this.dgvSalaries.TabIndex = 797;
            this.dgvSalaries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaries_CellContentClick);
            this.dgvSalaries.Click += new System.EventHandler(this.dgvSalaries_Click);
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
            this.N.FillWeight = 53.67919F;
            this.N.HeaderText = "ت";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            this.N.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NameOfEmployee
            // 
            this.NameOfEmployee.DataPropertyName = "EmployeeName";
            this.NameOfEmployee.FillWeight = 134.2603F;
            this.NameOfEmployee.HeaderText = "أسم الموظف";
            this.NameOfEmployee.MinimumWidth = 6;
            this.NameOfEmployee.Name = "NameOfEmployee";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "AccountNumber";
            this.EmployeeName.FillWeight = 150.8674F;
            this.EmployeeName.HeaderText = "رقم الحساب";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // NationalNumber
            // 
            this.NationalNumber.DataPropertyName = "BankName";
            this.NationalNumber.FillWeight = 112.3918F;
            this.NationalNumber.HeaderText = "المصرف";
            this.NationalNumber.MinimumWidth = 6;
            this.NationalNumber.Name = "NationalNumber";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "BranchesName";
            this.PhoneNumber.FillWeight = 88.69229F;
            this.PhoneNumber.HeaderText = "الفرع";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Period
            // 
            this.Period.DataPropertyName = "Period";
            this.Period.FillWeight = 88.94425F;
            this.Period.HeaderText = "مرتب شهر";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            // 
            // SalaryValue
            // 
            this.SalaryValue.DataPropertyName = "SalaryValue";
            this.SalaryValue.FillWeight = 101.5101F;
            this.SalaryValue.HeaderText = "قيمة المرتب";
            this.SalaryValue.MinimumWidth = 6;
            this.SalaryValue.Name = "SalaryValue";
            // 
            // DiscountsValue
            // 
            this.DiscountsValue.DataPropertyName = "DiscountsValue";
            this.DiscountsValue.FillWeight = 103.2582F;
            this.DiscountsValue.HeaderText = "قيمة الخصومات";
            this.DiscountsValue.MinimumWidth = 6;
            this.DiscountsValue.Name = "DiscountsValue";
            this.DiscountsValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RewardsValue
            // 
            this.RewardsValue.DataPropertyName = "RewardsValue";
            this.RewardsValue.FillWeight = 107.3849F;
            this.RewardsValue.HeaderText = "قيمة المكافئات";
            this.RewardsValue.MinimumWidth = 6;
            this.RewardsValue.Name = "RewardsValue";
            // 
            // NetSalary
            // 
            this.NetSalary.DataPropertyName = "NetSalary";
            this.NetSalary.FillWeight = 105.123F;
            this.NetSalary.HeaderText = "صافي المرتب";
            this.NetSalary.MinimumWidth = 6;
            this.NetSalary.Name = "NetSalary";
            // 
            // IdEmployees
            // 
            this.IdEmployees.DataPropertyName = "IdEmployees";
            this.IdEmployees.HeaderText = "IdEmployees";
            this.IdEmployees.MinimumWidth = 6;
            this.IdEmployees.Name = "IdEmployees";
            this.IdEmployees.Visible = false;
            // 
            // FullNameBank
            // 
            this.FullNameBank.DataPropertyName = "FullNameBank";
            this.FullNameBank.HeaderText = "FullNameBank";
            this.FullNameBank.Name = "FullNameBank";
            this.FullNameBank.Visible = false;
            // 
            // cmbNamesOfEmployee
            // 
            this.cmbNamesOfEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNamesOfEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNamesOfEmployee.BackColor = System.Drawing.Color.White;
            this.cmbNamesOfEmployee.DisplayMember = "Id";
            this.cmbNamesOfEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamesOfEmployee.FormattingEnabled = true;
            this.cmbNamesOfEmployee.IntegralHeight = false;
            this.cmbNamesOfEmployee.Location = new System.Drawing.Point(27, 37);
            this.cmbNamesOfEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNamesOfEmployee.Name = "cmbNamesOfEmployee";
            this.cmbNamesOfEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbNamesOfEmployee.Size = new System.Drawing.Size(416, 31);
            this.cmbNamesOfEmployee.TabIndex = 799;
            this.cmbNamesOfEmployee.TabStop = false;
            this.cmbNamesOfEmployee.ValueMember = "Id";
            this.cmbNamesOfEmployee.SelectionChangeCommitted += new System.EventHandler(this.cmbNamesOfEmployee_SelectionChangeCommitted);
            this.cmbNamesOfEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNamesOfEmployee_KeyDown);
            this.cmbNamesOfEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNamesOfEmployee_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(447, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 798;
            this.label7.Text = " الموظف";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlInfo.Controls.Add(this.btnExit);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1452, 45);
            this.pnlInfo.TabIndex = 801;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1399, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 45);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(614, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "شاشة عرض المرتبات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnClose.FlatAppearance.BorderSize = 3;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(6, 244);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClose.Size = new System.Drawing.Size(251, 40);
            this.BtnClose.TabIndex = 802;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.White;
            this.btnSerch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSerch.FlatAppearance.BorderSize = 3;
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerch.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerch.ForeColor = System.Drawing.Color.Black;
            this.btnSerch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerch.Location = new System.Drawing.Point(27, 130);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSerch.Size = new System.Drawing.Size(158, 40);
            this.btnSerch.TabIndex = 800;
            this.btnSerch.Text = "إبحث";
            this.btnSerch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnRefresh_Clic);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpFrom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(211, 106);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.Size = new System.Drawing.Size(233, 29);
            this.dtpFrom.TabIndex = 803;
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpTo.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpTo.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpTo.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpTo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(211, 165);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTo.RightToLeftLayout = true;
            this.dtpTo.Size = new System.Drawing.Size(233, 29);
            this.dtpTo.TabIndex = 803;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(465, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(467, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "الى";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCountEmployee
            // 
            this.txtCountEmployee.BackColor = System.Drawing.Color.LightGray;
            this.txtCountEmployee.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountEmployee.Location = new System.Drawing.Point(457, 76);
            this.txtCountEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountEmployee.Name = "txtCountEmployee";
            this.txtCountEmployee.ReadOnly = true;
            this.txtCountEmployee.Size = new System.Drawing.Size(202, 36);
            this.txtCountEmployee.TabIndex = 805;
            this.txtCountEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(736, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 804;
            this.label10.Text = "عدد الموظفين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(261, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 804;
            this.label4.Text = "إجمالي قيمة المرتبات";
            // 
            // txtSalaryValue
            // 
            this.txtSalaryValue.BackColor = System.Drawing.Color.LightGray;
            this.txtSalaryValue.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryValue.Location = new System.Drawing.Point(6, 102);
            this.txtSalaryValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalaryValue.Name = "txtSalaryValue";
            this.txtSalaryValue.ReadOnly = true;
            this.txtSalaryValue.Size = new System.Drawing.Size(241, 36);
            this.txtSalaryValue.TabIndex = 805;
            this.txtSalaryValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(670, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 804;
            this.label5.Text = "إجمالي قيمة المكافئات";
            // 
            // txtRewardeValue
            // 
            this.txtRewardeValue.BackColor = System.Drawing.Color.LightGray;
            this.txtRewardeValue.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRewardeValue.Location = new System.Drawing.Point(457, 189);
            this.txtRewardeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRewardeValue.Name = "txtRewardeValue";
            this.txtRewardeValue.ReadOnly = true;
            this.txtRewardeValue.Size = new System.Drawing.Size(202, 36);
            this.txtRewardeValue.TabIndex = 805;
            this.txtRewardeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(669, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 804;
            this.label6.Text = "إجمالي قيمة الخصومات";
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.BackColor = System.Drawing.Color.LightGray;
            this.txtDiscountValue.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.Location = new System.Drawing.Point(457, 129);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.ReadOnly = true;
            this.txtDiscountValue.Size = new System.Drawing.Size(202, 36);
            this.txtDiscountValue.TabIndex = 805;
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(268, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 804;
            this.label8.Text = "صافي قيمة المرتبات";
            // 
            // txtNetValue
            // 
            this.txtNetValue.BackColor = System.Drawing.Color.LightGray;
            this.txtNetValue.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetValue.Location = new System.Drawing.Point(6, 162);
            this.txtNetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNetValue.Name = "txtNetValue";
            this.txtNetValue.ReadOnly = true;
            this.txtNetValue.Size = new System.Drawing.Size(241, 36);
            this.txtNetValue.TabIndex = 805;
            this.txtNetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnExcel.FlatAppearance.BorderSize = 3;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(674, 244);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExcel.Size = new System.Drawing.Size(195, 40);
            this.btnExcel.TabIndex = 800;
            this.btnExcel.Text = "تصدير ";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbNamesOfEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(892, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(555, 226);
            this.groupBox1.TabIndex = 806;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::EmployeeManagement.Properties.Resources.RefRech;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(471, 244);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(194, 40);
            this.btnRefresh.TabIndex = 800;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatAppearance.BorderSize = 3;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(266, 244);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(194, 40);
            this.btnPrint.TabIndex = 800;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmShowSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNetValue);
            this.Controls.Add(this.txtDiscountValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRewardeValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalaryValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountEmployee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvSalaries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmShowSalaries";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowSalaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        internal System.Windows.Forms.ComboBox cmbNamesOfEmployee;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Panel pnlInfo;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountEmployee;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalaryValue;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRewardeValue;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscountValue;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNetValue;
        internal System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameBank;
        internal System.Windows.Forms.Button btnPrint;
    }
}