using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class CustomerData
    {
        private static CustomerData instance;
        public static CustomerData Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerData();
                return instance;
            }
        }
        public List<CustomerDTO> GetCustomers()
        {
            List<CustomerDTO> l = new List<CustomerDTO>();
            NorthwindEntities nw = new NorthwindEntities();
            Mapper mapper = new Mapper();

            foreach(var a in nw.Customers)
            {
                l.Add(mapper.ToDTO(a));
            }

            return l;
        }
    }
}
