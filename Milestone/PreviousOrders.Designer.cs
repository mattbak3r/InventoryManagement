namespace Milestone
{
    partial class PreviousOrders
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
            this.lb_allOrders = new System.Windows.Forms.ListBox();
            this.btn_viewOrder = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_allOrders
            // 
            this.lb_allOrders.FormattingEnabled = true;
            this.lb_allOrders.Location = new System.Drawing.Point(63, 46);
            this.lb_allOrders.Name = "lb_allOrders";
            this.lb_allOrders.Size = new System.Drawing.Size(160, 277);
            this.lb_allOrders.TabIndex = 0;
            // 
            // btn_viewOrder
            // 
            this.btn_viewOrder.Location = new System.Drawing.Point(246, 46);
            this.btn_viewOrder.Name = "btn_viewOrder";
            this.btn_viewOrder.Size = new System.Drawing.Size(107, 36);
            this.btn_viewOrder.TabIndex = 1;
            this.btn_viewOrder.Text = "View Order";
            this.btn_viewOrder.UseVisualStyleBackColor = true;
            this.btn_viewOrder.Click += new System.EventHandler(this.Btn_viewOrder_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(246, 88);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 36);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Order to View";
            // 
            // PreviousOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_viewOrder);
            this.Controls.Add(this.lb_allOrders);
            this.Name = "PreviousOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previous Orders";
            this.Load += new System.EventHandler(this.PreviousOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_allOrders;
        private System.Windows.Forms.Button btn_viewOrder;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
    }
}