using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrderDetailsBL
    {

        public void Insert(OrderDetailsDTO detailsDTO)
        {
            Mapper mapper = new Mapper();
            Order_Detail od = mapper.ToEntity(detailsDTO);
            NorthwindEntities nw = new NorthwindEntities();

            nw.Order_Details.Add(od);
            nw.SaveChanges();
        }
        
    
    }
}
