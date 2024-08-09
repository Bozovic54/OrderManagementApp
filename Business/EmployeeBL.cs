using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class EmployeeBL
    {
        private static EmployeeBL instance;
        public static EmployeeBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeBL();
                return instance;
            }
        }
        EmployeesData employee = new EmployeesData();

        public List<EmployeeDTO> GetEmployees()
        {
            List<EmployeeDTO>l = new List<EmployeeDTO>();
            l = employee.GetEmployees();

            return l;
        }

        
    }
}
