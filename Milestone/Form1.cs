using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Milestone
{
    public partial class form_products : Form
    {
        Inventory[] inv;
        public form_products()
        {
            InitializeComponent();
        }

        private void Btn_viewProduct_Click(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid product...");
            }
            if (lb_products.SelectedIndex != 0)
            {
                InventoryManager im = new InventoryManager();
                inv = im.Load();
                int index = lb_products.SelectedIndex;
                Inventory product = inv[index - 1];
                form_viewProducts f2 = new form_viewProducts(product);
                f2.ShowDialog(); // Shows Form2
            }
        }

        private void Btn_addNewProduct_Click(object sender, EventArgs e)
        {
            form_addProduct f3 = new form_addProduct();
            f3.ShowDialog();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_removeProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Removed Item");
        }

        private void Form_products_Load(object sender, EventArgs e)
        {
            lb_products.Items.Add("Stock" + "\t" + "Model");
            InventoryManager im = new InventoryManager();
            inv = im.Load();
            for (int x = 0; x < inv.Length; x++) 
            {
                lb_products.Items.Add(inv[x].Stock + "\t" + inv[x].Model);
            }
        }
        public Inventory GetSelection
        {
            get { return (Inventory)lb_products.SelectedItem; }
        }
    }
}
