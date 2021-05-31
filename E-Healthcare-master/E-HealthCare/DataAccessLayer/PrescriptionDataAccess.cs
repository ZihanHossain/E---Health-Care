using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer
{
    class PrescriptionDataAccess: DataAccess
    {
        public List<Prescription> GetUserPrescriptions(int userId, bool orederByDate)
        {
            Console.WriteLine(orederByDate);
            string sql;
            if (orederByDate == true)
            {
                sql = "SELECT Date,DoctorName,Department,Problem,PrescriptionId,UserId FROM Prescriptions WHERE UserId=" + userId + "ORDER BY UserId DESC";
            }
            else
            {
                sql = "SELECT Date,DoctorName,Department,Problem,PrescriptionId,UserId FROM Prescriptions WHERE UserId=" + userId;
            }
            
            SqlDataReader reader = this.GetData(sql);
            List<Prescription> prescriptions = new List<Prescription>();
            while (reader.Read())
            {
                Prescription prescription = new Prescription();
                prescription.Date = reader["Date"].ToString();
                prescription.DoctorName = reader["DoctorName"].ToString();
                prescription.Problem = reader["Problem"].ToString();
                prescription.UserId = Convert.ToInt32(reader["UserId"]);
                prescription.PrescriptionId = Convert.ToInt32(reader["PrescriptionId"]);
                //prescription.Department = reader["Department"].ToString();
                prescriptions.Add(prescription);
            }
            return prescriptions;
        }

        public Prescription GetUserPrescription(int prescriptionId)
        {
            string sql = "SELECT Date,DoctorName,Department,Problem,UserId FROM Prescriptions WHERE PrescriptionId=" + prescriptionId;
            SqlDataReader reader = this.GetData(sql);
            Prescription prescription = new Prescription();
            if (reader.Read())
            {
                prescription.Date = reader["Date"].ToString();
                prescription.DoctorName = reader["DoctorName"].ToString();
                prescription.Problem = reader["Problem"].ToString();
                prescription.UserId = Convert.ToInt32(reader["UserId"]);
            }
            string sql2 = "SELECT Name FROM Users WHERE UserId =" + Convert.ToInt32(reader["UserId"]);
            reader.Close();
            SqlDataReader reader2 = this.GetData(sql2);
            if (reader2.Read())
            {
                prescription.PatientName = reader2["Name"].ToString();
            }
            return prescription;
        }

        public int GetPrescriptionId(string doctorName, int userId)
        {
            string sql = "SELECT PrescriptionId FROM Prescriptions WHERE UserId = " + userId + "AND DoctorName LIKE '%"+doctorName+"%'";
            SqlDataReader reader = this.GetData(sql);
            if(reader.Read())
            {
                return Convert.ToInt32(reader["PrescriptionId"]);
            }
            return 0;
        }

        public int AddPrescription(Prescription prescription)
        {
            string sql = "INSERT INTO Prescriptions(Date,DoctorName,Department,Problem,UserId,PatientName) VALUES ('" + prescription.Date + "', '" + prescription.DoctorName + "','" + prescription.Department + "','" + prescription.Problem + "','"+ prescription.UserId + "','"+ prescription.PatientName +"')";
            return this.ExecuteQuery(sql);
        }

        public int GetPatientPrescriptionId(int patientId, string doctorName)
        {
            string sql = "SELECT PrescriptionId FROM Prescriptions WHERE Date LIKE '%" + DateTime.Now.ToString("MM/dd/yyyy") + "%' AND UserId = "+ patientId + " AND DoctorName LIKE '%"+doctorName+"%'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["PrescriptionId"]);
            }
            return 0;
        }

        /*public List<Prescription> GetPatientPrescriptions(int prescriptionId)
        {
            string sql = "SELECT Date,DoctorName,Department,Problem,PrescriptionId,UserId,PatientName FROM Prescriptions WHERE PrescriptionId=" + prescriptionId;
            SqlDataReader reader = this.GetData(sql);
            List<Prescription> prescriptions = new List<Prescription>();
            while (reader.Read())
            {
                Prescription prescription = new Prescription();
                prescription.Date = reader["Date"].ToString();
                prescription.DoctorName = reader["DoctorName"].ToString();
                prescription.Problem = reader["Problem"].ToString();
                prescription.UserId = Convert.ToInt32(reader["UserId"]);
                prescription.PrescriptionId = Convert.ToInt32(reader["PrescriptionId"]);
                prescription.PatientName = reader["PatientName"].ToString();
                prescriptions.Add(prescription);
            }
            return prescriptions;
        }*/

        public string GetPatientName(int userId)
        {
            string sql = "SELECT Name FROM Users WHERE UserId = " + userId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["Name"].ToString();
            }
            return null;
        }

        public string GetProblem(int appointmentId)
        {
            string sql = "SELECT Problem FROM Appointments WHERE AppointmentId = " + appointmentId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["Problem"].ToString();
            }
            return null;
        }
    }
}
