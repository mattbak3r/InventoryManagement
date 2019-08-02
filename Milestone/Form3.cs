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
    public partial class form_addProduct : Form
    {
        readonly Inventory[] inv;
        public form_addProduct(Inventory[] inventory)
        {
            inv = inventory;
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();
            int _Id = int.Parse(tb_ID.Text);
            string _Model = tb_productModel.Text;
            string _Name = tb_productName.Text;
            string _Picture = tb_productPicture.Text;
            double _Price = double.Parse(tb_productPrice.Text);
            string _Resolution = tb_productScreenResolution.Text;
            double _Size = double.Parse(tb_productScreenSize.Text);
            int _Stock = int.Parse(tb_productStock.Text);
            Inventory product = new Inventory(_Id, _Name, _Model, _Stock, _Price, _Size, _Resolution, _Picture);
            //im.Add(inv, product);
            MessageBox.Show("Product Added.");
        }
    }
}
