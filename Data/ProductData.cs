using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class ProductData
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

        public List<ProductDTO> GetProducts()
        {
            NorthwindEntities nw = new NorthwindEntities();
            Mapper mapper = new Mapper();
            List<ProductDTO> l = new List<ProductDTO>();
            foreach (var a in nw.Products)
            {
                l.Add(mapper.ToDTO(a));
            }

            return l;
        }
        public Decimal? GetPrice(int id)
        {
            NorthwindEntities nw = new NorthwindEntities();
            Mapper mapper = new Mapper();

            var prod = nw.Products.FirstOrDefault(x => x.ProductID == id);
            ProductDTO prodDTO = mapper.ToDTO(prod);


            return prodDTO.UnitPrice;
        }
    }
}
