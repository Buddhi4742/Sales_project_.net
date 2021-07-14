namespace Sales_project
{
    partial class NewOrder
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
            this.txt_totcost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_itemtype = new System.Windows.Forms.ComboBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_totcost
            // 
            this.txt_totcost.Location = new System.Drawing.Point(191, 150);
            this.txt_totcost.Name = "txt_totcost";
            this.txt_totcost.Size = new System.Drawing.Size(195, 20);
            this.txt_totcost.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Total Cost";
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Location = new System.Drawing.Point(191, 69);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(195, 20);
            this.txt_unitprice.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Unit Price";
            // 
            // cmb_itemtype
            // 
            this.cmb_itemtype.FormattingEnabled = true;
            this.cmb_itemtype.Location = new System.Drawing.Point(191, 28);
            this.cmb_itemtype.Name = "cmb_itemtype";
            this.cmb_itemtype.Size = new System.Drawing.Size(195, 21);
            this.cmb_itemtype.TabIndex = 59;
            this.cmb_itemtype.SelectedIndexChanged += new System.EventHandler(this.cmb_itemtype_SelectedIndexChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(191, 110);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(195, 20);
            this.txt_qty.TabIndex = 56;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(240, 211);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 55;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(123, 211);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 54;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Item";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(24, 113);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(23, 13);
            this.Qty.TabIndex = 52;
            this.Qty.Text = "Qty";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 292);
            this.Controls.Add(this.txt_totcost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_itemtype);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Qty);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_totcost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_itemtype;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Qty;
    }
}