using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderDTO
    {
        private int orderid;
        private string customerid;
        private int employeeid;
        private DateTime? orderdate;
        private DateTime? requireddate;
        private DateTime? shippeddate;
        private int shipvia;
        private decimal freight;
        private string shipname;
        private string shipaddress;
        private string shipcity;
        private string shipregion;
        private string shippostalcode;
        private string shipcountry;

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
