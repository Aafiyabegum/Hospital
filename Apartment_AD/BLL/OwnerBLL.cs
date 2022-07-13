using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_AD.BLL
{
    //BLL means Business Logic Layer to create the setter and getter to our forms
    class OwnerBLL
    {
        public string Owner_ID { get; set; }
        public string Owner_Name { get; set; }
        public string No_of_members_in_family { get; set; }
        public string Apartment_Units { get; set; }
        public string Apartment_Type { get; set; }
        public int Phone_No { get; set; }
        public string Mail_ID { get; set; }
    }
}
