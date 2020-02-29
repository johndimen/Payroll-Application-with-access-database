using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Linq;

namespace Payroll
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        readonly OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        readonly int Pay = 448;
        int initialpay;
        string directory;
        int grosspay;
        double finalpay;
        int hours;
        string date;
        int weeks;
        string employeename;
        string department;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() { return Text; }
        }

        private void DepartmentText_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox DeptBox = (ComboBox)sender;
            int selectedIndex = DeptBox.SelectedIndex;
            int selectedValue = (int)DeptBox.SelectedValue;

            ComboboxItem selectedDept = (ComboboxItem)DeptBox.SelectedItem;
        }
        */

        private void CalcButton_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            hours = (int)HoursWorked.Value;
            initialpay = Pay / 8;
            grosspay = hours * initialpay; 
            GrossPayText.Text = "₱" + grosspay.ToString();
            finalpay = grosspay * 0.80;
            DeductionsText.Text = "₱" + (grosspay - finalpay).ToString();
            NetPayText.Text = "₱" + finalpay.ToString();

                if (string.IsNullOrWhiteSpace(EmployeeNameText.Text))
                {
                EmployeeNameText.Focus();
                MessageBox.Show("Please Provide Details!", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmptyError.Show();
                }
                else
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/payroll_db.accdb");
                    const string sql = "insert into employee(empname) values (@empname)";
                    cmd = new OleDbCommand(sql, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@empname", EmployeeNameText.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void EmployeeNameText_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeNameText.Text))
            {
                EmployeeNameText.Text = "Enter Name";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HoursWorked.Value = 1;
            DepartmentText.SelectedIndex = -1;
            EmployeeNameText.Text = "Enter name";
            WeekChooser.Value = 1;
            DatePicker.ResetText();
            GrossPayText.Clear();
            DeductionsText.Clear();
            NetPayText.Clear();
        }

        private void ChooseDirectory_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                DirectoryText.Text = FolderBrowser.SelectedPath;
                directory = DirectoryText.Text;
            }
        }

        private void GenInvoice_Click(object sender, EventArgs e)
        {
            //string deduct = DeductionsText.Text;
            //string net = NetPayText.Text;
            if (EmployeeNameText.Text != "" && DepartmentText.Text != "" && GrossPayText.Text != "" && DeductionsText.Text != "" && NetPayText.Text != "")
            //if(string.IsNullOrEmpty(employeename + department + grosspay.ToString() + deduct + net))
            {
                EmptyError.Hide();
                employeename = EmployeeNameText.Text;
                date = DatePicker.Text;
                weeks = (int)WeekChooser.Value;
                department = DepartmentText.Text;
                hours = (int)HoursWorked.Value;
                directory = DirectoryText.Text;
                if(System.IO.Directory.Exists(directory))
                {
                    string path = directory + @"\" + employeename + @" Payslip.txt";
                    if (!System.IO.File.Exists(path))
                    {
                        string[] createText = {"Pay Slip",
                                           "\n ==================== \n",
                                           "Employer Name: iTec-Ming-Ming corp.",
                                           "Name: " + employeename,
                                           "Department: " + department,
                                           "\n -------------------- \n",
                                           "Date of Pay: " + date.ToString(),
                                           "Week Number: " + weeks.ToString(),
                                           "Hours Worked: " + hours.ToString(),
                                           "\n -------------------- \n",
                                           "Gross Pay: " + GrossPayText.Text,
                                           "Deductions: " + DeductionsText.Text,
                                           "Net Pay: " + NetPayText.Text,
                                           "\n ==================== \n",
                                           "This Serves as Official Payslip for " + employeename,
                                           "Date of Payment: " + DateTime.Now.ToShortDateString(),
                                           "Date Printed: " + DateTime.Now.ToLongDateString(),
                                           "\n ==================== \n",
                                        };

                        System.IO.File.WriteAllLines(path, createText);
                        MessageBox.Show("Payslip has been created for " + employeename,"Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Payslip for " + employeename + " already exists!","Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("The directory does not exist!", "Opps! Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DirErrorLabel.Show();
                }
            }
            else
            {
                EmptyError.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.employee);
            // TODO: This line of code loads data into the 'payroll_dbDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.payroll_dbDataSet.department);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            EmployeeNameText.Clear();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void InvoicesButton_Click(object sender, EventArgs e)
        {

            directory = DirectoryText.Text;
            if (System.IO.Directory.Exists(directory))
            {
                Process.Start(directory);
                DirErrorLabel.Hide();
            }
            else
            {
                MessageBox.Show("The directory path is not set or does not exist!","Opps! Something went wrong!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                DirErrorLabel.Show();

            }
        }

        private void EmployeeNameText_Click(object sender, EventArgs e)
        {
            EmployeeNameText.Text = "";
            EmptyError.Hide();
            DirErrorLabel.Hide();
        }

        private void DepartmentText_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            DirErrorLabel.Hide();
        }

        private void HoursWorked_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            DirErrorLabel.Hide();
        }

        private void WeekChooser_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            DirErrorLabel.Hide();
        }

        private void DeptButton_Click(object sender, EventArgs e)
        {
            DeptForm form = new DeptForm();
            form.Show();
        }

    }
}
