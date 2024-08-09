using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Domain;

namespace Data
{
    public class Mapper
    {
        public CustomerDTO ToDTO(Customer c)
        {
            try
            {
                CustomerDTO dto = new CustomerDTO();
                dto.CustomerID = c.CustomerID;
                dto.Contactname = c.ContactName;
                dto.Companyname = c.CompanyName;
                dto.Address = c.Address;
                dto.City = c.City;
                dto.Region = c.Region;
                dto.Phone = c.Phone;
                dto.Country = c.Country;
                dto.Postalcode = c.PostalCode;
                dto.Fax = c.Fax;
                dto.Contacttitle = c.ContactTitle;

                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping CustomerDTO to Entity: " + ex.Message);
            }
        }
        public Customer ToEntity(CustomerDTO dto)
        {
            try
            {
                Customer c = new Customer();
                c.CustomerID = dto.CustomerID;
                c.ContactName = dto.Contactname;
                c.Address = dto.Address;
                c.City = dto.City;
                c.Region = dto.Region;
                c.Phone = dto.Phone;
                c.Country = dto.Country;
                c.PostalCode = dto.Postalcode;
                c.Fax = dto.Fax;
                c.ContactTitle = dto.Contacttitle;

                return c;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping Customer to CustomerDTO: " + ex.Message);
            }
        }
        public OrderDTO ToDTO(Order c)
        {
            try
            {
                OrderDTO dto = new OrderDTO();
                dto.OrderID = c.OrderID;
                dto.CustomerID = c.CustomerID;
                dto.EmployeeID = c.EmployeeID;
                dto.ShipAddress = c.ShipAddress;
                dto.ShipCity = c.ShipCity;
                dto.ShipRegion = c.ShipRegion;
                dto.ShipCountry = c.ShipCountry;
                dto.ShipVia = c.ShipVia;
                dto.ShipName = c.ShipName;
                dto.Freight = c.Freight;
                dto.OrderDate = c.OrderDate;
                dto.RequiredDate = c.RequiredDate;
                dto.ShippedDate = c.ShippedDate;
                dto.ShipPostalCode = c.ShipPostalCode;
                
                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping Order to OrderDTO: " + ex.Message);
            }
        }
        public Order ToEntity(OrderDTO dto)
        {
            try
            {
                Order o = new Order();
                o.OrderID = dto.OrderID;
                o.CustomerID = dto.CustomerID;
                o.EmployeeID = dto.EmployeeID;
                o.ShipAddress = dto.ShipAddress;
                o.ShipCity = dto.ShipCity;
                o.ShipRegion = dto.ShipRegion;
                o.ShipCountry = dto.ShipCountry;
                o.ShipVia = dto.ShipVia;
                o.ShipName = dto.ShipName;
                o.Freight = dto.Freight;
                o.OrderDate = dto.OrderDate;
                o.RequiredDate = dto.RequiredDate;
                o.ShippedDate = dto.ShippedDate;
                o.ShipPostalCode = dto.ShipPostalCode;

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping OrderDTO to Order: " + ex.Message);
            }
        }
        public EmployeeDTO ToDTO(Employee c)
        {
            try
            {
                EmployeeDTO dto = new EmployeeDTO();
                dto.Empid = c.EmployeeID;
                dto.Firstname = c.FirstName;
                dto.Lastname = c.LastName;
                dto.Title = c.Title;
                dto.Titleofcourtesy = c.TitleOfCourtesy;
                dto.Hiredate = c.HireDate;
                dto.Birthdate = c.BirthDate;
                dto.Postalcode = c.PostalCode;
                dto.Country = c.Country;
                dto.City = c.City;
                dto.Region = c.Region;
                dto.Address = c.Address;
                dto.Phone = c.HomePhone;
                dto.Postalcode = c.PostalCode;
                dto.Extension = c.Extension;
                dto.Notes = c.Notes;
                dto.PhotoPath = c.PhotoPath;

                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping Employee to EmployeeDTO: " + ex.Message);
            }
        }
        public ProductDTO ToDTO(Product c)
        {
            try
            {
                ProductDTO dto = new ProductDTO();
                dto.ProductID = c.ProductID;
                dto.ProductName = c.ProductName;    
                dto.UnitsOnOrder = c.UnitsOnOrder;
                dto.UnitPrice = c.UnitPrice;
                dto.Discontinued = c.Discontinued;
                dto.QuantityPerUnit = c.QuantityPerUnit;
                dto.ReorderLevel = c.ReorderLevel;
                dto.UnitsInStock = c.UnitsInStock;

                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping Product to ProductDTO: " + ex.Message);
            }
        }
        public List<OrderDetailsDTO> ToDTO(List<Order_Detail> details)
        {
            try
            {
                List<OrderDetailsDTO> l = new List<OrderDetailsDTO>();
                foreach (var a in details)
                {
                    OrderDetailsDTO dto = new OrderDetailsDTO();
                    {
                        dto.OrderID = a.OrderID;
                        dto.ProductID = a.ProductID;
                        dto.UnitPrice = a.UnitPrice;
                        dto.Quantity = a.Quantity;
                        dto.Discount = a.Discount;
                    }
                    l.Add(dto);
                }
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping ListOrderDetails to OrderDetailsDTO: " + ex.Message);
            }
            
        }
        public Order_Detail ToEntity(OrderDetailsDTO details)
        {
            try
            {
                Order_Detail od = new Order_Detail();

                od.OrderID = details.OrderID;
                od.ProductID = details.ProductID;
                od.UnitPrice = details.UnitPrice;
                od.Quantity = details.Quantity;

                return od;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mapping OrderDetailsDTO to Order_Details: " + ex.Message);
            }

        }

    }
}
