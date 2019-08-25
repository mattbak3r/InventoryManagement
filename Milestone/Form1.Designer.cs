namespace Milestone
{
    partial class form_products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_products = new System.Windows.Forms.ListBox();
            this.tb_searchBar = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_addNewProduct = new System.Windows.Forms.Button();
            this.btn_viewProduct = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_brand = new System.Windows.Forms.RadioButton();
            this.rad_model = new System.Windows.Forms.RadioButton();
            this.rad_price = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_orderProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_products
            // 
            this.lb_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_products.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_products.FormattingEnabled = true;
            this.lb_products.ItemHeight = 19;
            this.lb_products.Location = new System.Drawing.Point(5, 89);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(534, 308);
            this.lb_products.TabIndex = 0;
            // 
            // tb_searchBar
            // 
            this.tb_searchBar.Location = new System.Drawing.Point(6, 32);
            this.tb_searchBar.Name = "tb_searchBar";
            this.tb_searchBar.Size = new System.Drawing.Size(85, 20);
            this.tb_searchBar.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(7, 127);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_addNewProduct
            // 
            this.btn_addNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addNewProduct.Location = new System.Drawing.Point(549, 284);
            this.btn_addNewProduct.Name = "btn_addNewProduct";
            this.btn_addNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addNewProduct.TabIndex = 3;
            this.btn_addNewProduct.Text = "Add New Product";
            this.btn_addNewProduct.UseVisualStyleBackColor = true;
            this.btn_addNewProduct.Click += new System.EventHandler(this.Btn_addNewProduct_Click);
            // 
            // btn_viewProduct
            // 
            this.btn_viewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_viewProduct.Location = new System.Drawing.Point(549, 345);
            this.btn_viewProduct.Name = "btn_viewProduct";
            this.btn_viewProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_viewProduct.TabIndex = 4;
            this.btn_viewProduct.Text = "View Product";
            this.btn_viewProduct.UseVisualStyleBackColor = true;
            this.btn_viewProduct.Click += new System.EventHandler(this.Btn_viewProduct_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removeProduct.Location = new System.Drawing.Point(549, 314);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_removeProduct.TabIndex = 5;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.Btn_removeProduct_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(549, 374);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Save / Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory for Monitor Products";
            // 
            // rad_brand
            // 
            this.rad_brand.AutoSize = true;
            this.rad_brand.Location = new System.Drawing.Point(7, 58);
            this.rad_brand.Name = "rad_brand";
            this.rad_brand.Size = new System.Drawing.Size(53, 17);
            this.rad_brand.TabIndex = 8;
            this.rad_brand.TabStop = true;
            this.rad_brand.Text = "Brand";
            this.rad_brand.UseVisualStyleBackColor = true;
            // 
            // rad_model
            // 
            this.rad_model.AutoSize = true;
            this.rad_model.Location = new System.Drawing.Point(6, 81);
            this.rad_model.Name = "rad_model";
            this.rad_model.Size = new System.Drawing.Size(54, 17);
            this.rad_model.TabIndex = 8;
            this.rad_model.TabStop = true;
            this.rad_model.Text = "Model";
            this.rad_model.UseVisualStyleBackColor = true;
            // 
            // rad_price
            // 
            this.rad_price.AutoSize = true;
            this.rad_price.Location = new System.Drawing.Point(6, 104);
            this.rad_price.Name = "rad_price";
            this.rad_price.Size = new System.Drawing.Size(49, 17);
            this.rad_price.TabIndex = 8;
            this.rad_price.TabStop = true;
            this.rad_price.Text = "Price";
            this.rad_price.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_searchBar);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.rad_price);
            this.groupBox1.Controls.Add(this.rad_brand);
            this.groupBox1.Controls.Add(this.rad_model);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(548, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 157);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Products";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.Location = new System.Drawing.Point(548, 40);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(27, 23);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "R";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_orderProduct
            // 
            this.btn_orderProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orderProduct.Location = new System.Drawing.Point(549, 257);
            this.btn_orderProduct.Name = "btn_orderProduct";
            this.btn_orderProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_orderProduct.TabIndex = 12;
            this.btn_orderProduct.Text = "Order";
            this.btn_orderProduct.UseVisualStyleBackColor = true;
            this.btn_orderProduct.Click += new System.EventHandler(this.Btn_orderProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_orderProduct);
            this.groupBox2.Controls.Add(this.lb_products);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_addNewProduct);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btn_viewProduct);
            this.groupBox2.Controls.Add(this.btn_removeProduct);
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 413);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // form_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(679, 448);
            this.Controls.Add(this.groupBox2);
            this.Name = "form_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.Form_products_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_products;
        private System.Windows.Forms.TextBox tb_searchBar;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_addNewProduct;
        private System.Windows.Forms.Button btn_viewProduct;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_brand;
        private System.Windows.Forms.RadioButton rad_model;
        private System.Windows.Forms.RadioButton rad_price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_orderProduct;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

