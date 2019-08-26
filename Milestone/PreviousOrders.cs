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
    public partial class PreviousOrders : Form
    {
        public PreviousOrders()
        {
            InitializeComponent();
        }

        private void Btn_viewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedOrder = lb_allOrders.SelectedItem.ToString();
                var vo = new ViewOrder(selectedOrder);
                vo.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please pick an order to view...");
            }
        }

        private void PreviousOrders_Load(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();
            var previousOrders = im.ViewAllOrders();

            foreach (String orders in previousOrders)
            {
                lb_allOrders.Items.Add(orders);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
