using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer
{
    class AmbulanceDataAccess: DataAccess
    {
        public List<Ambulance> GetAdminVehicleByLoc(string location)
        {
            string sql = "SELECT * FROM Ambulances WHERE Location LIKE '%" +location+"%' AND Booked="+0;
            SqlDataReader reader = this.GetData(sql);
            List<Ambulance> ambulances = new List<Ambulance>();
            while (reader.Read())
            {
                Ambulance ambulance = new Ambulance();
                ambulance.AmbulanceId = Convert.ToInt32(reader["AmbulanceId"]);
                ambulance.Number = reader["Number"].ToString();
                ambulance.Phone = reader["Phone"].ToString();
                ambulance.Location = reader["Location"].ToString();
                ambulance.UserId = Convert.ToInt32(reader["UserId"]);
                ambulances.Add(ambulance);
            }
            return ambulances;
        }

        public List<Ambulance> GetAdminVehicle()
        {
            string sql = "SELECT * FROM Ambulances WHERE Booked="+0;
            SqlDataReader reader = this.GetData(sql);
            List<Ambulance> ambulances = new List<Ambulance>();
            while (reader.Read())
            {
                Ambulance ambulance = new Ambulance();
                ambulance.AmbulanceId = Convert.ToInt32(reader["AmbulanceId"]);
                ambulance.Number = reader["Number"].ToString();
                ambulance.Phone = reader["Phone"].ToString();
                ambulance.Location = reader["Location"].ToString();
                ambulance.UserId = Convert.ToInt32(reader["UserId"]);
                ambulances.Add(ambulance);
            }
            return ambulances;
        }
        public List<Ambulance> GetProviderVehicle(int userId)
        {
            string sql = "SELECT * FROM Ambulances WHERE UserId=" +userId +" AND Booked="+0;
            SqlDataReader reader = this.GetData(sql);
            List<Ambulance> ambulances = new List<Ambulance>();
            while (reader.Read())
            {
                Ambulance ambulance = new Ambulance();
                ambulance.AmbulanceId = Convert.ToInt32(reader["AmbulanceId"]);
                ambulance.Number = reader["Number"].ToString();
                ambulance.Phone = reader["Phone"].ToString();
                ambulance.Location = reader["Location"].ToString();
                ambulance.UserId = Convert.ToInt32(reader["UserId"]);
                ambulances.Add(ambulance);
            }
            return ambulances;
        }
        public List<Ambulance> GetProviderRequest(int userId)
        {
            string sql = "SELECT * FROM Ambulances WHERE UserId=" + userId + " AND Booked=" + 1;
            SqlDataReader reader = this.GetData(sql);
            List<Ambulance> ambulances = new List<Ambulance>();
            while (reader.Read())
            {
                Ambulance ambulance = new Ambulance();
                ambulance.AmbulanceId = Convert.ToInt32(reader["AmbulanceId"]);
                ambulance.Number = reader["Number"].ToString();
                ambulance.Phone = reader["Phone"].ToString();
                ambulance.Location = reader["Location"].ToString();
                ambulance.BookerName = reader["BookerName"].ToString();
                ambulance.BookerLocation = reader["BookerLocation"].ToString();
                ambulance.BookerPhone = reader["BookerPhone"].ToString();
                ambulance.UserId = Convert.ToInt32(reader["UserId"]);
                ambulances.Add(ambulance);
            }
            return ambulances;
        }

        public int AddVehicel(Ambulance ambulance)
        {
            string sql = "INSERT INTO Ambulances(Number,Driver,Location,Phone,Fee,Booked,UserId) VALUES ('" + ambulance.Number + "', '" + ambulance.Driver + "','" + ambulance.Location + "','" + ambulance.Phone + "'," + ambulance.Fee+","+0+","+ambulance.UserId+ ")";
            return this.ExecuteQuery(sql);
        }
        public int UpdateVehicle(int bookerId, string bookerName, string location, string phone, int ambulanceId, int booked)
        {
            string sql = "UPDATE Ambulances SET BookerName = '" + bookerName + "'," + " BookerPhone ='" + phone + "', BookerLocation='" +
                location+ "', Booked=" + booked+ ",BookerId=" + bookerId+" WHERE AmbulanceID = " + ambulanceId;
            return this.ExecuteQuery(sql);
        }

        public int DeleteVehicle(int id)
        {
            string sql = "DELETE FROM Ambulances WHERE AmbulanceID=" + id;
            return this.ExecuteQuery(sql);
        }
    }
}
