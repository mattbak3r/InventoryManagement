namespace Milestone
{
    partial class form_viewProducts
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_screenSize = new System.Windows.Forms.Label();
            this.lb_screenResolution = new System.Windows.Forms.Label();
            this.pb_productPicture = new System.Windows.Forms.PictureBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_productID = new System.Windows.Forms.Label();
            this.lb_productName = new System.Windows.Forms.Label();
            this.lb_productStock = new System.Windows.Forms.Label();
            this.lb_productPrice = new System.Windows.Forms.Label();
            this.lb_productScreenSize = new System.Windows.Forms.Label();
            this.lb_productScreenResolution = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(146, 185);
            this.lb_name.Name = "lb_name";
            this.lb_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_name.Size = new System.Drawing.Size(41, 13);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name: ";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(134, 214);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_stock.Size = new System.Drawing.Size(53, 13);
            this.lb_stock.TabIndex = 1;
            this.lb_stock.Text = "In Stock: ";
            this.lb_stock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(150, 242);
            this.lb_price.Name = "lb_price";
            this.lb_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_price.Size = new System.Drawing.Size(37, 13);
            this.lb_price.TabIndex = 2;
            this.lb_price.Text = "Price: ";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_screenSize
            // 
            this.lb_screenSize.AutoSize = true;
            this.lb_screenSize.Location = new System.Drawing.Point(117, 273);
            this.lb_screenSize.Name = "lb_screenSize";
            this.lb_screenSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_screenSize.Size = new System.Drawing.Size(70, 13);
            this.lb_screenSize.TabIndex = 3;
            this.lb_screenSize.Text = "Screen Size: ";
            this.lb_screenSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_screenResolution
            // 
            this.lb_screenResolution.AutoSize = true;
            this.lb_screenResolution.Location = new System.Drawing.Point(87, 301);
            this.lb_screenResolution.Name = "lb_screenResolution";
            this.lb_screenResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_screenResolution.Size = new System.Drawing.Size(100, 13);
            this.lb_screenResolution.TabIndex = 4;
            this.lb_screenResolution.Text = "Screen Resolution: ";
            this.lb_screenResolution.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pb_productPicture
            // 
            this.pb_productPicture.Location = new System.Drawing.Point(102, 12);
            this.pb_productPicture.Name = "pb_productPicture";
            this.pb_productPicture.Size = new System.Drawing.Size(225, 137);
            this.pb_productPicture.TabIndex = 5;
            this.pb_productPicture.TabStop = false;
            this.pb_productPicture.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(15, 13);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(21, 13);
            this.lb_ID.TabIndex = 11;
            this.lb_ID.Text = "ID:";
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = true;
            this.lb_productID.Location = new System.Drawing.Point(42, 13);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(21, 13);
            this.lb_productID.TabIndex = 12;
            this.lb_productID.Text = "##";
            // 
            // lb_productName
            // 
            this.lb_productName.AutoSize = true;
            this.lb_productName.Location = new System.Drawing.Point(194, 184);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(73, 13);
            this.lb_productName.TabIndex = 13;
            this.lb_productName.Text = "Monitor Name";
            // 
            // lb_productStock
            // 
            this.lb_productStock.AutoSize = true;
            this.lb_productStock.Location = new System.Drawing.Point(194, 214);
            this.lb_productStock.Name = "lb_productStock";
            this.lb_productStock.Size = new System.Drawing.Size(86, 13);
            this.lb_productStock.TabIndex = 14;
            this.lb_productStock.Text = "Number in Stock";
            this.lb_productStock.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lb_productPrice
            // 
            this.lb_productPrice.AutoSize = true;
            this.lb_productPrice.Location = new System.Drawing.Point(194, 242);
            this.lb_productPrice.Name = "lb_productPrice";
            this.lb_productPrice.Size = new System.Drawing.Size(71, 13);
            this.lb_productPrice.TabIndex = 15;
            this.lb_productPrice.Text = "Product Price";
            // 
            // lb_productScreenSize
            // 
            this.lb_productScreenSize.AutoSize = true;
            this.lb_productScreenSize.Location = new System.Drawing.Point(194, 273);
            this.lb_productScreenSize.Name = "lb_productScreenSize";
            this.lb_productScreenSize.Size = new System.Drawing.Size(104, 13);
            this.lb_productScreenSize.TabIndex = 16;
            this.lb_productScreenSize.Text = "Product Screen Size";
            // 
            // lb_productScreenResolution
            // 
            this.lb_productScreenResolution.AutoSize = true;
            this.lb_productScreenResolution.Location = new System.Drawing.Point(194, 301);
            this.lb_productScreenResolution.Name = "lb_productScreenResolution";
            this.lb_productScreenResolution.Size = new System.Drawing.Size(134, 13);
            this.lb_productScreenResolution.TabIndex = 17;
            this.lb_productScreenResolution.Text = "Product Screen Resolution";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(55, 363);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 18;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.Btn_order_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(162, 363);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(273, 363);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // form_viewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.lb_productScreenResolution);
            this.Controls.Add(this.lb_productScreenSize);
            this.Controls.Add(this.lb_productPrice);
            this.Controls.Add(this.lb_productStock);
            this.Controls.Add(this.lb_productName);
            this.Controls.Add(this.lb_productID);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.pb_productPicture);
            this.Controls.Add(this.lb_screenResolution);
            this.Controls.Add(this.lb_screenSize);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.lb_name);
            this.Name = "form_viewProducts";
            this.Text = "View Product";
            this.Load += new System.EventHandler(this.Form_viewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_screenSize;
        private System.Windows.Forms.Label lb_screenResolution;
        private System.Windows.Forms.PictureBox pb_productPicture;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_productID;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.Label lb_productStock;
        private System.Windows.Forms.Label lb_productPrice;
        private System.Windows.Forms.Label lb_productScreenSize;
        private System.Windows.Forms.Label lb_productScreenResolution;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
    }
}