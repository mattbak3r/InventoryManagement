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
        public form_edit(Inventory product)
        {
            _product = product;
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
            this.Close();
            MessageBox.Show("Product updated");
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form_viewProducts _form = new form_viewProducts(_product);
            _form.ShowDialog();
        }
    }
}
