using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.BusinessLayer
{
    class PrescriptionService
    {
        PrescriptionDataAccess prescriptionDataAccess;

        public PrescriptionService() {
            this.prescriptionDataAccess = new PrescriptionDataAccess();
        }
        public int AddPrescription(Prescription prescription)
        {
            prescription.PatientName =  prescriptionDataAccess.GetPatientName(prescription.UserId);
            prescriptionDataAccess.AddPrescription(prescription);
            return prescriptionDataAccess.GetPrescriptionId(prescription.DoctorName, prescription.UserId);
        }

        public string GetProblem(int appointmentId)
        {
            return prescriptionDataAccess.GetProblem(appointmentId);
        }

        public List<Prescription> GetUserPrescriptions(int userId, bool orderByDate)
        {
            return prescriptionDataAccess.GetUserPrescriptions(userId, orderByDate);
        }

        public Prescription GetUserPrescription(int prescriptionId)
        {
            PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();
            return prescriptionDataAccess.GetUserPrescription(prescriptionId);
        }

        public int GetPatientPrescriptionId(string doctorName, int userId)
        {
            PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();
            return prescriptionDataAccess.GetPrescriptionId(doctorName, userId);
        }
        /*public List<Prescription> GetPatientPrescriptions(int prescriptionId)
        {
            return prescriptionDataAccess.GetPatientPrescriptions(prescriptionId);
        }*/
    }
}
