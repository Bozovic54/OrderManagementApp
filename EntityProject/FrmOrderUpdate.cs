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
    public partial class FrmOrderUpdate : Form
    {
        public OrderDTO order = new OrderDTO();
        public List<OrderDetailsDTO> orderDetails = new List<OrderDetailsDTO>();
        public OrderBL orderBL = new OrderBL();
        public FrmOrderUpdate()
        {
            InitializeComponent();
        }

        private void FrmOrderUpdate_Load(object sender, EventArgs e)
        {
            txtCustomer.Text = order.CustomerID.ToString();
            txtEmployee.Text = order.EmployeeID.ToString();
            txtDate.Text = order.OrderDate.ToString();
            txtShipVia.Text = order.ShipVia.ToString();
            txtFreight.Text = order.Freight.ToString();
            if (order.ShipRegion == null)
                txtShipRegion.Text = "NULL";
            else
                txtShipRegion.Text = order.ShipRegion.ToString();
            txtShipName.Text = order.ShipName.ToString();
            txtShipAddress.Text = order.ShipAddress.ToString();
            txtCity.Text = order.ShipCity.ToString();
            txtPostalCode.Text = order.ShipPostalCode.ToString();
            txtCountry.Text = order.ShipCountry.ToString();
            
            dgvOrderDetails.DataSource = orderDetails;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            order.CustomerID = txtCustomer.Text;
            order.EmployeeID = Int32.Parse(txtEmployee.Text);
            order.OrderDate = DateTime.Parse(txtDate.Text);
            order.ShipVia = Int32.Parse(txtShipVia.Text);
            order.Freight = Decimal.Parse(txtFreight.Text);
            order.ShipRegion = txtShipRegion.Text == "NULL" ? null : txtShipRegion.Text;
            order.ShipName = txtShipName.Text;
            order.ShipAddress = txtShipAddress.Text;
            order.ShipCity = txtCity.Text;
            order.ShipPostalCode = txtPostalCode.Text;
            order.ShipCountry = txtCountry.Text;

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                OrderDetailsDTO detail = new OrderDetailsDTO
                {
                    OrderID = int.Parse(row.Cells["OrderID"].Value.ToString()),
                    ProductID = int.Parse(row.Cells["ProductID"].Value.ToString()),
                    UnitPrice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
                    Quantity = short.Parse(row.Cells["Quantity"].Value.ToString()),
                    Discount = float.Parse(row.Cells["Discount"].Value.ToString())
                };

                orderDetails.Add(detail);
            }

            orderBL.Save(order, orderDetails);
            MessageBox.Show("Success");
            this.Close();
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
