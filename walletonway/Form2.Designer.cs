namespace walletonway
{
    partial class Form2
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
            this.firstnameregister = new System.Windows.Forms.TextBox();
            this.Lastnameregister = new System.Windows.Forms.TextBox();
            this.Emailregister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordregister = new System.Windows.Forms.TextBox();
            this.usernameregister = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Regisiter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(304, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstnameregister
            // 
            this.firstnameregister.Location = new System.Drawing.Point(357, 130);
            this.firstnameregister.Name = "firstnameregister";
            this.firstnameregister.Size = new System.Drawing.Size(179, 22);
            this.firstnameregister.TabIndex = 1;
            this.firstnameregister.TextChanged += new System.EventHandler(this.firstnameregister_TextChanged);
            // 
            // Lastnameregister
            // 
            this.Lastnameregister.Location = new System.Drawing.Point(357, 173);
            this.Lastnameregister.Name = "Lastnameregister";
            this.Lastnameregister.Size = new System.Drawing.Size(180, 22);
            this.Lastnameregister.TabIndex = 2;
            this.Lastnameregister.TextChanged += new System.EventHandler(this.Lastnameregister_TextChanged);
            // 
            // Emailregister
            // 
            this.Emailregister.Location = new System.Drawing.Point(357, 219);
            this.Emailregister.Name = "Emailregister";
            this.Emailregister.Size = new System.Drawing.Size(180, 22);
            this.Emailregister.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // passwordregister
            // 
            this.passwordregister.Location = new System.Drawing.Point(356, 309);
            this.passwordregister.Name = "passwordregister";
            this.passwordregister.Size = new System.Drawing.Size(180, 22);
            this.passwordregister.TabIndex = 8;
            // 
            // usernameregister
            // 
            this.usernameregister.Location = new System.Drawing.Point(356, 262);
            this.usernameregister.Name = "usernameregister";
            this.usernameregister.Size = new System.Drawing.Size(180, 22);
            this.usernameregister.TabIndex = 9;
            this.usernameregister.TextChanged += new System.EventHandler(this.usernameregister_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tan;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username";
            // 
            // Regisiter
            // 
            this.Regisiter.BackColor = System.Drawing.Color.Tan;
            this.Regisiter.Location = new System.Drawing.Point(356, 364);
            this.Regisiter.Name = "Regisiter";
            this.Regisiter.Size = new System.Drawing.Size(90, 49);
            this.Regisiter.TabIndex = 11;
            this.Regisiter.Text = "Register";
            this.Regisiter.UseVisualStyleBackColor = false;
            this.Regisiter.Click += new System.EventHandler(this.Regisiter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::walletonway.Properties.Resources.wallet1;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Regisiter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usernameregister);
            this.Controls.Add(this.passwordregister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emailregister);
            this.Controls.Add(this.Lastnameregister);
            this.Controls.Add(this.firstnameregister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnameregister;
        private System.Windows.Forms.TextBox Lastnameregister;
        private System.Windows.Forms.TextBox Emailregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordregister;
        private System.Windows.Forms.TextBox usernameregister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Regisiter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}