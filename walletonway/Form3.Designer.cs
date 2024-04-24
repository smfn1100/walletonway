namespace walletonway
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contactuslink = new System.Windows.Forms.LinkLabel();
            this.signuplink = new System.Windows.Forms.LinkLabel();
            this.aboutlink = new System.Windows.Forms.LinkLabel();
            this.supportlink = new System.Windows.Forms.LinkLabel();
            this.signinlink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ordernowbt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.contactuslink);
            this.panel1.Controls.Add(this.signuplink);
            this.panel1.Controls.Add(this.aboutlink);
            this.panel1.Controls.Add(this.supportlink);
            this.panel1.Controls.Add(this.signinlink);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(996, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 138);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::walletonway.Properties.Resources.wallet;
            this.pictureBox1.Location = new System.Drawing.Point(55, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "WALLET HUB";
            // 
            // contactuslink
            // 
            this.contactuslink.AutoSize = true;
            this.contactuslink.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.contactuslink.LinkColor = System.Drawing.Color.Aquamarine;
            this.contactuslink.Location = new System.Drawing.Point(461, 101);
            this.contactuslink.Name = "contactuslink";
            this.contactuslink.Size = new System.Drawing.Size(113, 19);
            this.contactuslink.TabIndex = 4;
            this.contactuslink.TabStop = true;
            this.contactuslink.Text = "CONTACT US";
            this.contactuslink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactuslink_LinkClicked);
            // 
            // signuplink
            // 
            this.signuplink.AutoSize = true;
            this.signuplink.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.signuplink.LinkColor = System.Drawing.Color.Aquamarine;
            this.signuplink.Location = new System.Drawing.Point(359, 101);
            this.signuplink.Name = "signuplink";
            this.signuplink.Size = new System.Drawing.Size(79, 19);
            this.signuplink.TabIndex = 3;
            this.signuplink.TabStop = true;
            this.signuplink.Text = "SIGN-UP";
            this.signuplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signuplink_LinkClicked);
            // 
            // aboutlink
            // 
            this.aboutlink.AutoSize = true;
            this.aboutlink.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.aboutlink.LinkColor = System.Drawing.Color.Aquamarine;
            this.aboutlink.Location = new System.Drawing.Point(274, 101);
            this.aboutlink.Name = "aboutlink";
            this.aboutlink.Size = new System.Drawing.Size(67, 19);
            this.aboutlink.TabIndex = 2;
            this.aboutlink.TabStop = true;
            this.aboutlink.Text = "ABOUT";
            this.aboutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutlink_LinkClicked);
            // 
            // supportlink
            // 
            this.supportlink.AutoSize = true;
            this.supportlink.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.supportlink.LinkColor = System.Drawing.Color.Aquamarine;
            this.supportlink.Location = new System.Drawing.Point(131, 101);
            this.supportlink.Name = "supportlink";
            this.supportlink.Size = new System.Drawing.Size(137, 19);
            this.supportlink.TabIndex = 1;
            this.supportlink.TabStop = true;
            this.supportlink.Text = "SUPPORT/HELP";
            this.supportlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.supportlink_LinkClicked);
            // 
            // signinlink
            // 
            this.signinlink.AutoSize = true;
            this.signinlink.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinlink.LinkColor = System.Drawing.Color.Aquamarine;
            this.signinlink.Location = new System.Drawing.Point(35, 101);
            this.signinlink.Name = "signinlink";
            this.signinlink.Size = new System.Drawing.Size(74, 19);
            this.signinlink.TabIndex = 0;
            this.signinlink.TabStop = true;
            this.signinlink.Text = "SIGN-IN";
            this.signinlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signinlink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(132, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Only";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(125, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 155);
            this.label3.TabIndex = 7;
            this.label3.Text = "$ 25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(131, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "AM LEATHER Brown Men’s Wallet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(133, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(545, 54);
            this.label5.TabIndex = 9;
            this.label5.Text = "What You See Is What You Get: Check Out Our Product Images For Details,\r\nWe Alway" +
    "s Stand Behind Our Products.\r\nDimensions (L X W X H): 12.5 Cm X 2 Cm X 10 Cm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::walletonway.Properties.Resources.no38_personalized_minimalist_hanmade_leather_wallet_brown_2000x;
            this.pictureBox2.Location = new System.Drawing.Point(719, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ordernowbt
            // 
            this.ordernowbt.BackColor = System.Drawing.Color.Maroon;
            this.ordernowbt.ForeColor = System.Drawing.Color.Aquamarine;
            this.ordernowbt.Location = new System.Drawing.Point(206, 606);
            this.ordernowbt.Name = "ordernowbt";
            this.ordernowbt.Size = new System.Drawing.Size(233, 47);
            this.ordernowbt.TabIndex = 11;
            this.ordernowbt.Text = "Order Now";
            this.ordernowbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ordernowbt.UseVisualStyleBackColor = false;
            this.ordernowbt.Click += new System.EventHandler(this.ordernowbt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 763);
            this.Controls.Add(this.ordernowbt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel contactuslink;
        private System.Windows.Forms.LinkLabel signuplink;
        private System.Windows.Forms.LinkLabel aboutlink;
        private System.Windows.Forms.LinkLabel supportlink;
        private System.Windows.Forms.LinkLabel signinlink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ordernowbt;
    }
}