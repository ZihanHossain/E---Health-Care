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
    public partial class FindAmbulance : Form
    {
        int userId;
        int ambulanceId;
        string name;
        public FindAmbulance(int userId, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.name = name;
        }

        private void FindAmbulance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindAmbulance_Load(object sender, EventArgs e)
        {
            ProviderService providerService = new ProviderService();
            vehicleDataGridView.DataSource = providerService.GetAdminVehicle();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ProviderService providerService = new ProviderService();
            vehicleDataGridView.DataSource = providerService.GetAdminVehicleByLoc(locTextBox.Text);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            User user = new User();
            user = userService.GetUserPhone(this.userId);
            ProviderService providerService = new ProviderService();
            int result = providerService.UpdateVehicle(this.name,userTextBox.Text, user.Phone, this.userId, this.ambulanceId,1);
            if (result > 0)
            {
                MessageBox.Show("Request Done");
                UserPanel userPanel = new UserPanel(this.userId, this.name);
                this.Hide();
                userPanel.Show();
            }
            else { MessageBox.Show("Request Error!"); }
        }

        private void vehicleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ambulanceId = (int)vehicleDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = new UserPanel(this.userId, this.name);
            this.Hide();
            userPanel.Show();
        }
    }
}
