using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EmployeesData
    {
        private static EmployeesData instance;
        public static EmployeesData Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeesData();
                return instance;
            }
        }
        public List<EmployeeDTO> GetEmployees()
        {
            List<EmployeeDTO> l = new List<EmployeeDTO>();       
            NorthwindEntities nw = new NorthwindEntities();
            Mapper mapper = new Mapper();

            foreach(var a in nw.Employees)
            {
                l.Add(mapper.ToDTO(a));
            }
            return l;
        }
    }
}
