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
    public partial class AddVehicle : Form
    {
        int userId;
        string name;
        public AddVehicle(int userId, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.name = name;
        }

        private void AddVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "")
            {
                MessageBox.Show("Number is Empty!");
            }
            else if (driverTextBox.Text == "")
            {
                MessageBox.Show("Driver is Empty!");
            }
            else if (locationTextBox.Text == "")
            {
                MessageBox.Show("Location is Empty!");
            }
            else if (phoneTextBox.Text == "")
            {
                MessageBox.Show("Phone is Empty!");
            }
            else if (feeTextBox.Text == "")
            {
                MessageBox.Show("Fee is Empty!");
            }
            else {
                ProviderService providerService = new ProviderService();
                int result = providerService.AddNewVehicle(numberTextBox.Text, driverTextBox.Text, locationTextBox.Text,
                        phoneTextBox.Text, Convert.ToSingle(feeTextBox.Text), this.userId);
                if (result > 0)
                {
                    MessageBox.Show("New Vehicle Added!");
                    this.Hide();
                    ProviderPanel providerPanel = new ProviderPanel(this.userId, this.name);
                    providerPanel.Show();
                }
                else { MessageBox.Show("Registration Error!"); }
            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ProviderPanel providerPanel = new ProviderPanel(this.userId, this.name);
            this.Hide();
            providerPanel.Show();
        }
    }
}
