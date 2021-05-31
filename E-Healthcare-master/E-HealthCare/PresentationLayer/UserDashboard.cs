using E_HealthCare.BusinessLayer;
using E_HealthCare.DataAccessLayer.Entity;
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
    public partial class UserDashboard : Form
    {
        int userId;
        int role;
        string userName;
        string oldPass;
        public UserDashboard(int userId, string userName, int role)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            this.role = role;
            usernameLabel.Text = userName;
        }

        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = this.userName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.role == 2) {
                UserPanel userPanel = new UserPanel(this.userId, this.userName);
                this.Hide();
                userPanel.Show();
            }
            else if (this.role == 3) {
                DoctorPanel doctorPanel = new DoctorPanel(this.userId, this.userName);
                this.Hide();
                doctorPanel.Show();
            }
            else
            {
                ProviderPanel providerPanel = new ProviderPanel(this.userId, this.userName);
                this.Hide();
                providerPanel.Show();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text == "")
            {
                MessageBox.Show("Old password can not be empty");
            }
            else if (newPassTextBox.Text == "")
            {
                MessageBox.Show("New password can not be empty");
            }
            else if (confirmPassTextBox.Text == "")
            {
                MessageBox.Show("Confirm password can not be empty");
            }
            else {
                if (newPassTextBox.Text != confirmPassTextBox.Text)
                {
                    MessageBox.Show("New password and Confirm password mismatch!");
                }
                else {
                    UserService userService = new UserService();
                    User user = new User();
                    user = userService.GetUserPass(this.userId);
                    if (user.Password == oldPassTextBox.Text)
                    {
                        UserService userService1 = new UserService();
                        int result = userService1.UpdateUserPass(this.userId, newPassTextBox.Text);
                        if (result > 0)
                        {
                            MessageBox.Show("Updated!");
                            if (this.role == 2)
                            {
                                UserPanel userPanel = new UserPanel(this.userId, this.userName);
                                this.Hide();
                                userPanel.Show();
                            }
                            else if (this.role == 3)
                            {
                                DoctorPanel doctorPanel = new DoctorPanel(this.userId, this.userName);
                                this.Hide();
                                doctorPanel.Show();
                            }
                            else if (this.role == 4)
                            {
                                ProviderPanel providerPanel = new ProviderPanel(this.userId, this.userName);
                                this.Hide();
                                providerPanel.Show();
                            }
                        }
                        else { MessageBox.Show("Error!"); }
                    }
                    else { MessageBox.Show("Old Password Incorect!"); }
                }
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Account Will be Deleted!", "Delete Account", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                UserService userService = new UserService();
                int result = userService.DeleteUser(this.userId);
                if (result > 0)
                {
                    MessageBox.Show("Account Deleted!");
                    LoginPanel loginPanel = new LoginPanel();
                    this.Hide();
                    loginPanel.Show();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }
    }
}
