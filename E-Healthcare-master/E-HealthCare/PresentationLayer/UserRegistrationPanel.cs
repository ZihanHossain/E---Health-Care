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
    public partial class UserRegistrationPanel : Form
    {
        List<string> bloodGroup = new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        List<string> gender = new List<string> { "Male", "Female", "Other"};
        int adminId;
        string adminName;
        int role;
        public UserRegistrationPanel(int userId, string name, int role)
        {
            InitializeComponent();
            registerButton.Enabled = false;
            bgComboBox.DataSource = bloodGroup;
            genderComboBox.DataSource = gender;
            this.adminId = userId;
            this.adminName = name;
            this.role = role;
        }

        private void UserRegistrationPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
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
            else if (genderComboBox.Text == "")
            {
                MessageBox.Show("Gender can not be empty");
            }
            else if (ageTextBox.Text == "")
            {
                MessageBox.Show("Age can not be empty");
            }
            else if (phoneTextBox.Text == "")
            {
                MessageBox.Show("Phone can not be empty");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Adress can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
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
                    int result = userService.AddNewUser(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, dobDateTimePicker.Text, bgComboBox.Text,genderComboBox.Text,Convert.ToInt32(ageTextBox.Text),this.role,phoneTextBox.Text,addressTextBox.Text);
                    if (result > 0)
                    {
                        if (this.adminId == 0)
                        {
                            MessageBox.Show("You have been Registerd!");
                            this.Hide();
                            LoginPanel loginPanel = new LoginPanel();
                            loginPanel.Show();
                        }
                        else {
                            MessageBox.Show("User Added!");
                            this.Hide();
                            AdminPanel adminPanel = new AdminPanel(this.adminId, this.adminName);
                            adminPanel.Show();
                        }
                    }
                    else { MessageBox.Show("Registration Error!"); }
                }
            }
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                registerButton.Enabled = true;
            }
            else
                registerButton.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.adminId == 0)
            {
                LoginPanel loginPanel = new LoginPanel();
                this.Hide();
                loginPanel.Show();
            }
            else
            {
                AdminPanel adminPanel = new AdminPanel(this.adminId, this.adminName);
                this.Hide();
                adminPanel.Show();
            }
        }
    }
}
