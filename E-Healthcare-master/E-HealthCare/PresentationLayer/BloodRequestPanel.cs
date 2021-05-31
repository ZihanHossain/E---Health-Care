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
    public partial class BloodRequestPanel : Form
    {
        List<string> bloodGroup = new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        int userId;
        int bgId;
        string name;
        string phone;
        string bg;
        public BloodRequestPanel(int userId, string name)
        {
            InitializeComponent();
            bloodComboBox.DataSource = bloodGroup;
            this.userId = userId;
            this.name = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Blood_Request_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            if (locationTextBox.Text == "") { MessageBox.Show("Please Enter Location!"); }
            else if (phoneTextBox.Text == "") { MessageBox.Show("Please Enter Phone Number!"); }
            else {
                RequestService requestService = new RequestService();
                int result = requestService.AddRequest(bloodComboBox.Text, this.name, locationTextBox.Text, phoneTextBox.Text, this.userId);
                if (result > 0)
                {
                    MessageBox.Show("Request Made!");
                    locationTextBox.Text = "";
                    phoneTextBox.Text = "";
                }
                else {
                    MessageBox.Show("Request Error!");
                }
            }
        }

        private void BloodRequestPanel_Load(object sender, EventArgs e)
        {
            User user = new User();
            UserService userService = new UserService();
            user = userService.GetUserBG(this.userId);
            this.bg = user.BloodGroup;
            UserService userService1 = new UserService();
            user = userService1.GetUserPhone(this.userId);
            this.phone = user.Phone;
            RequestService requestService = new RequestService();
            currentDataGridView.DataSource = requestService.GetRequests(this.bg);
            RequestService requestService1 = new RequestService();
            donorDataGridView.DataSource = requestService1.GetDonor(this.userId);





        }

        private void currentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bgId = (int)currentDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            RequestService requestService = new RequestService();
            int result = requestService.UpdateRequest(this.bgId, this.name, this.phone);
            if (result > 0)
            {
                MessageBox.Show("Thanks For your Donate");
            }
            else { MessageBox.Show("Thanks For your Donate"); }
        }

        private void donorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bgId = (int)donorDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestService requestService = new RequestService();
            int result = requestService.DeleteRequest(this.bgId);
            if (result > 0)
            {
                RequestService requestService1 = new RequestService();
                donorDataGridView.DataSource = requestService1.GetDonor(this.userId);
            }
            else { MessageBox.Show("Error!"); }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = new UserPanel(this.userId, this.name);
            this.Hide();
            userPanel.Show();
        }

        private void currentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
