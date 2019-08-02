namespace Milestone
{
    partial class form_addProduct
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
            this.lb_screenResolution = new System.Windows.Forms.Label();
            this.lb_screenSize = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_productStock = new System.Windows.Forms.TextBox();
            this.tb_productPrice = new System.Windows.Forms.TextBox();
            this.tb_productScreenSize = new System.Windows.Forms.TextBox();
            this.tb_productScreenResolution = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_productModel = new System.Windows.Forms.TextBox();
            this.tb_productPicture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_screenResolution
            // 
            this.lb_screenResolution.AutoSize = true;
            this.lb_screenResolution.Location = new System.Drawing.Point(31, 205);
            this.lb_screenResolution.Name = "lb_screenResolution";
            this.lb_screenResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_screenResolution.Size = new System.Drawing.Size(100, 13);
            this.lb_screenResolution.TabIndex = 9;
            this.lb_screenResolution.Text = "Screen Resolution: ";
            this.lb_screenResolution.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_screenSize
            // 
            this.lb_screenSize.AutoSize = true;
            this.lb_screenSize.Location = new System.Drawing.Point(61, 179);
            this.lb_screenSize.Name = "lb_screenSize";
            this.lb_screenSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_screenSize.Size = new System.Drawing.Size(70, 13);
            this.lb_screenSize.TabIndex = 8;
            this.lb_screenSize.Text = "Screen Size: ";
            this.lb_screenSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(94, 152);
            this.lb_price.Name = "lb_price";
            this.lb_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_price.Size = new System.Drawing.Size(37, 13);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "Price: ";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(69, 124);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_stock.Size = new System.Drawing.Size(63, 13);
            this.lb_stock.TabIndex = 6;
            this.lb_stock.Text = "# In Stock: ";
            this.lb_stock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(90, 98);
            this.lb_name.Name = "lb_name";
            this.lb_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_name.Size = new System.Drawing.Size(42, 13);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "Model: ";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(137, 69);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(100, 20);
            this.tb_productName.TabIndex = 10;
            // 
            // tb_productStock
            // 
            this.tb_productStock.Location = new System.Drawing.Point(137, 121);
            this.tb_productStock.Name = "tb_productStock";
            this.tb_productStock.Size = new System.Drawing.Size(100, 20);
            this.tb_productStock.TabIndex = 11;
            // 
            // tb_productPrice
            // 
            this.tb_productPrice.Location = new System.Drawing.Point(137, 149);
            this.tb_productPrice.Name = "tb_productPrice";
            this.tb_productPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_productPrice.TabIndex = 12;
            // 
            // tb_productScreenSize
            // 
            this.tb_productScreenSize.Location = new System.Drawing.Point(137, 176);
            this.tb_productScreenSize.Name = "tb_productScreenSize";
            this.tb_productScreenSize.Size = new System.Drawing.Size(100, 20);
            this.tb_productScreenSize.TabIndex = 13;
            // 
            // tb_productScreenResolution
            // 
            this.tb_productScreenResolution.Location = new System.Drawing.Point(137, 202);
            this.tb_productScreenResolution.Name = "tb_productScreenResolution";
            this.tb_productScreenResolution.Size = new System.Drawing.Size(100, 20);
            this.tb_productScreenResolution.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(93, 303);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(231, 303);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // tb_productModel
            // 
            this.tb_productModel.Location = new System.Drawing.Point(137, 95);
            this.tb_productModel.Name = "tb_productModel";
            this.tb_productModel.Size = new System.Drawing.Size(100, 20);
            this.tb_productModel.TabIndex = 10;
            // 
            // tb_productPicture
            // 
            this.tb_productPicture.Location = new System.Drawing.Point(137, 228);
            this.tb_productPicture.Name = "tb_productPicture";
            this.tb_productPicture.Size = new System.Drawing.Size(100, 20);
            this.tb_productPicture.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 231);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Picture:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(137, 41);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 20);
            this.tb_ID.TabIndex = 10;
            // 
            // form_addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_productScreenResolution);
            this.Controls.Add(this.tb_productScreenSize);
            this.Controls.Add(this.tb_productPrice);
            this.Controls.Add(this.tb_productStock);
            this.Controls.Add(this.tb_productPicture);
            this.Controls.Add(this.tb_productModel);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_screenResolution);
            this.Controls.Add(this.lb_screenSize);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_name);
            this.Name = "form_addProduct";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_screenResolution;
        private System.Windows.Forms.Label lb_screenSize;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_productStock;
        private System.Windows.Forms.TextBox tb_productPrice;
        private System.Windows.Forms.TextBox tb_productScreenSize;
        private System.Windows.Forms.TextBox tb_productScreenResolution;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_productModel;
        private System.Windows.Forms.TextBox tb_productPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ID;
    }
}