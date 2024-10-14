namespace HastahaneSistemi
{
    partial class HastaKayitOl
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKayıt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(102, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(78, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(18, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(39, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(88, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(57, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet: ";
            // 
            // MskTcNo
            // 
            this.MskTcNo.BackColor = System.Drawing.Color.Azure;
            this.MskTcNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.MskTcNo.Location = new System.Drawing.Point(159, 342);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(152, 34);
            this.MskTcNo.TabIndex = 3;
            this.MskTcNo.ValidatingType = typeof(int);
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.Azure;
            this.TxtAd.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtAd.Location = new System.Drawing.Point(159, 217);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(152, 34);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.Azure;
            this.TxtSoyad.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtSoyad.Location = new System.Drawing.Point(159, 279);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(152, 34);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.Azure;
            this.TxtSifre.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtSifre.Location = new System.Drawing.Point(159, 475);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(152, 34);
            this.TxtSifre.TabIndex = 5;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTelNo
            // 
            this.MskTelNo.BackColor = System.Drawing.Color.Azure;
            this.MskTelNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.MskTelNo.Location = new System.Drawing.Point(159, 403);
            this.MskTelNo.Mask = "(999) 000-0000";
            this.MskTelNo.Name = "MskTelNo";
            this.MskTelNo.Size = new System.Drawing.Size(152, 34);
            this.MskTelNo.TabIndex = 4;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.BackColor = System.Drawing.Color.Azure;
            this.CmbCinsiyet.ForeColor = System.Drawing.Color.DarkBlue;
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek\t",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(159, 535);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(152, 38);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // BtnKayıt
            // 
            this.BtnKayıt.BackColor = System.Drawing.Color.Azure;
            this.BtnKayıt.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnKayıt.Location = new System.Drawing.Point(159, 598);
            this.BtnKayıt.Name = "BtnKayıt";
            this.BtnKayıt.Size = new System.Drawing.Size(152, 51);
            this.BtnKayıt.TabIndex = 7;
            this.BtnKayıt.Text = "Kayıt Yap";
            this.BtnKayıt.UseVisualStyleBackColor = false;
            this.BtnKayıt.Click += new System.EventHandler(this.BtnKayıt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(102, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "HASTA KAYIT OLMA PANELI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastahaneSistemi.Properties.Resources.images_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(159, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HastaKayitOl
            // 
            this.AcceptButton = this.BtnKayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(420, 737);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnKayıt);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.MskTelNo);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTcNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "HastaKayitOl";
            this.Text = "HastaKayitOl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTcNo;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTelNo;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Button BtnKayıt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}