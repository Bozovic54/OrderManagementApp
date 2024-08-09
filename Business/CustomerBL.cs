using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class CustomerBL
    {
        private static CustomerBL instance;
        public static CustomerBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBL();
                return instance;
            }
        }
        CustomerData cust = new CustomerData();
        public List<CustomerDTO> GetCustomers()
        {
            List<CustomerDTO> l = new List<CustomerDTO>();
            l = cust.GetCustomers();

            return l;
        }
    }
}
