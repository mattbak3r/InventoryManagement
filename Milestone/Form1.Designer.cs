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
            this.SuspendLayout();
            // 
            // lb_products
            // 
            this.lb_products.FormattingEnabled = true;
            this.lb_products.Location = new System.Drawing.Point(12, 86);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(326, 329);
            this.lb_products.TabIndex = 0;
            // 
            // tb_searchBar
            // 
            this.tb_searchBar.Location = new System.Drawing.Point(13, 60);
            this.tb_searchBar.Name = "tb_searchBar";
            this.tb_searchBar.Size = new System.Drawing.Size(100, 20);
            this.tb_searchBar.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(120, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_addNewProduct
            // 
            this.btn_addNewProduct.Location = new System.Drawing.Point(345, 301);
            this.btn_addNewProduct.Name = "btn_addNewProduct";
            this.btn_addNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addNewProduct.TabIndex = 3;
            this.btn_addNewProduct.Text = "Add New Product";
            this.btn_addNewProduct.UseVisualStyleBackColor = true;
            this.btn_addNewProduct.Click += new System.EventHandler(this.Btn_addNewProduct_Click);
            // 
            // btn_viewProduct
            // 
            this.btn_viewProduct.Location = new System.Drawing.Point(345, 362);
            this.btn_viewProduct.Name = "btn_viewProduct";
            this.btn_viewProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_viewProduct.TabIndex = 4;
            this.btn_viewProduct.Text = "View Product";
            this.btn_viewProduct.UseVisualStyleBackColor = true;
            this.btn_viewProduct.Click += new System.EventHandler(this.Btn_viewProduct_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(345, 331);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_removeProduct.TabIndex = 5;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.Btn_removeProduct_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(345, 391);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory for Monitor Products";
            // 
            // form_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_viewProduct);
            this.Controls.Add(this.btn_addNewProduct);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_searchBar);
            this.Controls.Add(this.lb_products);
            this.Name = "form_products";
            this.Text = "View Products";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

