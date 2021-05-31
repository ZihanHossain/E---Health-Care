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
    public partial class ProviderPanel : Form
    {
        int userId;
        string name;
        int ambulanceId;
        public ProviderPanel(int userId, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.name = name;
            welcomeLabel.Text = name;
        }

        private void ProviderPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle(this.userId, this.name);
            this.Hide();
            addVehicle.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(this.userId, this.name, 4);
            this.Hide();
            userDashboard.Show();
        }
        void UpdateLists()
        {
            ProviderService providerService = new ProviderService();
            vehicleDataGridView.DataSource = providerService.GetProviderVehicle(this.userId);
            ProviderService providerService1 = new ProviderService();
            requestDataGridView.DataSource = providerService1.GetProviderRequest(this.userId);
        }
        private void doneButton_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Done?", "Done!", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                ProviderService providerService = new ProviderService();
                int result = providerService.UpdateVehicle(null, null, null,0,this.ambulanceId,0);
                if (result > 0)
                {
                    MessageBox.Show("Done!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void ProviderPanel_Load(object sender, EventArgs e)
        {
            ProviderService providerService = new ProviderService();
            vehicleDataGridView.DataSource = providerService.GetProviderVehicle(this.userId);
            ProviderService providerService1 = new ProviderService();
            requestDataGridView.DataSource = providerService1.GetProviderRequest(this.userId);
        }

        private void requestDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ambulanceId = (int)requestDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
