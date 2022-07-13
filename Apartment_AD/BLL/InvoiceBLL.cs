using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_AD.BLL
{
    class InvoiceBLL
    {
        public string Invoice_ID { get; set; }
        public string Tenant_ID { get; set; }
        public string Rent_Fee { get; set; }
        public string Maintenance_Fee { get; set; }
        public string Due_Amount { get; set; }

        public string Payment_ID { get; set; }
    }
}
