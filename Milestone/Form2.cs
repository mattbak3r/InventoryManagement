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
        private List<Inventory> _inv;

        public form_viewProducts(Inventory product, List<Inventory> inventories)
        {
            _product = product;
            _inv = inventories;
            InitializeComponent();
        }

        //Loads all information to text lables, and shows a picture of the product
        private void Form_viewProducts_Load(object sender, EventArgs e)
        {
            try { pb_productPicture.Image = Image.FromFile("../../Images/" + _product.Picture); } catch (Exception) { MessageBox.Show("Invalid picture, please edit product"); }
            
            lb_productName.Text = _product.Name;
            lb_productPrice.Text = _product.Price.ToString("C2");
            lb_productScreenResolution.Text = _product.Resolution;
            lb_productScreenSize.Text = _product.Size.ToString();
            lb_productStock.Text = _product.Stock.ToString();
            lb_productID.Text = _product.Id.ToString();
            lb_productModel.Text = _product.Model;
        }

        //Goes back to last form
        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new form_products(_inv);
            f1.FormClosed += (x, args) => this.Close();
            f1.Show();
        }

        //Opens a new form that allows the user to edit the product
        private void Btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var _formEdit = new form_edit(_product, _inv);
            _formEdit.FormClosed += (x, args) => this.Close();
            _formEdit.Show();
        }
    }
}
