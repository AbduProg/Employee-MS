namespace EmployeeManagement.Forms
{
    partial class FrmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbNamesOfEmployee = new System.Windows.Forms.ComboBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.gropbox = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gropbox1 = new System.Windows.Forms.GroupBox();
            this.picAddJop = new System.Windows.Forms.PictureBox();
            this.picAddSection = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbJopName = new System.Windows.Forms.ComboBox();
            this.cmbSectionName = new System.Windows.Forms.ComboBox();
            this.gropbox2 = new System.Windows.Forms.GroupBox();
            this.picAddBranch = new System.Windows.Forms.PictureBox();
            this.picAddBank = new System.Windows.Forms.PictureBox();
            this.picAddPaymentMethod = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBranchesName = new System.Windows.Forms.ComboBox();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankBranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.gropbox.SuspendLayout();
            this.gropbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddJop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddSection)).BeginInit();
            this.gropbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPaymentMethod)).BeginInit();
            this.SuspendLayout();
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
            this.cmbNamesOfEmployee.Location = new System.Drawing.Point(23, 39);
            this.cmbNamesOfEmployee.Name = "cmbNamesOfEmployee";
            this.cmbNamesOfEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbNamesOfEmployee.Size = new System.Drawing.Size(273, 31);
            this.cmbNamesOfEmployee.TabIndex = 770;
            this.cmbNamesOfEmployee.TabStop = false;
            this.cmbNamesOfEmployee.ValueMember = "Id";
            this.cmbNamesOfEmployee.SelectionChangeCommitted += new System.EventHandler(this.cmbNamesOfEmployee_SelectionChangeCommitted);
            this.cmbNamesOfEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNamesOfEmployee_KeyDown);
            this.cmbNamesOfEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNamesOfEmployee_KeyPress);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvEmployees.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.N,
            this.EmployeeName,
            this.NationalNumber,
            this.PhoneNumber,
            this.ManagementName,
            this.SectionName,
            this.JobName,
            this.DateOfAppointment,
            this.UserName,
            this.PaymentMethodId,
            this.JobId,
            this.SectionId1,
            this.BankBranchId,
            this.BankId1,
            this.AccountNumber});
            this.dgvEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.Gray;
            this.dgvEmployees.Location = new System.Drawing.Point(9, 355);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 102;
            this.dgvEmployees.RowTemplate.DividerHeight = 3;
            this.dgvEmployees.RowTemplate.Height = 33;
            this.dgvEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1191, 293);
            this.dgvEmployees.TabIndex = 796;
            this.dgvEmployees.Click += new System.EventHandler(this.dgvEmployees_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel4.Location = new System.Drawing.Point(9, 285);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1191, 2);
            this.panel4.TabIndex = 794;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(309, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 766;
            this.label7.Text = "أسم الموظف";
            // 
            // dtpAdd
            // 
            this.dtpAdd.CalendarFont = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdd.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpAdd.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpAdd.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpAdd.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdd.Location = new System.Drawing.Point(9, 159);
            this.dtpAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAdd.RightToLeftLayout = true;
            this.dtpAdd.Size = new System.Drawing.Size(202, 29);
            this.dtpAdd.TabIndex = 763;
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
            this.btnExit.Location = new System.Drawing.Point(1149, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 50);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(543, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "شاشة الموظفين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlInfo.Controls.Add(this.btnExit);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1210, 50);
            this.pnlInfo.TabIndex = 793;
            // 
            // gropbox
            // 
            this.gropbox.Controls.Add(this.txtPhoneNumber);
            this.gropbox.Controls.Add(this.txtNationalNumber);
            this.gropbox.Controls.Add(this.label3);
            this.gropbox.Controls.Add(this.label2);
            this.gropbox.Controls.Add(this.label7);
            this.gropbox.Controls.Add(this.cmbNamesOfEmployee);
            this.gropbox.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropbox.Location = new System.Drawing.Point(783, 63);
            this.gropbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropbox.Name = "gropbox";
            this.gropbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gropbox.Size = new System.Drawing.Size(419, 208);
            this.gropbox.TabIndex = 797;
            this.gropbox.TabStop = false;
            this.gropbox.Text = "البيانات الشخصية";
            this.gropbox.Enter += new System.EventHandler(this.gropbox_Enter);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(23, 160);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(273, 32);
            this.txtPhoneNumber.TabIndex = 771;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtNationalNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNumber.Location = new System.Drawing.Point(23, 99);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(273, 32);
            this.txtNationalNumber.TabIndex = 771;
            this.txtNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(321, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 766;
            this.label3.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(309, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 766;
            this.label2.Text = "الرقم الوطني";
            // 
            // gropbox1
            // 
            this.gropbox1.Controls.Add(this.picAddJop);
            this.gropbox1.Controls.Add(this.picAddSection);
            this.gropbox1.Controls.Add(this.label4);
            this.gropbox1.Controls.Add(this.label5);
            this.gropbox1.Controls.Add(this.label6);
            this.gropbox1.Controls.Add(this.cmbJopName);
            this.gropbox1.Controls.Add(this.cmbSectionName);
            this.gropbox1.Controls.Add(this.dtpAdd);
            this.gropbox1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropbox1.Location = new System.Drawing.Point(453, 63);
            this.gropbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropbox1.Name = "gropbox1";
            this.gropbox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gropbox1.Size = new System.Drawing.Size(326, 208);
            this.gropbox1.TabIndex = 797;
            this.gropbox1.TabStop = false;
            this.gropbox1.Text = "البيانات الوظيفية";
            // 
            // picAddJop
            // 
            this.picAddJop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddJop.Image = global::EmployeeManagement.Properties.Resources.add;
            this.picAddJop.Location = new System.Drawing.Point(5, 93);
            this.picAddJop.Name = "picAddJop";
            this.picAddJop.Size = new System.Drawing.Size(39, 37);
            this.picAddJop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddJop.TabIndex = 798;
            this.picAddJop.TabStop = false;
            this.picAddJop.Tag = "1";
            this.picAddJop.Click += new System.EventHandler(this.picAddJop_Click);
            // 
            // picAddSection
            // 
            this.picAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddSection.Image = global::EmployeeManagement.Properties.Resources.add;
            this.picAddSection.Location = new System.Drawing.Point(5, 33);
            this.picAddSection.Name = "picAddSection";
            this.picAddSection.Size = new System.Drawing.Size(39, 37);
            this.picAddSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddSection.TabIndex = 798;
            this.picAddSection.TabStop = false;
            this.picAddSection.Tag = "1";
            this.picAddSection.Click += new System.EventHandler(this.picAddSection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(226, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 766;
            this.label4.Text = " تاريخ التعين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(248, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 766;
            this.label5.Text = "الوظيفة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(259, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 766;
            this.label6.Text = "القسم";
            // 
            // cmbJopName
            // 
            this.cmbJopName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJopName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJopName.BackColor = System.Drawing.Color.White;
            this.cmbJopName.DisplayMember = "Id";
            this.cmbJopName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJopName.FormattingEnabled = true;
            this.cmbJopName.IntegralHeight = false;
            this.cmbJopName.Location = new System.Drawing.Point(51, 98);
            this.cmbJopName.Name = "cmbJopName";
            this.cmbJopName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbJopName.Size = new System.Drawing.Size(182, 31);
            this.cmbJopName.TabIndex = 770;
            this.cmbJopName.TabStop = false;
            this.cmbJopName.ValueMember = "Id";
            this.cmbJopName.SelectionChangeCommitted += new System.EventHandler(this.cmbJopName_SelectionChangeCommitted);
            this.cmbJopName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbJopName_KeyDown);
            this.cmbJopName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbJopName_KeyPress);
            // 
            // cmbSectionName
            // 
            this.cmbSectionName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSectionName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSectionName.BackColor = System.Drawing.Color.White;
            this.cmbSectionName.DisplayMember = "Id";
            this.cmbSectionName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSectionName.FormattingEnabled = true;
            this.cmbSectionName.IntegralHeight = false;
            this.cmbSectionName.Location = new System.Drawing.Point(51, 36);
            this.cmbSectionName.Name = "cmbSectionName";
            this.cmbSectionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSectionName.Size = new System.Drawing.Size(182, 31);
            this.cmbSectionName.TabIndex = 770;
            this.cmbSectionName.TabStop = false;
            this.cmbSectionName.ValueMember = "Id";
            this.cmbSectionName.SelectionChangeCommitted += new System.EventHandler(this.cmbSectionName_SelectionChangeCommitted);
            this.cmbSectionName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSectionName_KeyDown);
            this.cmbSectionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSectionName_KeyPress);
            // 
            // gropbox2
            // 
            this.gropbox2.Controls.Add(this.picAddBranch);
            this.gropbox2.Controls.Add(this.picAddBank);
            this.gropbox2.Controls.Add(this.picAddPaymentMethod);
            this.gropbox2.Controls.Add(this.label12);
            this.gropbox2.Controls.Add(this.cmbPaymentMethod);
            this.gropbox2.Controls.Add(this.label11);
            this.gropbox2.Controls.Add(this.txtAccountNumber);
            this.gropbox2.Controls.Add(this.label8);
            this.gropbox2.Controls.Add(this.cmbBranchesName);
            this.gropbox2.Controls.Add(this.cmbBankName);
            this.gropbox2.Controls.Add(this.label10);
            this.gropbox2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropbox2.Location = new System.Drawing.Point(9, 63);
            this.gropbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropbox2.Name = "gropbox2";
            this.gropbox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gropbox2.Size = new System.Drawing.Size(436, 208);
            this.gropbox2.TabIndex = 797;
            this.gropbox2.TabStop = false;
            this.gropbox2.Text = "البيانات المالية";
            // 
            // picAddBranch
            // 
            this.picAddBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddBranch.Image = global::EmployeeManagement.Properties.Resources.add;
            this.picAddBranch.Location = new System.Drawing.Point(5, 156);
            this.picAddBranch.Name = "picAddBranch";
            this.picAddBranch.Size = new System.Drawing.Size(39, 37);
            this.picAddBranch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddBranch.TabIndex = 798;
            this.picAddBranch.TabStop = false;
            this.picAddBranch.Tag = "1";
            this.picAddBranch.Click += new System.EventHandler(this.picAddBranch_Click);
            // 
            // picAddBank
            // 
            this.picAddBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddBank.Image = global::EmployeeManagement.Properties.Resources.add;
            this.picAddBank.Location = new System.Drawing.Point(5, 115);
            this.picAddBank.Name = "picAddBank";
            this.picAddBank.Size = new System.Drawing.Size(39, 37);
            this.picAddBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddBank.TabIndex = 798;
            this.picAddBank.TabStop = false;
            this.picAddBank.Tag = "1";
            this.picAddBank.Click += new System.EventHandler(this.picAddBank_Click);
            // 
            // picAddPaymentMethod
            // 
            this.picAddPaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddPaymentMethod.Image = global::EmployeeManagement.Properties.Resources.add;
            this.picAddPaymentMethod.Location = new System.Drawing.Point(5, 36);
            this.picAddPaymentMethod.Name = "picAddPaymentMethod";
            this.picAddPaymentMethod.Size = new System.Drawing.Size(39, 37);
            this.picAddPaymentMethod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddPaymentMethod.TabIndex = 798;
            this.picAddPaymentMethod.TabStop = false;
            this.picAddPaymentMethod.Tag = "1";
            this.picAddPaymentMethod.Click += new System.EventHandler(this.picAddPaymentMethod_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(271, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 766;
            this.label12.Text = "طريقة إستلام المرتب";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaymentMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.White;
            this.cmbPaymentMethod.DisplayMember = "Id";
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.IntegralHeight = false;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(51, 39);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPaymentMethod.Size = new System.Drawing.Size(213, 31);
            this.cmbPaymentMethod.TabIndex = 770;
            this.cmbPaymentMethod.TabStop = false;
            this.cmbPaymentMethod.ValueMember = "Id";
            this.cmbPaymentMethod.SelectionChangeCommitted += new System.EventHandler(this.cmbPaymentMethod_SelectionChangeCommitted);
            this.cmbPaymentMethod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPaymentMethod_KeyDown);
            this.cmbPaymentMethod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPaymentMethod_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(375, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 25);
            this.label11.TabIndex = 766;
            this.label11.Text = "الفرع";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtAccountNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(5, 79);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(259, 32);
            this.txtAccountNumber.TabIndex = 771;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(357, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 766;
            this.label8.Text = "المصرف";
            // 
            // cmbBranchesName
            // 
            this.cmbBranchesName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBranchesName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBranchesName.BackColor = System.Drawing.Color.White;
            this.cmbBranchesName.DisplayMember = "Id";
            this.cmbBranchesName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranchesName.FormattingEnabled = true;
            this.cmbBranchesName.IntegralHeight = false;
            this.cmbBranchesName.Location = new System.Drawing.Point(51, 159);
            this.cmbBranchesName.Name = "cmbBranchesName";
            this.cmbBranchesName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBranchesName.Size = new System.Drawing.Size(213, 31);
            this.cmbBranchesName.TabIndex = 770;
            this.cmbBranchesName.TabStop = false;
            this.cmbBranchesName.ValueMember = "Id";
            this.cmbBranchesName.SelectionChangeCommitted += new System.EventHandler(this.cmbBranchesName_SelectionChangeCommitted);
            this.cmbBranchesName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBranchesName_KeyDown);
            this.cmbBranchesName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBranchesName_KeyPress);
            // 
            // cmbBankName
            // 
            this.cmbBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBankName.BackColor = System.Drawing.Color.White;
            this.cmbBankName.DisplayMember = "Id";
            this.cmbBankName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.IntegralHeight = false;
            this.cmbBankName.Location = new System.Drawing.Point(51, 119);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBankName.Size = new System.Drawing.Size(213, 31);
            this.cmbBankName.TabIndex = 770;
            this.cmbBankName.TabStop = false;
            this.cmbBankName.ValueMember = "Id";
            this.cmbBankName.SelectionChangeCommitted += new System.EventHandler(this.cmbBankName_SelectionChangeCommitted);
            this.cmbBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBankName_KeyDown);
            this.cmbBankName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBankName_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(332, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 766;
            this.label10.Text = "رقم الحساب";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::EmployeeManagement.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(489, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(235, 46);
            this.btnDelete.TabIndex = 790;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::EmployeeManagement.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(967, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(235, 46);
            this.btnAdd.TabIndex = 792;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(249, 303);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(235, 46);
            this.btnRefresh.TabIndex = 791;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::EmployeeManagement.Properties.Resources.Update;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(728, 303);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(235, 46);
            this.btnEdit.TabIndex = 789;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnExport.Location = new System.Drawing.Point(12, 303);
            this.btnExport.Name = "btnExport";
            this.btnExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExport.Size = new System.Drawing.Size(235, 46);
            this.btnExport.TabIndex = 798;
            this.btnExport.Text = "تصدير الى اكسل";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.N.FillWeight = 51.62192F;
            this.N.HeaderText = "ت";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            this.N.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.FillWeight = 145.0854F;
            this.EmployeeName.HeaderText = "أسم الموظف";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // NationalNumber
            // 
            this.NationalNumber.DataPropertyName = "NationalNumber";
            this.NationalNumber.FillWeight = 108.0844F;
            this.NationalNumber.HeaderText = "الرقم الوطني";
            this.NationalNumber.MinimumWidth = 6;
            this.NationalNumber.Name = "NationalNumber";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.FillWeight = 108.0844F;
            this.PhoneNumber.HeaderText = "رقم الهاتف";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // ManagementName
            // 
            this.ManagementName.DataPropertyName = "ManagementName";
            this.ManagementName.FillWeight = 115.0846F;
            this.ManagementName.HeaderText = "الإدارة";
            this.ManagementName.MinimumWidth = 6;
            this.ManagementName.Name = "ManagementName";
            // 
            // SectionName
            // 
            this.SectionName.DataPropertyName = "SectionName";
            this.SectionName.FillWeight = 117.9309F;
            this.SectionName.HeaderText = "القسم";
            this.SectionName.MinimumWidth = 6;
            this.SectionName.Name = "SectionName";
            this.SectionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // JobName
            // 
            this.JobName.DataPropertyName = "JobName";
            this.JobName.FillWeight = 103.2694F;
            this.JobName.HeaderText = "الوظيفة";
            this.JobName.MinimumWidth = 6;
            this.JobName.Name = "JobName";
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.DataPropertyName = "DateOfAppointment";
            this.DateOfAppointment.FillWeight = 96.95038F;
            this.DateOfAppointment.HeaderText = "تاريخ التعين";
            this.DateOfAppointment.MinimumWidth = 6;
            this.DateOfAppointment.Name = "DateOfAppointment";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 108.0844F;
            this.UserName.HeaderText = "المستخدم";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // PaymentMethodId
            // 
            this.PaymentMethodId.DataPropertyName = "PaymentMethodId";
            this.PaymentMethodId.HeaderText = "معرف طريقة الاستلام";
            this.PaymentMethodId.Name = "PaymentMethodId";
            this.PaymentMethodId.Visible = false;
            // 
            // JobId
            // 
            this.JobId.DataPropertyName = "JobId";
            this.JobId.HeaderText = "معرف الوظيفة";
            this.JobId.Name = "JobId";
            this.JobId.Visible = false;
            // 
            // SectionId1
            // 
            this.SectionId1.DataPropertyName = "SectionId";
            this.SectionId1.HeaderText = "معرف القسم";
            this.SectionId1.Name = "SectionId1";
            this.SectionId1.Visible = false;
            // 
            // BankBranchId
            // 
            this.BankBranchId.DataPropertyName = "BankBranchId";
            this.BankBranchId.HeaderText = "معرف الفرع";
            this.BankBranchId.Name = "BankBranchId";
            this.BankBranchId.Visible = false;
            // 
            // BankId1
            // 
            this.BankId1.DataPropertyName = "BankId";
            this.BankId1.HeaderText = "معرف البنك";
            this.BankId1.Name = "BankId1";
            this.BankId1.Visible = false;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "رقم الحساب";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Visible = false;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 654);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gropbox2);
            this.Controls.Add(this.gropbox1);
            this.Controls.Add(this.gropbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.Resize += new System.EventHandler(this.FrmEmployee_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.gropbox.ResumeLayout(false);
            this.gropbox.PerformLayout();
            this.gropbox1.ResumeLayout(false);
            this.gropbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddJop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddSection)).EndInit();
            this.gropbox2.ResumeLayout(false);
            this.gropbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPaymentMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.ComboBox cmbNamesOfEmployee;
        internal System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAdd;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox gropbox;
        private System.Windows.Forms.TextBox txtNationalNumber;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gropbox1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbJopName;
        internal System.Windows.Forms.ComboBox cmbSectionName;
        private System.Windows.Forms.GroupBox gropbox2;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAccountNumber;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cmbBranchesName;
        internal System.Windows.Forms.ComboBox cmbBankName;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.PictureBox picAddJop;
        private System.Windows.Forms.PictureBox picAddSection;
        private System.Windows.Forms.PictureBox picAddBranch;
        private System.Windows.Forms.PictureBox picAddBank;
        private System.Windows.Forms.PictureBox picAddPaymentMethod;
        internal System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankBranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
    }
}