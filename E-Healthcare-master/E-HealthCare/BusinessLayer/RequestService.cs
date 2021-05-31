using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.BusinessLayer
{
    class RequestService
    {
        BloodRequestDataAccess bloodRequestData;

        public RequestService() {
            this.bloodRequestData = new BloodRequestDataAccess();
        }

        public List<BloodRequest> GetRequests(string bg)
        {
            return this.bloodRequestData.GetRequests(bg);
        }
        public List<BloodRequest> GetDonor(int id) {
            
            return this.bloodRequestData.GetDonor(id);
        }

        public int AddRequest(string bg, string requester, string location, string phone, int userId) 
        {
            BloodRequest bloodRequest = new BloodRequest() {BloodGroup = bg, Requester = requester, Location = location,
            Phone = phone, UserId = userId};
            return this.bloodRequestData.AddRequest(bloodRequest);
        }

        public int UpdateRequest(int id, string donor, string phone) {
            return this.bloodRequestData.UpdateRequest(id, donor, phone);
        }

        public int DeleteRequest(int id)
        {
            return this.bloodRequestData.DeleteRequest(id);
        }
    }
}
