using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer
{
    class BloodRequestDataAccess: DataAccess
    {
        public List<BloodRequest> GetRequests(string bloodGroup)
        {
            string sql = "SELECT * fROM BloodRequestes WHERE BloodGroup=" + "'"+bloodGroup+"'";
            SqlDataReader reader = this.GetData(sql);
            List<BloodRequest> rquests = new List<BloodRequest>();
            while (reader.Read())
            {
                BloodRequest bloodRequest = new BloodRequest();
                bloodRequest.BloodId = Convert.ToInt32(reader["BloodId"]);
                bloodRequest.BloodGroup = reader["BloodGroup"].ToString();
                bloodRequest.Requester = reader["Requester"].ToString();
                bloodRequest.Location = reader["Location"].ToString();
                bloodRequest.Phone = reader["Phone"].ToString();
                rquests.Add(bloodRequest);
            }
            return rquests;
        }

        public List<BloodRequest> GetDonor(int userId)
        {
            string sql = "SELECT BloodId,BloodGroup,Donor,DonorPhone fROM BloodRequestes";
            SqlDataReader reader = this.GetData(sql);
            List<BloodRequest> rquests = new List<BloodRequest>();

            while (reader.Read())
            {
                BloodRequest bloodRequest = new BloodRequest();
                bloodRequest.BloodId = Convert.ToInt32(reader["BloodId"]);
                bloodRequest.BloodGroup = reader["BloodGroup"].ToString();
                bloodRequest.Donor = reader["Donor"].ToString();
                bloodRequest.DonorPhone = reader["DonorPhone"].ToString();
                rquests.Add(bloodRequest);
            }
            return rquests;
        }
        public int AddRequest(BloodRequest request)
        {
            string sql = "INSERT INTO BloodRequestes(BloodGroup,Requester,Location,Phone,UserId) VALUES ('" + request.BloodGroup + "', '" + request.Requester + "','" + request.Location + "','" + request.Phone + "',"+ request.UserId+")";
            return this.ExecuteQuery(sql);
        }
        public int UpdateRequest(int id,string donor, string phone)
        {
            string sql = "UPDATE BloodRequestes SET Donor = '" + donor + "',"+ "DonorPhone = '"+phone+"' WHERE BloodID = " + id;
            return this.ExecuteQuery(sql);
        }

        public int DeleteRequest(int id)
        {
            string sql = "DELETE FROM BloodRequestes WHERE BloodID=" + id;
            return this.ExecuteQuery(sql);
        }
    }
}
