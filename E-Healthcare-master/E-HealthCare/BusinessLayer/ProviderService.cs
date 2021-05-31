using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.BusinessLayer
{
    class ProviderService
    {
        AmbulanceDataAccess ambulanceDataAccess;
        public ProviderService() { 
            this.ambulanceDataAccess = new AmbulanceDataAccess();
        }

        public List<Ambulance> GetAdminVehicleByLoc(string location) {
            return this.ambulanceDataAccess.GetAdminVehicleByLoc(location);
        }
        public List<Ambulance> GetAdminVehicle()
        {
            return this.ambulanceDataAccess.GetAdminVehicle();
        }
        public List<Ambulance> GetProviderVehicle(int userId)
        {
            return this.ambulanceDataAccess.GetProviderVehicle(userId);
        }

        public List<Ambulance> GetProviderRequest(int userId)
        {
            return this.ambulanceDataAccess.GetProviderRequest(userId);
        }

        public int AddNewVehicle(string number, string driver, string location, string phone, float fee, int userId)
        {

            Ambulance ambulance = new Ambulance() { Number = number, Driver = driver, Location = location, Phone = phone, Fee = fee, UserId = userId };
            return this.ambulanceDataAccess.AddVehicel(ambulance);
        }
        public int UpdateVehicle(string name, string location, string phone, int bookerId, int ambulanceId, int booked)
        {

            return this.ambulanceDataAccess.UpdateVehicle(bookerId, name, location, phone, ambulanceId,booked);
        }
    }
}
