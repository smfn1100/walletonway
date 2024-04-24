namespace walletonway
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusernamelogin = new System.Windows.Forms.TextBox();
            this.txtpasswordlogin = new System.Windows.Forms.TextBox();
            this.nectlogin = new System.Windows.Forms.Button();
            this.signuplogin = new System.Windows.Forms.Button();
            this.guestlogin = new System.Windows.Forms.LinkLabel();
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
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(208, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wallet Hub";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(213, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Your Wallet On One Click!!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtusernamelogin
            // 
            this.txtusernamelogin.BackColor = System.Drawing.Color.Tan;
            this.txtusernamelogin.Location = new System.Drawing.Point(386, 214);
            this.txtusernamelogin.Name = "txtusernamelogin";
            this.txtusernamelogin.Size = new System.Drawing.Size(176, 22);
            this.txtusernamelogin.TabIndex = 4;
            this.txtusernamelogin.TextChanged += new System.EventHandler(this.txtusernamelogin_TextChanged);
            // 
            // txtpasswordlogin
            // 
            this.txtpasswordlogin.BackColor = System.Drawing.Color.Tan;
            this.txtpasswordlogin.Location = new System.Drawing.Point(386, 260);
            this.txtpasswordlogin.Name = "txtpasswordlogin";
            this.txtpasswordlogin.Size = new System.Drawing.Size(176, 22);
            this.txtpasswordlogin.TabIndex = 5;
            // 
            // nectlogin
            // 
            this.nectlogin.BackColor = System.Drawing.Color.Tan;
            this.nectlogin.Location = new System.Drawing.Point(602, 326);
            this.nectlogin.Name = "nectlogin";
            this.nectlogin.Size = new System.Drawing.Size(76, 36);
            this.nectlogin.TabIndex = 6;
            this.nectlogin.Text = "Next";
            this.nectlogin.UseVisualStyleBackColor = false;
            this.nectlogin.Click += new System.EventHandler(this.nectlogin_Click);
            // 
            // signuplogin
            // 
            this.signuplogin.BackColor = System.Drawing.Color.Tan;
            this.signuplogin.Location = new System.Drawing.Point(500, 326);
            this.signuplogin.Name = "signuplogin";
            this.signuplogin.Size = new System.Drawing.Size(77, 36);
            this.signuplogin.TabIndex = 7;
            this.signuplogin.Text = "SIgnup";
            this.signuplogin.UseVisualStyleBackColor = false;
            this.signuplogin.Click += new System.EventHandler(this.signuplogin_Click_1);
            // 
            // guestlogin
            // 
            this.guestlogin.AutoSize = true;
            this.guestlogin.BackColor = System.Drawing.Color.Tan;
            this.guestlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestlogin.LinkColor = System.Drawing.Color.Brown;
            this.guestlogin.Location = new System.Drawing.Point(103, 336);
            this.guestlogin.Name = "guestlogin";
            this.guestlogin.Size = new System.Drawing.Size(115, 20);
            this.guestlogin.TabIndex = 8;
            this.guestlogin.TabStop = true;
            this.guestlogin.Text = "Visit as Guest";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::walletonway.Properties.Resources.wallet1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 426);
            this.Controls.Add(this.guestlogin);
            this.Controls.Add(this.signuplogin);
            this.Controls.Add(this.nectlogin);
            this.Controls.Add(this.txtpasswordlogin);
            this.Controls.Add(this.txtusernamelogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusernamelogin;
        private System.Windows.Forms.TextBox txtpasswordlogin;
        private System.Windows.Forms.Button nectlogin;
        private System.Windows.Forms.Button signuplogin;
        private System.Windows.Forms.LinkLabel guestlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

