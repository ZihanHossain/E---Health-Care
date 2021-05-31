using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer.Entity
{
    public class Medicine
    {
        public string MedicineName { get; set; }
        public string Comment { get; set; }
        public override string ToString()
        {
            return string.Format("Medicines:\n\tMedicine Name: {0}, Comment: {1}", MedicineName, Comment);
        }
    }
}
