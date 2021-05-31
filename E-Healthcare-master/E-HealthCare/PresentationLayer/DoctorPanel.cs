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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel(int userId, string Name)
        {
            InitializeComponent();
            DoctorId = userId;
            DoctorName = Name;
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Appointment SelectedPatient { get; set; }

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            AppointmentDataGridViewLoad();
            welcomeLabel.Text = "Dr."+DoctorName;
        }

        public void AppointmentDataGridViewLoad()
        {
            AppointmentService appointmentService = new AppointmentService();
            appoinmentsDataGridView.DataSource = appointmentService.GetDoctorAppointments(DoctorId);
            appoinmentsDataGridView.Columns["AppointmentId"].Visible = false;
            appoinmentsDataGridView.Columns["DoctorName"].Visible = false;
            appoinmentsDataGridView.Columns["DoctorId"].Visible = false;
        }

        private void DoctorPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void appoinmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedPatient = appoinmentsDataGridView.SelectedRows[0].DataBoundItem as Appointment;
                SelectedPatient = selectedPatient;
                selectedPatient = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error Occured" + ex.Message + " - " + ex.Source);
                throw;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(SelectedPatient != null)
            {
                PatientPanel patientPanel = new PatientPanel(SelectedPatient.UserId, SelectedPatient.AppointmentId, DoctorName);
                patientPanel.Show();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void profilePanelButton_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(DoctorId, DoctorName, 3);
            this.Hide();
            userDashboard.Show();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if(SelectedPatient != null)
            {
                AppointmentService appointmentService = new AppointmentService();
                appointmentService.DeleteAppointment(SelectedPatient.AppointmentId);
                AppointmentDataGridViewLoad();
            }
        }
    }
}
