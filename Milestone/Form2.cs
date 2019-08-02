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
    public partial class form_viewProducts : Form
    {
        
        private Inventory _product;
        private Inventory[] _inv;

        public form_viewProducts(Inventory product, Inventory[] inventories)
        {
            _product = product;
            _inv = inventories;
            InitializeComponent();
        }

        private void Form_viewProducts_Load(object sender, EventArgs e)
        {
            pb_productPicture.Image = Image.FromFile("../../Images/" + _product.Picture);
            lb_productName.Text = _product.Name;
            lb_productPrice.Text = _product.Price.ToString("C2");
            lb_productScreenResolution.Text = _product.Resolution;
            lb_productScreenSize.Text = _product.Size.ToString();
            lb_productStock.Text = _product.Stock.ToString();
            lb_productID.Text = _product.Id.ToString();
            lb_productModel.Text = _product.Model;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new form_products(_inv);
            f1.FormClosed += (x, args) => this.Close();
            f1.Show();
        }

        private void Btn_order_Click(object sender, EventArgs e)
        {

        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var _formEdit = new form_edit(_product, _inv);
            _formEdit.FormClosed += (x, args) => this.Close();
            _formEdit.Show();
        }
    }
}
