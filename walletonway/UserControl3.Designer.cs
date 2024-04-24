namespace walletonway
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.namelabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.productnamewriten = new System.Windows.Forms.Label();
            this.productpricewriten = new System.Windows.Forms.Label();
            this.quanlabel = new System.Windows.Forms.Label();
            this.minusbut = new System.Windows.Forms.Button();
            this.plusbut = new System.Windows.Forms.Button();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Order";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.ForeColor = System.Drawing.Color.Aquamarine;
            this.button2.Location = new System.Drawing.Point(320, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "CLEAR ALL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(28, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "PAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(337, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "$ 24";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 133);
            this.panel1.TabIndex = 0;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(68, 161);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Name";
            this.namelabel.Click += new System.EventHandler(this.namelabel_Click);
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(196, 161);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(38, 16);
            this.pricelabel.TabIndex = 4;
            this.pricelabel.Text = "Price";
            this.pricelabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // productnamewriten
            // 
            this.productnamewriten.AutoSize = true;
            this.productnamewriten.Location = new System.Drawing.Point(68, 237);
            this.productnamewriten.Name = "productnamewriten";
            this.productnamewriten.Size = new System.Drawing.Size(44, 16);
            this.productnamewriten.TabIndex = 6;
            this.productnamewriten.Text = "label7";
            this.productnamewriten.Click += new System.EventHandler(this.label7_Click);
            // 
            // productpricewriten
            // 
            this.productpricewriten.AutoSize = true;
            this.productpricewriten.Location = new System.Drawing.Point(196, 233);
            this.productpricewriten.Name = "productpricewriten";
            this.productpricewriten.Size = new System.Drawing.Size(44, 16);
            this.productpricewriten.TabIndex = 7;
            this.productpricewriten.Text = "label8";
            this.productpricewriten.Click += new System.EventHandler(this.label8_Click);
            // 
            // quanlabel
            // 
            this.quanlabel.AutoSize = true;
            this.quanlabel.Location = new System.Drawing.Point(344, 230);
            this.quanlabel.Name = "quanlabel";
            this.quanlabel.Size = new System.Drawing.Size(44, 16);
            this.quanlabel.TabIndex = 8;
            this.quanlabel.Text = "label9";
            this.quanlabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // minusbut
            // 
            this.minusbut.Location = new System.Drawing.Point(313, 227);
            this.minusbut.Name = "minusbut";
            this.minusbut.Size = new System.Drawing.Size(25, 23);
            this.minusbut.TabIndex = 14;
            this.minusbut.Text = "-";
            this.minusbut.UseVisualStyleBackColor = true;
            this.minusbut.Click += new System.EventHandler(this.button5_Click);
            // 
            // plusbut
            // 
            this.plusbut.Location = new System.Drawing.Point(394, 226);
            this.plusbut.Name = "plusbut";
            this.plusbut.Size = new System.Drawing.Size(25, 23);
            this.plusbut.TabIndex = 15;
            this.plusbut.Text = "+";
            this.plusbut.UseVisualStyleBackColor = true;
            this.plusbut.Click += new System.EventHandler(this.button6_Click);
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Location = new System.Drawing.Point(333, 161);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(55, 16);
            this.Quantitylabel.TabIndex = 18;
            this.Quantitylabel.Text = "Quantity";
            this.Quantitylabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Quantitylabel);
            this.Controls.Add(this.plusbut);
            this.Controls.Add(this.minusbut);
            this.Controls.Add(this.quanlabel);
            this.Controls.Add(this.productpricewriten);
            this.Controls.Add(this.productnamewriten);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(464, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label productnamewriten;
        private System.Windows.Forms.Label productpricewriten;
        private System.Windows.Forms.Label quanlabel;
        private System.Windows.Forms.Button minusbut;
        private System.Windows.Forms.Button plusbut;
        private System.Windows.Forms.Label Quantitylabel;
    }
}
