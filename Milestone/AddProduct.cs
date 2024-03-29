﻿using System;
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
    public partial class form_addProduct : Form
    {
        List<Inventory> inv;
        int id;
        public form_addProduct(List<Inventory> inventory)
        {
            inv = inventory;
            InitializeComponent();
        }

        //Goes back to main form
        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new form_products(inv);
            f1.FormClosed += (x, args) => this.Close();
            f1.Show();
        }

        //Takes information provided and builds a new Inventory object, then saves it into the Inventory array
        private void Btn_add_Click(object sender, EventArgs e)
        {
            InventoryManager im = new InventoryManager();
            string _Model = tb_productModel.Text;
            string _Name = tb_productName.Text;
            string _Picture = tb_productPicture.Text;
            double _Price = double.Parse(tb_productPrice.Text);
            string _Resolution = tb_productScreenResolution.Text;
            double _Size = double.Parse(tb_productScreenSize.Text);
            int _Stock = int.Parse(tb_productStock.Text);
            Inventory product = new Inventory(id, _Name, _Model, _Stock, _Price, _Size, _Resolution, _Picture);
            //inv = im.Add(inv, product);
            inv = im.AddToList(inv, product);
            im.Save(inv);
            MessageBox.Show("Product Added.");
            this.Hide();
            var f1 = new form_products(inv);
            f1.FormClosed += (x, args) => this.Close();
            f1.Show();
        }

        //Finds the next available ID number, to assign new product an ID not being used
        private void Form_addProduct_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < inv.Count; i++)
            {
                if (inv[i].Id != i + 1)
                {
                    id = i + 1;
                    break;
                }
                else
                {
                    id = inv.Count + 1;
                }
            }
            tb_ID.Text = id.ToString();
        }
        
        //Uploads a picture, then saves a copy of it into Images file
        private void Btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.png;)| *.jpg; *.png;"
            };
            if (o.ShowDialog() == DialogResult.OK)
            {
                tb_productPicture.Text = Path.GetFileName(o.FileName);
                String file = "../../Images/" + Path.GetFileName(o.FileName);
                pb_image.Image = new Bitmap(o.FileName);
                if (!File.Exists(file))
                {
                    File.Copy(o.FileName, Path.Combine("../../Images/", Path.GetFileName(tb_productPicture.Text)), true);
                }
            }
        }
    }
}
