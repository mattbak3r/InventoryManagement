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
        public form_viewProducts(Inventory product)
        {
            _product = product;
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_order_Click(object sender, EventArgs e)
        {

        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
