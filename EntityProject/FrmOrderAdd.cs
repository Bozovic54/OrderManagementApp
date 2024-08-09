using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class FrmOrderAdd : Form
    {
        public FrmOrderAdd()
        {
            InitializeComponent();
        }
        List<OrderDetailsDTO> listOrderDetails = new List<OrderDetailsDTO>();
        OrderDTO order = new OrderDTO();
        ProductBL prod = new ProductBL();
        private void FrmOrderAdd_Load(object sender, EventArgs e)
        {
            
            EmployeeBL emp = new EmployeeBL();
            cmbEmployee.DataSource = emp.GetEmployees();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Empid";

            CustomerBL cust = new CustomerBL();
            cmbCustomer.DataSource = cust.GetCustomers();
            cmbCustomer.DisplayMember = "Companyname";
            cmbCustomer.ValueMember = "CustomerID";

            ProductBL prod = new ProductBL();
            cmbProduct.DataSource = prod.GetProducts();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";

            txtDate.Text = System.DateTime.Now.ToString();
            txtPrice.Text = "";
            txtQuantity.Text = "";
            cmbProduct.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            btnAddDetails.Enabled = false;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            order.EmployeeID = (Int32)cmbEmployee.SelectedValue;
            order.CustomerID = cmbCustomer.SelectedValue.ToString();
            order.OrderDate = DateTime.Parse(txtDate.Text);


            cmbProduct.Enabled = true;
            txtPrice.Enabled = true;
            txtQuantity.Enabled = true;
            btnAddDetails.Enabled = true;

            cmbCustomer.Enabled = false;
            cmbEmployee.Enabled = false;
            txtDate.Enabled = false;
            btnAddOrder.Enabled = false;
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            OrderDetailsDTO orderDetails = new OrderDetailsDTO();

            try
            {
                orderDetails.ProductID = (Int32)cmbProduct.SelectedValue;
                orderDetails.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                orderDetails.Quantity = Convert.ToInt16(txtQuantity.Text);

                listOrderDetails.Add(orderDetails);

                dgwOrderDetails.DataSource = null;
                dgwOrderDetails.DataSource = listOrderDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed\r\n\r\n" + ex.Message);

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OrderBL orderBL = new OrderBL();
            OrderDetailsBL orderDetails = new OrderDetailsBL();
            int ID = orderBL.Insert(order);
            try
            {
                
                foreach(OrderDetailsDTO odDTO in listOrderDetails)
                {
                    odDTO.OrderID = ID;
                    orderDetails.Insert(odDTO);
                }

                order = new OrderDTO();
                listOrderDetails = new List<OrderDetailsDTO>();
                dgwOrderDetails.DataSource = null;

                txtPrice.Text = "";
                txtQuantity.Text = "";
                cmbProduct.Enabled = false;
                txtPrice.Enabled = false;
                txtQuantity.Enabled = false;

                MessageBox.Show("Order inserted!");
                this.Close();

            }
            catch (Exception ex)
            { 
                MessageBox.Show("Insert failed\r\n\r\n" + ex.Message);

                orderBL.Delete(ID);
            }

        }
    }
}
