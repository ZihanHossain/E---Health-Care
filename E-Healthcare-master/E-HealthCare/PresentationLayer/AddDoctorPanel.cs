using E_HealthCare.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_HealthCare.PresentationLayer
{
    public partial class AddDoctorPanel : Form
    {
        int adminId;
        string name;
        List<string> bloodGroup = new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        List<string> gender = new List<string> { "Male", "Female", "Other" };
        List<string> designation = new List<string> { "Assist. Professor", "Asso. Professor", "Professor" };
        List<string> department = new List<string> { "Medicine", "Neurology", "ENT", "Dermatology", "Cardiology" };
        public AddDoctorPanel(int userId, string name)
        {
            InitializeComponent();
            this.adminId = userId;
            this.name = name;
            bgComboBox.DataSource = bloodGroup;
            genderComboBox.DataSource = gender;
            designationComboBox.DataSource = designation;
            deptComboBox.DataSource = department;
        }

        private void AddDoctorPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void instituteLabel_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else if (bgComboBox.Text == "")
            {
                MessageBox.Show("Blood Group can not be empty");
            }
            else if (phoneTextBox.Text == "")
            {
                MessageBox.Show("Phone can not be empty");
            }
            else if (instituteTextBox.Text == "")
            {
                MessageBox.Show("Institute can not be empty");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Adress can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else if (shift1TextBox.Text == "")
            {
                MessageBox.Show("Shift One can not be empty");
            }
            else if (shift2TextBox.Text == "")
            {
                MessageBox.Show("Shift Two can not be empty");
            }
            else if (feeTextBox.Text == "")
            {
                MessageBox.Show("Fee can not be empty");
            }
            else if (degreeCheckedListBox.Text == "")
            {
                MessageBox.Show("Degree can not be empty");
            }
            else if (designationComboBox.Text == "")
            {
                MessageBox.Show("Designation can not be empty");
            }
            else if (ageTextBox.Text == "")
            {
                MessageBox.Show("Age can not be empty");
            }
            else if (genderComboBox.Text == "")
            {
                MessageBox.Show("Gender can not be empty");
            }
            else if (deptComboBox.Text == "")
            {
                MessageBox.Show("Department can not be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    UserService userService = new UserService();
                    int result = userService.AddNewDoctor(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text,
                        dobDateTimePicker.Text, bgComboBox.Text, instituteTextBox.Text,degreeCheckedListBox.Text,
                        designationComboBox.Text,shift1TextBox.Text,shift2TextBox.Text, deptComboBox.Text,
                        Convert.ToSingle(feeTextBox.Text),genderComboBox.Text,Convert.ToInt32(ageTextBox.Text),
                        3, phoneTextBox.Text, addressTextBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("New Doctor Added!");
                        this.Hide();
                        AdminPanel adminPanel = new AdminPanel(this.adminId, this.name);
                        adminPanel.Show();
                    }
                    else { MessageBox.Show("Registration Error!"); }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(this.adminId, this.name);
            this.Hide();
            adminPanel.Show();
        }
    }
}
