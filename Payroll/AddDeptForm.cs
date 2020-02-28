using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class AddDeptForm : Form
    {
        OleDbCommand cmd;
        readonly OleDbCommand cmd1;
        readonly OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/payroll_db.accdb");

        public AddDeptForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DeptNameTextBox.Text))
            {
                MessageBox.Show("Opps! Something went wrong!", "There's an Empty Field."+ Environment.NewLine + "Please Fill-up the form and Try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DeptNameTextBox.Focus();
            }
            else 
            {
                /*
                int adminid = 1;
                string add = "Add";
                int id = 1;
                string comment = "Added Successfully";
                */
                cmd = new OleDbCommand("insert into department(deptname) values(@deptname)", con);
                //cmd1 = new OleDbCommand("insert into audittrail(action,tableid,comment) values(@add,@id,@comment)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@deptname", DeptNameTextBox.Text);
                //cmd1.Parameters.AddWithValue("@add",add);
                //cmd1.Parameters.AddWithValue("@id", id);
                //cmd1.Parameters.AddWithValue("@comment", comment);
                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(DeptNameTextBox.Text))
            {
                this.Hide();
            }
            else
            {
                var result = MessageBox.Show("There are still unsaved changes." + Environment.NewLine + "are you sure you want to continue?","Textbox has been filled!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(result == DialogResult.Yes)
                {
                    this.Close();
                } 
                else if (result == DialogResult.No)
                {
                    DeptNameTextBox.Focus();
                }
            } 
            
        }
    }
}
