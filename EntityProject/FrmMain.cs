using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;


namespace EntityProject
{
    public partial class FrmMain : Form
    {
        OrderBL orderBL = OrderBL.Instance;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwOrders.DataSource = orderBL.GetOrders();
            cbmSearch.SelectedIndex = 0;

            btnOrderDetails.Enabled = false;
            btnDelete.Enabled = false;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string employee = "";
            string customer = ""; 
            string product = "";
            if (cbmSearch.SelectedItem.ToString().Equals("Employee"))
            {
                employee = txtSearch.Text;
                
            }
            else if (cbmSearch.SelectedItem.ToString().Equals("Customer"))
            {
                customer = txtSearch.Text;
            }
            else if (cbmSearch.SelectedItem.ToString().Equals("Product"))
            {
                product = txtSearch.Text;
            }
            
            
            dgwOrders.DataSource = orderBL.GetOrders(employee, customer , product);
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {       
            FrmOrderDetails frm = new FrmOrderDetails();

            string id = dgwOrders.SelectedRows[0].Cells[0].Value.ToString();
            int i;
            Int32.TryParse(id, out i);
            frm.order = orderBL.GetOrder(i);
            frm.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmOrderAdd frm = new FrmOrderAdd();
            frm.ShowDialog();
            dgwOrders.DataSource = orderBL.GetOrders();
        }

        private void dgwOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmOrderUpdate frm = new FrmOrderUpdate();
            string id = dgwOrders.SelectedRows[0].Cells[0].Value.ToString();
            int i;
            Int32.TryParse(id, out i);
            frm.order = orderBL.GetOrder(i);
            frm.orderDetails = orderBL.GetOrderDetails(i);
            frm.ShowDialog();

            dgwOrders.DataSource = orderBL.GetOrders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this order?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string id = dgwOrders.SelectedRows[0].Cells[0].Value.ToString();
                int i;
                Int32.TryParse(id, out i);
                orderBL.Delete(i);

                dgwOrders.DataSource = orderBL.GetOrders();
            }            
        }

        private void dgwOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOrderDetails.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
