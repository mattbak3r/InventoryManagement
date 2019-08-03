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
        List<Inventory> invSearch = new List<Inventory>();
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
                if (invSearch.Count == 0)
                {
                    int index = lb_products.SelectedIndex;
                    Inventory product = inv[index - 1];
                    this.Hide();
                    form_viewProducts f2 = new form_viewProducts(product, inv);
                    f2.FormClosed += (x, args) => this.Close();
                    f2.Show(); // Shows Form2
                }
                else
                {
                    int index = lb_products.SelectedIndex;
                    Inventory product = invSearch[index - 1];
                    this.Hide();
                    form_viewProducts f2 = new form_viewProducts(product, inv);
                    f2.FormClosed += (x, args) => this.Close();
                    f2.Show(); // Shows Form2
                }
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
            DialogResult d = MessageBox.Show("Remove Product?", "", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
            {
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
        }

        private void Form_products_Load(object sender, EventArgs e)
        {
            lb_products.Items.Add("ID" + "\t" + "Stock" + "\t" + "Price" + "\t" + "Name" + "\t" + "Model");
            for (int x = 0; x < inv.Length; x++) 
            {
                lb_products.Items.Add(inv[x].Id + "\t" + inv[x].Stock + "\t" + inv[x].Price.ToString("C2") + "\t" + inv[x].Name + "\t" + inv[x].Model);
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            lb_products.Items.Clear();

            if (rad_brand.Checked)
            {
                lb_products.Items.Add("ID" + "\t" + "Stock" + "\t" + "Price" + "\t" + "Name" + "\t" + "Model");
                try
                {
                    String searchPhrase = tb_searchBar.Text.ToLower();
                    invSearch.Clear();

                    for (int i = 0; i < inv.Length; i++)
                    {
                        if (inv[i].Name.ToLower().Contains(searchPhrase))
                        {
                            invSearch.Add(inv[i]);
                            //lb_products.Items.Add(inv[i].Id + "\t" + inv[i].Stock + "\t" + inv[i].Price + "\t" + inv[i].Name + "\t" + inv[i].Model);
                        }
                    }
                    for (int k = 0; k < invSearch.Count; k++)
                    {
                        lb_products.Items.Add(invSearch[k].Id + "\t" + invSearch[k].Stock + "\t" + invSearch[k].Price.ToString("C2") + "\t" + invSearch[k].Name + "\t" + invSearch[k].Model);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            if (rad_model.Checked)
            {
                lb_products.Items.Add("ID" + "\t" + "Stock" + "\t" + "Price" + "\t" + "Name" + "\t" + "Model");
                invSearch.Clear();

                try
                {
                    String searchPhrase = tb_searchBar.Text.ToLower();

                    for (int i = 0; i < inv.Length; i++)
                    {
                        if (inv[i].Model.ToLower().Contains(searchPhrase))
                        {
                            invSearch.Add(inv[i]);
                            //lb_products.Items.Add(inv[i].Id + "\t" + inv[i].Stock + "\t" + inv[i].Price + "\t" + inv[i].Name + "\t" + inv[i].Model);
                        }
                    }
                    for (int k = 0; k < invSearch.Count; k++)
                    {
                        lb_products.Items.Add(invSearch[k].Id + "\t" + invSearch[k].Stock + "\t" + invSearch[k].Price.ToString("C2") + "\t" + invSearch[k].Name + "\t" + invSearch[k].Model);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (rad_price.Checked)
            {
                lb_products.Items.Add("ID" + "\t" + "Stock" + "\t" + "Price" + "\t" + "Name" + "\t" + "Model");
                invSearch.Clear();

                try
                {
                    double searchPrice = double.Parse(tb_searchBar.Text);

                    for (int i = 0; i < inv.Length; i++)
                    {
                        if (inv[i].Price > searchPrice - 100 && inv[i].Price < searchPrice + 100)
                        {
                            invSearch.Add(inv[i]);
                            //lb_products.Items.Add(inv[i].Id + "\t" + inv[i].Stock + "\t" + inv[i].Price + "\t" + inv[i].Name + "\t" + inv[i].Model);
                        }
                    }
                    for (int k = 0; k < invSearch.Count; k++)
                    {
                        lb_products.Items.Add(invSearch[k].Id + "\t" + invSearch[k].Stock + "\t" + invSearch[k].Price.ToString("C2") + "\t" + invSearch[k].Name + "\t" + invSearch[k].Model);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            lb_products.Items.Clear();
            invSearch.Clear();
            lb_products.Items.Add("ID" + "\t" + "Stock" + "\t" + "Price" + "\t" + "Name" + "\t" + "Model");
            for (int x = 0; x < inv.Length; x++)
            {
                lb_products.Items.Add(inv[x].Id + "\t" + inv[x].Stock + "\t" + inv[x].Price.ToString("C2") + "\t" + inv[x].Name + "\t" + inv[x].Model);
            }
        }

        private void Btn_orderProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f5 = new form_order(inv);
            f5.FormClosed += (s, args) => this.Close();
            f5.Show();
        }
    }
}
