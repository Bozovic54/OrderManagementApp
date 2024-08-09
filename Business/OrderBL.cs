using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Business
{
    public class OrderBL
    {
        private static OrderBL instance;
        public static OrderBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderBL();
                return instance;
            }
        }

        OrderData order = new OrderData();
        public List<OrderDTO> GetOrders()
        {
            List<OrderDTO> l = new List<OrderDTO>();
            l = order.GetOrders();

            return l;
        }

        public List<OrderDTO> GetOrders(string employee,string customer, string product)
        {

            List<OrderDTO> l = new List<OrderDTO>();
            l = order.GetOrders(employee,customer,product);
            
            return l;
        }

        public OrderDTO GetOrder(int id)
        { 
            OrderDTO orderDTO = new OrderDTO();

            orderDTO = order.GetOrder(id);
            
            return orderDTO;
        }

        public List<OrderDetailsDTO> GetOrderDetails(int id)
        {

            OrderDetailsDTO detailsDTO = new OrderDetailsDTO();

            return order.GetOrderDetails(id);
        }
        public int Insert(OrderDTO oDTO)
        {
            Mapper mapper = new Mapper();
            NorthwindEntities nw = new NorthwindEntities();
            Order o = mapper.ToEntity(oDTO);

            nw.Orders.Add(o);
            nw.SaveChanges();

            return o.OrderID;
        }
        public void Delete(int id)
        {
            order.Delete(id);
        }
        public void Save(OrderDTO oDTO, List<OrderDetailsDTO> odDTO)
        {
            NorthwindEntities nw = new NorthwindEntities();

            Order order = nw.Orders.FirstOrDefault(x => x.OrderID == oDTO.OrderID);
            order.OrderID = oDTO.OrderID;
            order.CustomerID = oDTO.CustomerID;
            order.EmployeeID= oDTO.EmployeeID;
            order.OrderDate = oDTO.OrderDate;
            order.ShipVia = oDTO.ShipVia;
            order.Freight = oDTO.Freight;
            order.ShipRegion = oDTO.ShipRegion;
            order.ShipName = oDTO.ShipName;
            order.ShipAddress = oDTO.ShipAddress;
            order.ShipCity = oDTO.ShipCity;
            order.ShipPostalCode = oDTO.ShipPostalCode;
            order.ShipCountry = oDTO.ShipCountry;

            List<OrderDetailsDTO> order_Detail = new List<OrderDetailsDTO>();
            foreach(OrderDetailsDTO odDTT in order_Detail)
            {
                var orderDetail = nw.Order_Details.FirstOrDefault(od => od.OrderID == odDTT.OrderID && od.ProductID == odDTT.ProductID);
                orderDetail.ProductID = odDTT.ProductID;
                orderDetail.UnitPrice = odDTT.UnitPrice;
                orderDetail.Quantity = odDTT.Quantity;
                orderDetail.Discount = odDTT.Discount;
            }
            

            OrderBL orderBL = new OrderBL();
            nw.SaveChanges();
        }
    }
}
