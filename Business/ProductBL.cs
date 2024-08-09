using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class ProductBL
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
        ProductData productData = new ProductData();
        public List<ProductDTO> GetProducts()
        { 
            List<ProductDTO> l = new List<ProductDTO>();
            l = productData.GetProducts();

            return l;
        }
        public Decimal? GetPrice(int id)
        {
            decimal price = (decimal)productData.GetPrice(id);
            return price;

        }
    }
}
