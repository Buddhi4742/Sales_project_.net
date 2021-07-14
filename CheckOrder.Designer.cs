namespace Sales_project
{
    partial class CheckOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.cmb_itemtype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Customer ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(193, 28);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(195, 20);
            this.txt_ID.TabIndex = 78;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Item";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(26, 223);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(23, 13);
            this.Qty.TabIndex = 82;
            this.Qty.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Total Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Unit Price";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(190, 173);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(35, 13);
            this.lbl_price.TabIndex = 86;
            this.lbl_price.Text = "label2";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(190, 223);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(35, 13);
            this.lbl_qty.TabIndex = 87;
            this.lbl_qty.Text = "label6";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(190, 264);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(35, 13);
            this.lbl_cost.TabIndex = 88;
            this.lbl_cost.Text = "label7";
            // 
            // cmb_itemtype
            // 
            this.cmb_itemtype.FormattingEnabled = true;
            this.cmb_itemtype.Location = new System.Drawing.Point(193, 124);
            this.cmb_itemtype.Name = "cmb_itemtype";
            this.cmb_itemtype.Size = new System.Drawing.Size(195, 21);
            this.cmb_itemtype.TabIndex = 89;
            this.cmb_itemtype.SelectedIndexChanged += new System.EventHandler(this.cmb_itemtype_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Select Your Ordered Item type To view Details";
            // 
            // CheckOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_itemtype);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Name = "CheckOrder";
            this.Text = "CheckOrder";
            this.Load += new System.EventHandler(this.CheckOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.ComboBox cmb_itemtype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}