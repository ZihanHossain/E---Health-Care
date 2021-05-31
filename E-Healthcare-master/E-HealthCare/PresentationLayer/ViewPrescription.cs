using E_HealthCare.BusinessLayer;
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
    public partial class ViewPrescription : Form
    {
        int presctriptionId;
        public ViewPrescription(int presctriptionId)
        {
            InitializeComponent();
            this.presctriptionId = presctriptionId;
        }

        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            PrescriptionService prescriptionService = new PrescriptionService();
            Prescription prescription = prescriptionService.GetUserPrescription(this.presctriptionId);
            patientNameLabel.Text = prescription.PatientName;
            doctorNameLabel.Text = prescription.DoctorName;
            dateLabel.Text = prescription.Date;
            ProblemLabel.Text = prescription.Problem;

            //string path = @"d:\OOP2\E-Healthcare\E-Healthcare\16.json";
            string path = @"d:\OOP2\E-Healthcare\E-Healthcare\" + this.presctriptionId+".json";
            var strResultJson = File.ReadAllText(path);
            medicinesTextBox.Text = JsonConvert.DeserializeObject<IEnumerable<Medicine>>(strResultJson).ToString();
            Console.WriteLine(JsonConvert.DeserializeObject<List<Medicine>>(strResultJson));
        }
    }
}
