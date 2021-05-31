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
    public partial class AdminPanel : Form
    {
        int adminId;
        string name;
        int userId;
        int appointmentId;
        int providerId;
        List<string> department = new List<string> { "","Medicine", "Neurology", "ENT", "Dermatology", "Cardiology" };
        List<string> shift = new List<string> { "ShiftOne", "ShiftTwo" };
        public AdminPanel(int userId, string name)
        {
            InitializeComponent();
            this.adminId = userId;
            this.name = name;
            doctorDepartmentComboBox.DataSource = department;
            shiftComboBox.DataSource = shift;
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            usersGridView.DataSource = userService.GetAdminUser();
            UserService userService1 = new UserService();
            doctorDataGridView.DataSource = userService1.GetAdminDoctor();
            AppointmentService appointmentService = new AppointmentService();
            appointmentsDataGridView.DataSource = appointmentService.GetAdminAppointments();
            UserService userService2 = new UserService();
            ambulanceDataGridView.DataSource = userService2.GetAdminProvider();
            welcomeLabel.Text = this.name;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserRegistrationPanel userRegistrationPanel = new UserRegistrationPanel(this.adminId, this.name, 2);
            this.Hide();
            userRegistrationPanel.Show();
        }

        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorPanel addDoctorPanel = new AddDoctorPanel(this.adminId, this.name);
            this.Hide();
            addDoctorPanel.Show();
        }
        void UpdateLists()
        {
            UserService userService = new UserService();
            usersGridView.DataSource = userService.GetAdminUser();
            UserService userService1 = new UserService();
            doctorDataGridView.DataSource = userService1.GetAdminDoctor();
            UserService userService2 = new UserService();
            ambulanceDataGridView.DataSource = userService2.GetAdminProvider();
            AppointmentService appointmentService = new AppointmentService();
            appointmentsDataGridView.DataSource = appointmentService.GetAdminAppointments();
            welcomeLabel.Text = this.name;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected User Will be Deleted!", "Delete User", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                UserService userService = new UserService();
                int result = userService.DeleteUser(this.userId);
                if (result > 0)
                {
                    MessageBox.Show("User Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void removeDoctorButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Doctor Will be Deleted!", "Delete Doctor", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                UserService userService = new UserService();
                int result = userService.DeleteUser(this.userId);
                if (result > 0)
                {
                    MessageBox.Show("Doctor Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void doctorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.userId = (int)doctorDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.userId = (int)usersGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
            if (doctorDepartmentComboBox.Text == "")
            {
                UserService userService = new UserService();
                doctorDataGridView.DataSource = userService.GetDoctorByName(doctorNameTextBox.Text);
            }
            else {
                UserService userService = new UserService();
                doctorDataGridView.DataSource = userService.GetDoctorDepartment(doctorDepartmentComboBox.Text);
            }
        }

        private void userSearchButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            usersGridView.DataSource = userService.GetUserByPhone(userSearchTextBox.Text);
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            MakeAppoinmentPanel makeAppoinmentPanel = new MakeAppoinmentPanel(this.adminId, this.name, 1);
            this.Hide();
            makeAppoinmentPanel.Show();
        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Appointment Will be Deleted!", "Delete Appointment", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                AppointmentService appointmentService = new AppointmentService();
                int result = appointmentService.DeleteAppointment(this.appointmentId);
                if (result > 0)
                {
                    MessageBox.Show("Appontment Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void appointmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.appointmentId = (int)appointmentsDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Appointment Will be Updated!", "Update Shift", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                AppointmentService appointmentService = new AppointmentService();
                int result = appointmentService.UpdateShift(this.appointmentId, shiftComboBox.SelectedItem.ToString());
                if (result > 0)
                {
                    MessageBox.Show("Appontment Updated!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void ambulanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.providerId = (int)ambulanceDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void removeProviderButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Provider Will be Deleted!", "Delete Provider", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                UserService userService = new UserService();
                int result = userService.DeleteUser(this.providerId);
                if (result > 0)
                {
                    MessageBox.Show("Providor Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void availableAmbulenceButton_Click(object sender, EventArgs e)
        {
            ProviderService providerService = new ProviderService();
            ambulanceDataGridView.DataSource = providerService.GetAdminVehicle();
        }

        private void providerSearchButton_Click(object sender, EventArgs e)
        {
            ProviderService providerService = new ProviderService();
            ambulanceDataGridView.DataSource = providerService.GetAdminVehicleByLoc(locTextBox.Text);
        }
    }
}
