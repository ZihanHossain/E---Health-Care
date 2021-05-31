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
    public partial class MakeAppoinmentPanel : Form
    {
        int userId;
        int role;
        string userName;
        int doctorId;
        //string doctorName;
        List<string> department = new List<string> { "","Medicine", "Neurology", "ENT", "Dermatology", "Cardiology" };
        List<string> shift = new List<string> { "ShiftOne", "ShiftTwo" };
        public MakeAppoinmentPanel(int userId, string userName, int role)
        {
            InitializeComponent();
            departmentComboBox.DataSource = department;
            selectShiftComboBox.DataSource = shift;
            this.userId = userId;
            this.userName = userName;
            this.role = role;
        }

        private void MakeAppoinmentPanel_Load(object sender, EventArgs e)
        {
            UserService userService1 = new UserService();
            doctorDataGridView.DataSource = userService1.GetAdminDoctor();
            patientIdTextBox.Text = Convert.ToString(this.userId);
            patientNameTextBox.Text = this.userName;
        }

        private void doctorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.doctorId = (int)doctorDataGridView.Rows[e.RowIndex].Cells[0].Value;
            doctorNameTextBox.Text = doctorDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (departmentComboBox.Text == "")
            {
                UserService userService = new UserService();
                doctorDataGridView.DataSource = userService.GetDoctorByName(doctorNameTextBox.Text);
            }
            else
            {
                UserService userService = new UserService();
                doctorDataGridView.DataSource = userService.GetDoctorDepartment(departmentComboBox.Text);
            }
        }

        private void makeAppointmentButton_Click(object sender, EventArgs e)
        {
            if (problemTextBox.Text == "")
            {
                MessageBox.Show("Problem can not be empty");
            }
            else {
                AppointmentService appointmentService = new AppointmentService();
                int result = appointmentService.AddNewAppointment(dateTimePicker.Text, doctorNameTextBox.Text, patientNameTextBox.Text,
                    problemTextBox.Text, selectShiftComboBox.Text, this.doctorId, Convert.ToInt32(patientIdTextBox.Text));
                if (result > 0)
                {
                    if (this.role == 1)
                    {
                        MessageBox.Show("Appointment Created!");
                        this.Hide();
                        AdminPanel adminPanel = new AdminPanel(this.userId, this.userName);
                        adminPanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Appointment Created!");
                        this.Hide();
                        UserPanel userPanel = new UserPanel(this.userId, this.userName);
                        userPanel.Show();
                    }
                }
                else { MessageBox.Show("Error!"); }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.role == 1)
            {
                AdminPanel adminPanel = new AdminPanel(this.userId, this.userName);
                this.Hide();
                adminPanel.Show();
            }
            else {
                UserPanel userPanel = new UserPanel(this.userId, this.userName);
                this.Hide();
                userPanel.Show();
            }
        }

        private void MakeAppoinmentPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
