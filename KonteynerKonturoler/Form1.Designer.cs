namespace KonteynerKonturoler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbcul7 = new System.Windows.Forms.RadioButton();
            this.rbcul5 = new System.Windows.Forms.RadioButton();
            this.rbcul3 = new System.Windows.Forms.RadioButton();
            this.rbcuR5 = new System.Windows.Forms.RadioButton();
            this.rbcuR3 = new System.Windows.Forms.RadioButton();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbhdd1000 = new System.Windows.Forms.RadioButton();
            this.rbhdd500 = new System.Windows.Forms.RadioButton();
            this.rbhdd320 = new System.Windows.Forms.RadioButton();
            this.cvDvd = new System.Windows.Forms.CheckBox();
            this.cbWebcam = new System.Windows.Forms.CheckBox();
            this.cbWirelesskart = new System.Windows.Forms.CheckBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.rbcuR3);
            this.groupBox1.Controls.Add(this.rbcuR5);
            this.groupBox1.Controls.Add(this.rbcul3);
            this.groupBox1.Controls.Add(this.rbcul5);
            this.groupBox1.Controls.Add(this.rbcul7);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemciler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.rbRam4);
            this.groupBox2.Controls.Add(this.rbRam8);
            this.groupBox2.Controls.Add(this.rbRam16);
            this.groupBox2.Location = new System.Drawing.Point(250, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Belekler";
            // 
            // rbcul7
            // 
            this.rbcul7.AutoSize = true;
            this.rbcul7.Location = new System.Drawing.Point(41, 19);
            this.rbcul7.Name = "rbcul7";
            this.rbcul7.Size = new System.Drawing.Size(56, 17);
            this.rbcul7.TabIndex = 0;
            this.rbcul7.TabStop = true;
            this.rbcul7.Text = "İntel i7";
            this.rbcul7.UseVisualStyleBackColor = true;
            // 
            // rbcul5
            // 
            this.rbcul5.AutoSize = true;
            this.rbcul5.Location = new System.Drawing.Point(41, 51);
            this.rbcul5.Name = "rbcul5";
            this.rbcul5.Size = new System.Drawing.Size(56, 17);
            this.rbcul5.TabIndex = 1;
            this.rbcul5.TabStop = true;
            this.rbcul5.Text = "İntel i5";
            this.rbcul5.UseVisualStyleBackColor = true;
            // 
            // rbcul3
            // 
            this.rbcul3.AutoSize = true;
            this.rbcul3.Location = new System.Drawing.Point(41, 84);
            this.rbcul3.Name = "rbcul3";
            this.rbcul3.Size = new System.Drawing.Size(56, 17);
            this.rbcul3.TabIndex = 2;
            this.rbcul3.TabStop = true;
            this.rbcul3.Text = "İntel i3";
            this.rbcul3.UseVisualStyleBackColor = true;
            // 
            // rbcuR5
            // 
            this.rbcuR5.AutoSize = true;
            this.rbcuR5.Location = new System.Drawing.Point(41, 121);
            this.rbcuR5.Name = "rbcuR5";
            this.rbcuR5.Size = new System.Drawing.Size(94, 17);
            this.rbcuR5.TabIndex = 3;
            this.rbcuR5.TabStop = true;
            this.rbcuR5.Text = "AMD Rayzen5";
            this.rbcuR5.UseVisualStyleBackColor = true;
            // 
            // rbcuR3
            // 
            this.rbcuR3.AutoSize = true;
            this.rbcuR3.Location = new System.Drawing.Point(41, 156);
            this.rbcuR3.Name = "rbcuR3";
            this.rbcuR3.Size = new System.Drawing.Size(94, 17);
            this.rbcuR3.TabIndex = 4;
            this.rbcuR3.TabStop = true;
            this.rbcuR3.Text = "AMD Rayzen3";
            this.rbcuR3.UseVisualStyleBackColor = true;
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Location = new System.Drawing.Point(49, 51);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(52, 17);
            this.rbRam16.TabIndex = 0;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Location = new System.Drawing.Point(49, 84);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(46, 17);
            this.rbRam8.TabIndex = 1;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Location = new System.Drawing.Point(49, 121);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(46, 17);
            this.rbRam4.TabIndex = 2;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.rbhdd320);
            this.groupBox3.Controls.Add(this.rbhdd500);
            this.groupBox3.Controls.Add(this.rbhdd1000);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.cbWirelesskart);
            this.groupBox4.Controls.Add(this.cbWebcam);
            this.groupBox4.Controls.Add(this.cvDvd);
            this.groupBox4.Location = new System.Drawing.Point(250, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // rbhdd1000
            // 
            this.rbhdd1000.AutoSize = true;
            this.rbhdd1000.Location = new System.Drawing.Point(20, 20);
            this.rbhdd1000.Name = "rbhdd1000";
            this.rbhdd1000.Size = new System.Drawing.Size(45, 17);
            this.rbhdd1000.TabIndex = 0;
            this.rbhdd1000.TabStop = true;
            this.rbhdd1000.Text = "1TB";
            this.rbhdd1000.UseVisualStyleBackColor = true;
            // 
            // rbhdd500
            // 
            this.rbhdd500.AutoSize = true;
            this.rbhdd500.Location = new System.Drawing.Point(20, 54);
            this.rbhdd500.Name = "rbhdd500";
            this.rbhdd500.Size = new System.Drawing.Size(58, 17);
            this.rbhdd500.TabIndex = 1;
            this.rbhdd500.TabStop = true;
            this.rbhdd500.Text = "500GB";
            this.rbhdd500.UseVisualStyleBackColor = true;
            // 
            // rbhdd320
            // 
            this.rbhdd320.AutoSize = true;
            this.rbhdd320.Location = new System.Drawing.Point(20, 94);
            this.rbhdd320.Name = "rbhdd320";
            this.rbhdd320.Size = new System.Drawing.Size(58, 17);
            this.rbhdd320.TabIndex = 2;
            this.rbhdd320.TabStop = true;
            this.rbhdd320.Text = "320GB";
            this.rbhdd320.UseVisualStyleBackColor = true;
            // 
            // cvDvd
            // 
            this.cvDvd.AutoSize = true;
            this.cvDvd.Location = new System.Drawing.Point(20, 33);
            this.cvDvd.Name = "cvDvd";
            this.cvDvd.Size = new System.Drawing.Size(67, 17);
            this.cvDvd.TabIndex = 0;
            this.cvDvd.Text = "DVD RV";
            this.cvDvd.UseVisualStyleBackColor = true;
            // 
            // cbWebcam
            // 
            this.cbWebcam.AutoSize = true;
            this.cbWebcam.Location = new System.Drawing.Point(20, 67);
            this.cbWebcam.Name = "cbWebcam";
            this.cbWebcam.Size = new System.Drawing.Size(72, 17);
            this.cbWebcam.TabIndex = 1;
            this.cbWebcam.Text = "Web cam";
            this.cbWebcam.UseVisualStyleBackColor = true;
            // 
            // cbWirelesskart
            // 
            this.cbWirelesskart.AutoSize = true;
            this.cbWirelesskart.Location = new System.Drawing.Point(20, 107);
            this.cbWirelesskart.Name = "cbWirelesskart";
            this.cbWirelesskart.Size = new System.Drawing.Size(87, 17);
            this.cbWirelesskart.TabIndex = 2;
            this.cbWirelesskart.Text = "Wireless kart";
            this.cbWirelesskart.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(495, 187);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(120, 93);
            this.btnhesapla.TabIndex = 4;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gurup Box konturolü uygulama 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcuR3;
        private System.Windows.Forms.RadioButton rbcuR5;
        private System.Windows.Forms.RadioButton rbcul3;
        private System.Windows.Forms.RadioButton rbcul5;
        private System.Windows.Forms.RadioButton rbcul7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbhdd320;
        private System.Windows.Forms.RadioButton rbhdd500;
        private System.Windows.Forms.RadioButton rbhdd1000;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbWirelesskart;
        private System.Windows.Forms.CheckBox cbWebcam;
        private System.Windows.Forms.CheckBox cvDvd;
        private System.Windows.Forms.Button btnhesapla;
    }
}

