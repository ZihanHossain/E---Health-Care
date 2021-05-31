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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                
                UserService userService = new UserService();
                User user = userService.GetUser(userNameTextBox.Text, passwordTextBox.Text);
                if (user != null && user.Role == 3)
                {
                    DoctorPanel doctorPanel = new DoctorPanel(user.UserId, user.Name);
                    this.Hide();
                    doctorPanel.Show();
                }
                else if (user != null && user.Role == 2)
                {
                    UserPanel userPanel = new UserPanel(user.UserId, user.Name);
                    this.Hide();
                    userPanel.Show();
                }
                else if (user != null && user.Role == 1)
                {
                    AdminPanel adminPanel = new AdminPanel(user.UserId, user.Name);
                    this.Hide();
                    adminPanel.Show();
                }
                else if (user != null && user.Role == 4)
                {
                    ProviderPanel providerPanel = new ProviderPanel(user.UserId, user.Name);
                    this.Hide();
                    providerPanel.Show();
                }
                else {
                    MessageBox.Show("You Don't Have Any Account!");
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserRegistrationPanel userRegistrationPanel = new UserRegistrationPanel(0, null, 2);
            this.Hide();
            userRegistrationPanel.Show();
        }

        private void providerRegisterButton_Click(object sender, EventArgs e)
        {
            UserRegistrationPanel userRegistrationPanel = new UserRegistrationPanel(0, null, 4);
            this.Hide();
            userRegistrationPanel.Show();
        }
    }
}
