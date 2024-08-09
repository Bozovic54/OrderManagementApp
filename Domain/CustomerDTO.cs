using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CustomerDTO
    {
        private string custid;
        private string companyname;
        private string contactname;
        private string contacttitle;
        private string address;
        private string city;
        private string region;
        private string postalcode;
        private string country;
        private string phone;
        private string fax;

        public string CustomerID { get; set; }
        public String Companyname { get; set; }
        public String Contactname { get; set; }
        public String Contacttitle { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String Postalcode { get; set; }
        public String Country { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
    }
}
