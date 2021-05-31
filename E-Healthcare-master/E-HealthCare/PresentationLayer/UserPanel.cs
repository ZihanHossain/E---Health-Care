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
    public partial class UserPanel : Form
    {
        int userId;
        string userName;
        int appointmentId;
        int prescriptionId;
        bool orderByDate;
        public UserPanel( int userId, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = name;
            welcomeLabel.Text = userName;
            orderByDate = false;
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            MakeAppoinmentPanel makeAppoinmentPanel = new MakeAppoinmentPanel(this.userId, this.userName, 2);
            this.Hide();
            makeAppoinmentPanel.Show();
        }

        void UpdateLists()
        {
            AppointmentService appointmentService = new AppointmentService();
            appointmentsDataGridView.DataSource = appointmentService.GetUserAppointments(this.userId);
            /*UserService userService1 = new UserService();
            doctorDataGridView.DataSource = userService1.GetAdminDoctor();
            welcomeLabel.Text = this.name;*/
        }
        private void UserPanel_Load(object sender, EventArgs e)
        {
            AppointmentService appointmentService = new AppointmentService();
            appointmentsDataGridView.DataSource = appointmentService.GetUserAppointments(this.userId);
            PrescriptionDataGridView();
        }

        public void PrescriptionDataGridView()
        {
            PrescriptionService prescriptionService = new PrescriptionService();
            prescriptionDataGridView.DataSource = prescriptionService.GetUserPrescriptions(this.userId, this.orderByDate);
        }

        private void appointmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.appointmentId = (int)appointmentsDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Appointment Will be Deleted!", "Delete Appointment", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                AppointmentService appointmentService = new AppointmentService();
                int result = appointmentService.DeleteAppointment(this.appointmentId);
                if (result > 0)
                {
                    MessageBox.Show("Apointment Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(this.userId, this.userName, 2);
            this.Hide();
            userDashboard.Show();
        }

        private void bloodRequestButton_Click(object sender, EventArgs e)
        {
            BloodRequestPanel bloodRequestPanel = new BloodRequestPanel(this.userId, this.userName);
            this.Hide();
            bloodRequestPanel.Show();
        }

        private void prescriptionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.prescriptionId = (int)prescriptionDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewPrescription viewPrescription = new ViewPrescription(this.prescriptionId);
            viewPrescription.Show();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            FindAmbulance findAmbulance = new FindAmbulance(this.userId, this.userName);
            this.Hide();
            findAmbulance.Show();
        }

        private void orderByButton_Click(object sender, EventArgs e)
        {
            orderByDate = true;
            PrescriptionDataGridView();
        }
    }
}
