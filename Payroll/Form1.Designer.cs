namespace Payroll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_dbDataSet = new Payroll.payroll_dbDataSet();
            this.WeekChooser = new System.Windows.Forms.NumericUpDown();
            this.PayDateLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GrossPayText = new System.Windows.Forms.TextBox();
            this.GrossPayLabel = new System.Windows.Forms.Label();
            this.DeductionsText = new System.Windows.Forms.TextBox();
            this.DeductionsLabel = new System.Windows.Forms.Label();
            this.NetPayLabel = new System.Windows.Forms.Label();
            this.NetPayText = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.GenInvoice = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.HoursWorked = new System.Windows.Forms.NumericUpDown();
            this.FormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EmptyError = new System.Windows.Forms.Label();
            this.InvoicesButton = new System.Windows.Forms.Button();
            this.MandarinLabel = new System.Windows.Forms.Label();
            this.DeptButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseDirectory = new System.Windows.Forms.Button();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new Payroll.EmployeeDataSet();
            this.deptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.departmentTableAdapter = new Payroll.payroll_dbDataSetTableAdapters.departmentTableAdapter();
            this.employeeTableAdapter = new Payroll.EmployeeDataSetTableAdapters.employeeTableAdapter();
            this.DepartmentText = new System.Windows.Forms.ComboBox();
            this.DirErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(94, 183);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(199, 22);
            this.DatePicker.TabIndex = 0;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.payroll_dbDataSet;
            // 
            // payroll_dbDataSet
            // 
            this.payroll_dbDataSet.DataSetName = "payroll_dbDataSet";
            this.payroll_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WeekChooser
            // 
            this.WeekChooser.Location = new System.Drawing.Point(94, 209);
            this.WeekChooser.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.WeekChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeekChooser.Name = "WeekChooser";
            this.WeekChooser.Size = new System.Drawing.Size(135, 22);
            this.WeekChooser.TabIndex = 5;
            this.WeekChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeekChooser.Click += new System.EventHandler(this.WeekChooser_Click);
            // 
            // PayDateLabel
            // 
            this.PayDateLabel.AutoSize = true;
            this.PayDateLabel.Location = new System.Drawing.Point(13, 187);
            this.PayDateLabel.Name = "PayDateLabel";
            this.PayDateLabel.Size = new System.Drawing.Size(66, 17);
            this.PayDateLabel.TabIndex = 6;
            this.PayDateLabel.Text = "Pay Date";
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(12, 211);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(44, 17);
            this.WeekLabel.TabIndex = 7;
            this.WeekLabel.Text = "Week";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(13, 103);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(45, 17);
            this.EmployeeNameLabel.TabIndex = 8;
            this.EmployeeNameLabel.Text = "Name";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(15, 75);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(82, 17);
            this.DepartmentLabel.TabIndex = 9;
            this.DepartmentLabel.Text = "Department";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(13, 237);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(99, 17);
            this.HoursLabel.TabIndex = 10;
            this.HoursLabel.Text = "Hours Worked";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(638, 409);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(638, 380);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GrossPayText
            // 
            this.GrossPayText.Location = new System.Drawing.Point(122, 297);
            this.GrossPayText.Name = "GrossPayText";
            this.GrossPayText.ReadOnly = true;
            this.GrossPayText.Size = new System.Drawing.Size(100, 22);
            this.GrossPayText.TabIndex = 15;
            // 
            // GrossPayLabel
            // 
            this.GrossPayLabel.AutoSize = true;
            this.GrossPayLabel.Location = new System.Drawing.Point(61, 300);
            this.GrossPayLabel.Name = "GrossPayLabel";
            this.GrossPayLabel.Size = new System.Drawing.Size(74, 17);
            this.GrossPayLabel.TabIndex = 14;
            this.GrossPayLabel.Text = "Gross Pay";
            // 
            // DeductionsText
            // 
            this.DeductionsText.Location = new System.Drawing.Point(122, 333);
            this.DeductionsText.Name = "DeductionsText";
            this.DeductionsText.ReadOnly = true;
            this.DeductionsText.Size = new System.Drawing.Size(100, 22);
            this.DeductionsText.TabIndex = 17;
            // 
            // DeductionsLabel
            // 
            this.DeductionsLabel.AutoSize = true;
            this.DeductionsLabel.Location = new System.Drawing.Point(55, 336);
            this.DeductionsLabel.Name = "DeductionsLabel";
            this.DeductionsLabel.Size = new System.Drawing.Size(79, 17);
            this.DeductionsLabel.TabIndex = 16;
            this.DeductionsLabel.Text = "Deductions";
            // 
            // NetPayLabel
            // 
            this.NetPayLabel.AutoSize = true;
            this.NetPayLabel.Location = new System.Drawing.Point(71, 370);
            this.NetPayLabel.Name = "NetPayLabel";
            this.NetPayLabel.Size = new System.Drawing.Size(58, 17);
            this.NetPayLabel.TabIndex = 18;
            this.NetPayLabel.Text = "Net Pay";
            // 
            // NetPayText
            // 
            this.NetPayText.Location = new System.Drawing.Point(122, 367);
            this.NetPayText.Name = "NetPayText";
            this.NetPayText.ReadOnly = true;
            this.NetPayText.Size = new System.Drawing.Size(100, 22);
            this.NetPayText.TabIndex = 19;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(117, 263);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 20;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Location = new System.Drawing.Point(309, 401);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.ReadOnly = true;
            this.DirectoryText.Size = new System.Drawing.Size(172, 22);
            this.DirectoryText.TabIndex = 22;
            // 
            // GenInvoice
            // 
            this.GenInvoice.Location = new System.Drawing.Point(100, 399);
            this.GenInvoice.Name = "GenInvoice";
            this.GenInvoice.Size = new System.Drawing.Size(104, 23);
            this.GenInvoice.TabIndex = 23;
            this.GenInvoice.Text = "Generate Invoice";
            this.GenInvoice.UseVisualStyleBackColor = true;
            this.GenInvoice.Click += new System.EventHandler(this.GenInvoice_Click);
            // 
            // HoursWorked
            // 
            this.HoursWorked.Location = new System.Drawing.Point(94, 235);
            this.HoursWorked.Maximum = new decimal(new int[] {
            8760,
            0,
            0,
            0});
            this.HoursWorked.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(135, 22);
            this.HoursWorked.TabIndex = 24;
            this.HoursWorked.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoursWorked.Click += new System.EventHandler(this.HoursWorked_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(257, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(340, 52);
            this.FormTitle.TabIndex = 25;
            this.FormTitle.Text = "iTec-Ming-Ming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Finance Details";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(638, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 29;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmptyError
            // 
            this.EmptyError.AutoSize = true;
            this.EmptyError.BackColor = System.Drawing.SystemColors.Control;
            this.EmptyError.ForeColor = System.Drawing.Color.Red;
            this.EmptyError.Location = new System.Drawing.Point(83, 123);
            this.EmptyError.Name = "EmptyError";
            this.EmptyError.Size = new System.Drawing.Size(150, 17);
            this.EmptyError.TabIndex = 30;
            this.EmptyError.Text = "There are empty fields";
            this.EmptyError.Visible = false;
            // 
            // InvoicesButton
            // 
            this.InvoicesButton.Location = new System.Drawing.Point(638, 41);
            this.InvoicesButton.Name = "InvoicesButton";
            this.InvoicesButton.Size = new System.Drawing.Size(75, 23);
            this.InvoicesButton.TabIndex = 31;
            this.InvoicesButton.Text = "Invoices";
            this.InvoicesButton.UseVisualStyleBackColor = true;
            this.InvoicesButton.Click += new System.EventHandler(this.InvoicesButton_Click);
            // 
            // MandarinLabel
            // 
            this.MandarinLabel.AutoSize = true;
            this.MandarinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandarinLabel.Location = new System.Drawing.Point(349, 48);
            this.MandarinLabel.Name = "MandarinLabel";
            this.MandarinLabel.Size = new System.Drawing.Size(98, 31);
            this.MandarinLabel.TabIndex = 32;
            this.MandarinLabel.Text = "伊泰明";
            // 
            // DeptButton
            // 
            this.DeptButton.Location = new System.Drawing.Point(213, 71);
            this.DeptButton.Name = "DeptButton";
            this.DeptButton.Size = new System.Drawing.Size(75, 23);
            this.DeptButton.TabIndex = 33;
            this.DeptButton.Text = "Department";
            this.DeptButton.UseVisualStyleBackColor = true;
            this.DeptButton.Click += new System.EventHandler(this.DeptButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(354, 90);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(359, 114);
            this.LogoPictureBox.TabIndex = 28;
            this.LogoPictureBox.TabStop = false;
            // 
            // ChooseDirectory
            // 
            this.ChooseDirectory.BackgroundImage = global::Payroll.Properties.Resources.download;
            this.ChooseDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChooseDirectory.Image = global::Payroll.Properties.Resources.download_LEp_icon;
            this.ChooseDirectory.Location = new System.Drawing.Point(487, 393);
            this.ChooseDirectory.Name = "ChooseDirectory";
            this.ChooseDirectory.Size = new System.Drawing.Size(32, 34);
            this.ChooseDirectory.TabIndex = 21;
            this.ChooseDirectory.UseVisualStyleBackColor = true;
            this.ChooseDirectory.Click += new System.EventHandler(this.ChooseDirectory_Click);
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToOrderColumns = true;
            this.EmployeeDataGridView.AutoGenerateColumns = false;
            this.EmployeeDataGridView.ColumnHeadersHeight = 29;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn});
            this.EmployeeDataGridView.DataSource = this.employeeBindingSource;
            this.EmployeeDataGridView.Enabled = false;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(384, 209);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(304, 150);
            this.EmployeeDataGridView.TabIndex = 34;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID Number";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "empname";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.empnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptnameDataGridViewTextBoxColumn
            // 
            this.deptnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deptnameDataGridViewTextBoxColumn.Name = "deptnameDataGridViewTextBoxColumn";
            this.deptnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Location = new System.Drawing.Point(84, 100);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(202, 22);
            this.EmployeeNameText.TabIndex = 2;
            this.EmployeeNameText.Text = "Enter Name";
            this.EmployeeNameText.Click += new System.EventHandler(this.EmployeeNameText_Click);
            this.EmployeeNameText.MouseLeave += new System.EventHandler(this.EmployeeNameText_MouseLeave);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentText
            // 
            this.DepartmentText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "deptname", true));
            this.DepartmentText.DataSource = this.departmentBindingSource;
            this.DepartmentText.DisplayMember = "deptname";
            this.DepartmentText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentText.FormattingEnabled = true;
            this.DepartmentText.Location = new System.Drawing.Point(84, 72);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(121, 24);
            this.DepartmentText.TabIndex = 35;
            // 
            // DirErrorLabel
            // 
            this.DirErrorLabel.AutoSize = true;
            this.DirErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DirErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DirErrorLabel.Location = new System.Drawing.Point(319, 426);
            this.DirErrorLabel.Name = "DirErrorLabel";
            this.DirErrorLabel.Size = new System.Drawing.Size(109, 17);
            this.DirErrorLabel.TabIndex = 36;
            this.DirErrorLabel.Text = "File path not set";
            this.DirErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(725, 456);
            this.Controls.Add(this.DirErrorLabel);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.DeptButton);
            this.Controls.Add(this.MandarinLabel);
            this.Controls.Add(this.InvoicesButton);
            this.Controls.Add(this.EmptyError);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.GenInvoice);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.ChooseDirectory);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.NetPayText);
            this.Controls.Add(this.NetPayLabel);
            this.Controls.Add(this.DeductionsText);
            this.Controls.Add(this.DeductionsLabel);
            this.Controls.Add(this.GrossPayText);
            this.Controls.Add(this.GrossPayLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.PayDateLabel);
            this.Controls.Add(this.WeekChooser);
            this.Controls.Add(this.EmployeeNameText);
            this.Controls.Add(this.DatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.NumericUpDown WeekChooser;
        private System.Windows.Forms.Label PayDateLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox GrossPayText;
        private System.Windows.Forms.Label GrossPayLabel;
        private System.Windows.Forms.TextBox DeductionsText;
        private System.Windows.Forms.Label DeductionsLabel;
        private System.Windows.Forms.Label NetPayLabel;
        private System.Windows.Forms.TextBox NetPayText;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ChooseDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Button GenInvoice;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.NumericUpDown HoursWorked;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label EmptyError;
        private System.Windows.Forms.Button InvoicesButton;
        private System.Windows.Forms.Label MandarinLabel;
        private System.Windows.Forms.Button DeptButton;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.TextBox EmployeeNameText;
        private payroll_dbDataSet payroll_dbDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private payroll_dbDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox DepartmentText;
        private System.Windows.Forms.Label DirErrorLabel;
    }
}

