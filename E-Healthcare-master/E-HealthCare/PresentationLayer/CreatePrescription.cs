using E_HealthCare.BusinessLayer;
using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_HealthCare.PresentationLayer
{
    public partial class CreatePrescription : Form
    {
        public CreatePrescription(string doctorName, int patientId, int appointmentId)
        {
            InitializeComponent();
            Prescription = new List<Medicine>();
            DoctorName = doctorName;
            PatientId = patientId;
            AppointmentId = appointmentId;
        }

        public List<Medicine> Prescription { get; set; }
        public string DoctorName { get; set; }
        public int PatientId { get; set; }
        public int AppointmentId { get; set; }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.MedicineName = medicineNameTextBox.Text;
            medicine.Comment = commentTextBox.Text;
            Prescription.Add(medicine);
            MessageBox.Show("Meddicine Added");
        }

        public void addJSON(List<Medicine> prescription, int prescriptionId)
        {
            string strResultJson = JsonConvert.SerializeObject(prescription);
            File.WriteAllText(@"d:\OOP2\E-Healthcare\E-Healthcare\"+prescriptionId+".json", strResultJson);
            //File.WriteAllText(@"D:\Documents\Programming\C#\E-Healthcare\" + prescriptionId + ".json", strResultJson);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.DoctorName = DoctorName;
            prescription.UserId = PatientId;
            prescription.Date = DateTime.Now.ToString("MM/dd/yyyy");
            PrescriptionService prescriptionService = new PrescriptionService();
            prescription.Problem = prescriptionService.GetProblem(AppointmentId);
            PrescriptionService prescriptionService1 = new PrescriptionService();
            addJSON(Prescription, prescriptionService1.AddPrescription(prescription));
        }
    }
}
