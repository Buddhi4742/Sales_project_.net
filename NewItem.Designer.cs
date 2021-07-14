namespace Sales_project
{
    partial class NewItem
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
            this.txt_itemtype = new System.Windows.Forms.TextBox();
            this.txt_itemcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.Location = new System.Drawing.Point(220, 68);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.Size = new System.Drawing.Size(193, 20);
            this.txt_itemtype.TabIndex = 76;
            // 
            // txt_itemcode
            // 
            this.txt_itemcode.Location = new System.Drawing.Point(216, 107);
            this.txt_itemcode.Name = "txt_itemcode";
            this.txt_itemcode.Size = new System.Drawing.Size(197, 20);
            this.txt_itemcode.TabIndex = 75;
            this.txt_itemcode.TextChanged += new System.EventHandler(this.txt_itemcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Item Code";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(216, 28);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(195, 20);
            this.txt_itemname.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Item Name";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(218, 152);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(195, 20);
            this.txt_price.TabIndex = 67;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(216, 210);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 66;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(64, 210);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 64;
            this.btn_confirm.Text = "Save";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Unit Price";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 269);
            this.Controls.Add(this.txt_itemtype);
            this.Controls.Add(this.txt_itemcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "NewItem";
            this.Text = "NewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_itemtype;
        private System.Windows.Forms.TextBox txt_itemcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}