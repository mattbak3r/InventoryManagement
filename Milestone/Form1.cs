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
        String header = "{0, -10}{1, -20}"; //{1, -10}{2, -10}{3, -20}{4, -20}
        String data = "{0, -10}{1, -20}";  //{1, -10:C}{2, -10}{3, -20}{4, -20}

        public form_products()
        {
            InitializeComponent();
        }

        private void Btn_viewProduct_Click(object sender, EventArgs e)
        {
            form_viewProducts f2 = new form_viewProducts();
            f2.ShowDialog(); // Shows Form2
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
            lb_products.Items.Add("Stock" + "\t" + "Model");  // "Price", "Size", "Resolution", "Brand", 


            try
            {
                String[] input = File.ReadAllLines("inventory.txt");
                int arrayLength = input.Length;
                Inventory[] inv = new Inventory[arrayLength];
                for (int x = 0; x < input.Length; x++)
                {


                    String[] splitInput = input[x].Split(',');
                    int id = int.Parse(splitInput[0]);
                    String name = splitInput[1];
                    String model = splitInput[2];
                    int stock = int.Parse(splitInput[3]);
                    double price = double.Parse(splitInput[4]);
                    double size = double.Parse(splitInput[5]);
                    String rez = splitInput[6];

                    inv[x] = new Inventory(id, name, model, stock, price, size, rez);

                    lb_products.Items.Add(stock + "\t" + model);  // price, size, rez, name, 

                    Console.WriteLine(inv[x].Price);
                }
                lb_products.Items.Add("end of file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
