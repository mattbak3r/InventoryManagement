namespace Milestone
{
    partial class form_order
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
            this.lb_allProducts = new System.Windows.Forms.ListBox();
            this.lb_orderedProducts = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.lab_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_prevOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_allProducts
            // 
            this.lb_allProducts.FormattingEnabled = true;
            this.lb_allProducts.Location = new System.Drawing.Point(30, 63);
            this.lb_allProducts.Name = "lb_allProducts";
            this.lb_allProducts.Size = new System.Drawing.Size(333, 186);
            this.lb_allProducts.TabIndex = 0;
            // 
            // lb_orderedProducts
            // 
            this.lb_orderedProducts.FormattingEnabled = true;
            this.lb_orderedProducts.Location = new System.Drawing.Point(432, 63);
            this.lb_orderedProducts.Name = "lb_orderedProducts";
            this.lb_orderedProducts.Size = new System.Drawing.Size(333, 186);
            this.lb_orderedProducts.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(369, 93);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(57, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = ">>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(369, 122);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(57, 23);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "<<";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(369, 204);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(636, 255);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(128, 38);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.Btn_order_Click);
            // 
            // lab_price
            // 
            this.lab_price.AutoSize = true;
            this.lab_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_price.Location = new System.Drawing.Point(510, 252);
            this.lab_price.Name = "lab_price";
            this.lab_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_price.Size = new System.Drawing.Size(38, 25);
            this.lab_price.TabIndex = 3;
            this.lab_price.Text = "$$";
            this.lab_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(432, 252);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(566, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(158, 35);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(689, 364);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_prevOrders
            // 
            this.btn_prevOrders.Location = new System.Drawing.Point(636, 300);
            this.btn_prevOrders.Name = "btn_prevOrders";
            this.btn_prevOrders.Size = new System.Drawing.Size(127, 40);
            this.btn_prevOrders.TabIndex = 5;
            this.btn_prevOrders.Text = "View Previous Orders";
            this.btn_prevOrders.UseVisualStyleBackColor = true;
            // 
            // form_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_prevOrders);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_price);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_orderedProducts);
            this.Controls.Add(this.lb_allProducts);
            this.Name = "form_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Form_order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_allProducts;
        private System.Windows.Forms.ListBox lb_orderedProducts;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lab_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_prevOrders;
    }
}