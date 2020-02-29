namespace Payroll
{
    partial class DeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeptDataGridView = new System.Windows.Forms.DataGridView();
            this.deptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payroll_DeptDataSet = new Payroll.payroll_DeptDataSet();
            this.departmentTableAdapter = new Payroll.payroll_DeptDataSetTableAdapters.departmentTableAdapter();
            this.payroll_dbDataSet = new Payroll.payroll_dbDataSet();
            this.payrolldbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_DeptDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrolldbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(340, 245);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLabel.Location = new System.Drawing.Point(152, 11);
            this.DeptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(166, 31);
            this.DeptLabel.TabIndex = 1;
            this.DeptLabel.Text = "Department";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 245);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 28);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeptDataGridView
            // 
            this.DeptDataGridView.AllowUserToAddRows = false;
            this.DeptDataGridView.AllowUserToDeleteRows = false;
            this.DeptDataGridView.AllowUserToOrderColumns = true;
            this.DeptDataGridView.AutoGenerateColumns = false;
            this.DeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptnameDataGridViewTextBoxColumn});
            this.DeptDataGridView.DataSource = this.departmentBindingSource;
            this.DeptDataGridView.Location = new System.Drawing.Point(16, 52);
            this.DeptDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DeptDataGridView.Name = "DeptDataGridView";
            this.DeptDataGridView.ReadOnly = true;
            this.DeptDataGridView.RowHeadersWidth = 51;
            this.DeptDataGridView.Size = new System.Drawing.Size(424, 185);
            this.DeptDataGridView.TabIndex = 7;
            // 
            // deptnameDataGridViewTextBoxColumn
            // 
            this.deptnameDataGridViewTextBoxColumn.DataPropertyName = "deptname";
            this.deptnameDataGridViewTextBoxColumn.HeaderText = "Department";
            this.deptnameDataGridViewTextBoxColumn.Name = "deptnameDataGridViewTextBoxColumn";
            this.deptnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.payroll_DeptDataSet;
            // 
            // payroll_DeptDataSet
            // 
            this.payroll_DeptDataSet.DataSetName = "payroll_DeptDataSet";
            this.payroll_DeptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // payroll_dbDataSet
            // 
            this.payroll_dbDataSet.DataSetName = "payroll_dbDataSet";
            this.payroll_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrolldbDataSetBindingSource
            // 
            this.payrolldbDataSetBindingSource.DataSource = this.payroll_dbDataSet;
            this.payrolldbDataSetBindingSource.Position = 0;
            // 
            // DeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 288);
            this.Controls.Add(this.DeptDataGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeptLabel);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeptForm";
            this.Load += new System.EventHandler(this.DeptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_DeptDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrolldbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DeptDataGridView;
        private payroll_DeptDataSet payroll_DeptDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private payroll_DeptDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptnameDataGridViewTextBoxColumn;
        private payroll_dbDataSet payroll_dbDataSet;
        private System.Windows.Forms.BindingSource payrolldbDataSetBindingSource;
    }
}