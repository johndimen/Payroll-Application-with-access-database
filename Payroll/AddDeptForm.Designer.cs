namespace Payroll
{
    partial class AddDeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeptForm));
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddDeptLabel = new System.Windows.Forms.Label();
            this.DeptNameLabel = new System.Windows.Forms.Label();
            this.DeptNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.Location = new System.Drawing.Point(365, 138);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(107, 36);
            this.Cancelbutton.TabIndex = 0;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(16, 138);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 36);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddDeptLabel
            // 
            this.AddDeptLabel.AutoSize = true;
            this.AddDeptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeptLabel.Location = new System.Drawing.Point(129, 11);
            this.AddDeptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddDeptLabel.Name = "AddDeptLabel";
            this.AddDeptLabel.Size = new System.Drawing.Size(225, 31);
            this.AddDeptLabel.TabIndex = 2;
            this.AddDeptLabel.Text = "Add Department";
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.AutoSize = true;
            this.DeptNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNameLabel.Location = new System.Drawing.Point(36, 73);
            this.DeptNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(129, 18);
            this.DeptNameLabel.TabIndex = 3;
            this.DeptNameLabel.Text = "Department Name";
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNameTextBox.Location = new System.Drawing.Point(186, 70);
            this.DeptNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.Size = new System.Drawing.Size(260, 24);
            this.DeptNameTextBox.TabIndex = 4;
            // 
            // AddDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 188);
            this.Controls.Add(this.DeptNameTextBox);
            this.Controls.Add(this.DeptNameLabel);
            this.Controls.Add(this.AddDeptLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Cancelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDeptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDeptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label AddDeptLabel;
        private System.Windows.Forms.Label DeptNameLabel;
        private System.Windows.Forms.TextBox DeptNameTextBox;
    }
}