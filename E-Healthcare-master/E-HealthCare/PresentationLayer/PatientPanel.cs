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
    public partial class PatientPanel : Form
    {
        List<Prescription> prescriptions;
        bool orderByDate;
        public PatientPanel(int patientId, int appointmentId, string doctorName)
        {
            InitializeComponent();
            PatientId = patientId;
            AppointmentId = appointmentId;
            DoctorName = doctorName;
            orderByDate = false;
        }

        public int PatientId { get; set; }
        public int AppointmentId { get; set; }
        public string DoctorName { get; set; }

        private void PatientPanel_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            var patient = userService.GetPatient(PatientId, AppointmentId);
            namelabel.Text = patient.Name;
            problemLabel.Text = patient.Problem;
            bloodGroupLabel.Text = patient.BloodGroup;
            ageLabel.Text = patient.Age.ToString();

            PrescriptionService prescriptionService = new PrescriptionService();
            //var prescriptionId = prescriptionService.GetPatientPrescriptionId(DoctorName, PatientId);

            //Console.WriteLine(prescriptionId);
            this.prescriptions = prescriptionService.GetUserPrescriptions(PatientId, orderByDate);
            Console.WriteLine(prescriptions.Count);
            for (int i = 0; i < prescriptions.Count; i++)
            {
                historyComboBox.Items.Add(prescriptions[i].DoctorName);
            }
        }

        private void PatientPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            CreatePrescription createPrescription = new CreatePrescription(DoctorName, PatientId, AppointmentId);
            createPrescription.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var i = historyComboBox.SelectedIndex;
            ViewPrescription viewPrescription = new ViewPrescription(prescriptions[i].PrescriptionId);
            viewPrescription.Show();
        }
    }
}
