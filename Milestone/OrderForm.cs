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
    public partial class form_order : Form
    {
        Inventory[] inv;
        List<Inventory> order = new List<Inventory>();
        double totalPrice = 0;
        public form_order(Inventory[] inventories)
        {
            inv = inventories;
            InitializeComponent();
        }

        //Adds the Inventory Array to list box for user to select and order
        private void Form_order_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < inv.Length; i++)
            {
                lb_allProducts.Items.Add(inv[i]);
            }
        }

        //Clears the order list box
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            lb_orderedProducts.Items.Clear();
            order.Clear();
            totalPrice = 0;
        }

        //Adds selected item to new order listbox (add more than one to order more than one of the same product)
        private void Btn_add_Click(object sender, EventArgs e)
        {
            int index = lb_allProducts.SelectedIndex;
            if (index >= 0)
            {
                Inventory product = inv[index];
                lb_orderedProducts.Items.Add(product);
                order.Add(product);
                totalPrice += product.Price;
                lab_price.Text = totalPrice.ToString("C2");
            }
        }

        //Remove selected product from order listbox
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            int index = lb_orderedProducts.SelectedIndex;
            if (index >= 0)
            {
                Inventory product = order[index];
                lb_orderedProducts.Items.RemoveAt(index);
                order.Remove(product);
                totalPrice -= product.Price;
                lab_price.Text = totalPrice.ToString("C2");
            }
        }

        //Orders the product in the order list box
        private void Btn_order_Click(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();
            for (int i = 0; i < order.Count; i++)
            {
                order[i].Stock = order[i].Stock + 1;
            }
            im.SaveOrder(order);
            im.Save(inv);
            MessageBox.Show("Products Ordered for " + totalPrice.ToString("C2"));
            this.Hide();
            var f1 = new form_products(inv);
            f1.FormClosed += (x, args) => this.Close();
            f1.Show();
        }

        //Cancels the order
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new form_products(inv);
            f1.FormClosed += (x, args) => this.Close();
            f1.Show();
        }
    }
}
