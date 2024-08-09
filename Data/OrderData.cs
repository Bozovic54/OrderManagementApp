using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class OrderData
    {
        private static OrderData instance;
        public static OrderData Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderData();
                return instance;
            }
        }
        public List<OrderDTO> GetOrders()
        {
            NorthwindEntities nw = new NorthwindEntities();
            List<OrderDTO> l = new List<OrderDTO>();
            var mapper = new Mapper();

            foreach (var a in nw.Orders)
            {
                l.Add(mapper.ToDTO(a));
            }
            return l;
        }

        public List<OrderDTO> GetOrders(string employee, string customer, string product)
        {
            NorthwindEntities nw = new NorthwindEntities();
            List<OrderDTO> l = new List<OrderDTO>();
            var mapper = new Mapper();

            foreach (var a in nw.SearchOrder1(employee, customer, product))
            {
                l.Add(mapper.ToDTO(a));
            }

            return l;
        }

        public OrderDTO GetOrder(int id)
        {
            NorthwindEntities nw = new NorthwindEntities();
            var mapper = new Mapper();
            OrderDTO order = new OrderDTO();

            order = mapper.ToDTO(nw.Orders.Where(x => x.OrderID == id).FirstOrDefault());

            return order;
        }
        public void Delete(int orderID)
        {
            NorthwindEntities nw = new NorthwindEntities();
            {
                var order = nw.Orders
                                    .Include("Order_Details")
                                    .FirstOrDefault(o => o.OrderID == orderID);
                if (order != null)
                {
                    nw.Order_Details.RemoveRange(order.Order_Details);
                    nw.Orders.Remove(order);
                    nw.SaveChanges();
                }
            }
        }
        public List<OrderDetailsDTO> GetOrderDetails(int id)
        {
            NorthwindEntities nw = new NorthwindEntities();
            var mapper = new Mapper();
            List<OrderDetailsDTO> orderDetails = new List<OrderDetailsDTO>();
            OrderDetailsDTO detailsDTO = new OrderDetailsDTO();

            var order = nw.Orders.Where(x => x.OrderID == id).FirstOrDefault();
            return mapper.ToDTO(order.Order_Details.ToList());
            
        }
    }
}
