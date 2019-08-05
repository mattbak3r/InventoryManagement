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
    public partial class form_edit : Form
    {
        Inventory _product;
        Inventory[] _inv;
        public form_edit(Inventory product, Inventory[] inventories)
        {
            _product = product;
            _inv = inventories;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tb_id.Text = _product.Id.ToString();
            tb_brand.Text = _product.Name;
            tb_model.Text = _product.Model;
            tb_stock.Text = _product.Stock.ToString();
            tb_size.Text = _product.Size.ToString();
            tb_resolution.Text = _product.Resolution;
            tb_picture.Text = _product.Picture;
            tb_price.Text = _product.Price.ToString();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            _product.Id = int.Parse(tb_id.Text);
            _product.Name = tb_brand.Text;
            _product.Model = tb_model.Text;
            _product.Stock = int.Parse(tb_stock.Text);
            _product.Size = double.Parse(tb_size.Text);
            _product.Resolution = tb_resolution.Text;
            _product.Picture = tb_picture.Text;
            _product.Price = double.Parse(tb_price.Text);
            InventoryManager im = new InventoryManager();
            im.Save(_inv);
            MessageBox.Show("Product updated");
            this.Hide();
            var _form = new form_products(_inv);
            _form.FormClosed += (x, args) => this.Close();
            _form.Show();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var _form = new form_products(_inv);
            _form.FormClosed += (x, args) => this.Close();
            _form.Show();
        }
    }
}
