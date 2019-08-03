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
    public partial class form_products : Form
    {
        static Inventory[] inv = InventoryManager.Load();
        String searchPhrase;
        public form_products(Inventory[] _inv)
        {
            if (_inv.Length == 0)
            {
                _inv = inv;
            }
            else
            {
                inv = _inv;
            }
            InitializeComponent();
        }

        private void Btn_viewProduct_Click(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid product...");
            }
            if (lb_products.SelectedIndex > 0)
            {
                int index = lb_products.SelectedIndex;
                Inventory product = inv[index - 1];
                this.Hide();
                form_viewProducts f2 = new form_viewProducts(product, inv);
                f2.FormClosed += (x, args) => this.Close();
                f2.Show(); // Shows Form2
            }
        }

        private void Btn_addNewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_addProduct f3 = new form_addProduct(inv);
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();
            im.Save(inv);
            this.Close();
        }

        private void Btn_removeProduct_Click(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();

            if (lb_products.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid product...");
            }
            if (lb_products.SelectedIndex != 0)
            {
                int index = lb_products.SelectedIndex - 1;
                Inventory product = inv[index];
                lb_products.Items.Remove(lb_products.SelectedItem);
                inv = im.Remove(inv, index);
                lb_products.Refresh();
                im.Remove(product);
            }
            MessageBox.Show("Removed Item");
        }

        private void Form_products_Load(object sender, EventArgs e)
        {
            lb_products.Items.Add("Stock" + "\t" + "Model");
            for (int x = 0; x < inv.Length; x++) 
            {
                lb_products.Items.Add(inv[x].Stock + "\t" + inv[x].Model);
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            

            if (rad_brand.Enabled)
            {
                try
                {
                    String searchPhrase = tb_searchBar.Text.ToLower();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                for (int i = 0; i < inv.Length; i++)
                {
                    if (searchPhrase == inv[i].Name.ToLower())
                    {

                    }
                }
            }
        }
    }
}
