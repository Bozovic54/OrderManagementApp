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
    public partial class FrmOrderDetails : Form
    {
        public OrderDTO order;
        OrderBL orderBL = new OrderBL();
        public FrmOrderDetails()
        {
            InitializeComponent();
        }

        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {
            dgwOrderDetails.DataSource = orderBL.GetOrderDetails(order.OrderID);
            string id = order.OrderID.ToString();   
            textBox1.Text = id;

        }
    }
}
