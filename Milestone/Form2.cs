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
        form_products f1;
        public form_viewProducts()
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void Form_viewProducts_Load(object sender, EventArgs e)
        {
            Inventory itemSelected = this.f1.GetSelection;
            lb_name.Text = itemSelected.Name;
            lb_productPrice.Text = itemSelected.Price.ToString();
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
