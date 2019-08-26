using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class ViewOrder : Form
    {
        String order;

        public ViewOrder(String orderSelected)
        {
            order = orderSelected;
            InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();
            var orderList = im.ViewOrder(order);
            foreach (Inventory product in orderList)
            {
                lb_orderList.Items.Add(product);
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
