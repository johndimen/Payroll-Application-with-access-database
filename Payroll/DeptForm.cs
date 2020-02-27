﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Payroll
{
    public partial class DeptForm : Form
    {
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\KLG\\Desktop\\repos\\College-PayrollApplication-master\\Payroll\\payroll_db.accdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        public DeptForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            /* 
            try
            {
                
                    if (DeptTextBox.Text != "") { 
                    const string sql = "insert into department(deptname) values (@deptname)";
                    cmd = new OleDbCommand(sql, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@deptname", DeptTextBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show(); 
                    this.Hide();
                
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Provide Details!", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        private void DeptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payroll_DeptDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.payroll_DeptDataSet.department);

            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();
            DeptDataGridView.Columns.Add(delbtn);
            DeptDataGridView.Columns.Add(editbtn);
            delbtn.Width = 50;
            editbtn.Width = 50;
            delbtn.HeaderText = "Actions";
            editbtn.Text = "Edit";
            delbtn.Text = "Delete";
            delbtn.UseColumnTextForButtonValue = true;
            editbtn.UseColumnTextForButtonValue = true;

        }



    }

}