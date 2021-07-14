namespace Sales_project
{
    partial class Login
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_emppass = new System.Windows.Forms.TextBox();
            this.txt_empuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login_emp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(146, 195);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 42;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_emppass
            // 
            this.txt_emppass.Location = new System.Drawing.Point(138, 142);
            this.txt_emppass.MaxLength = 15;
            this.txt_emppass.Name = "txt_emppass";
            this.txt_emppass.Size = new System.Drawing.Size(191, 20);
            this.txt_emppass.TabIndex = 40;
            // 
            // txt_empuser
            // 
            this.txt_empuser.Location = new System.Drawing.Point(138, 91);
            this.txt_empuser.MaxLength = 20;
            this.txt_empuser.Name = "txt_empuser";
            this.txt_empuser.Size = new System.Drawing.Size(191, 20);
            this.txt_empuser.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Username / ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Password";
            // 
            // btn_login_emp
            // 
            this.btn_login_emp.Location = new System.Drawing.Point(36, 195);
            this.btn_login_emp.Name = "btn_login_emp";
            this.btn_login_emp.Size = new System.Drawing.Size(75, 23);
            this.btn_login_emp.TabIndex = 36;
            this.btn_login_emp.Text = "Login";
            this.btn_login_emp.UseVisualStyleBackColor = true;
            this.btn_login_emp.Click += new System.EventHandler(this.btn_login_emp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 321);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_emppass);
            this.Controls.Add(this.txt_empuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login_emp);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_emppass;
        private System.Windows.Forms.TextBox txt_empuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_emp;
    }
}