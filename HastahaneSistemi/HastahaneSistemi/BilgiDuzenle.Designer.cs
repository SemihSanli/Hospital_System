namespace HastahaneSistemi
{
    partial class BilgiDuzenle
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
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.MskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Azure;
            this.BtnGuncelle.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnGuncelle.Location = new System.Drawing.Point(209, 651);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(152, 51);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.BackColor = System.Drawing.Color.Azure;
            this.CmbCinsiyet.ForeColor = System.Drawing.Color.DarkBlue;
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.ItemHeight = 35;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek\t",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(209, 587);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(152, 43);
            this.CmbCinsiyet.TabIndex = 28;
            // 
            // MskTelNo
            // 
            this.MskTelNo.BackColor = System.Drawing.Color.Azure;
            this.MskTelNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.MskTelNo.Location = new System.Drawing.Point(209, 455);
            this.MskTelNo.Mask = "(999) 000-0000";
            this.MskTelNo.Name = "MskTelNo";
            this.MskTelNo.Size = new System.Drawing.Size(152, 38);
            this.MskTelNo.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.Azure;
            this.TxtSifre.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtSifre.Location = new System.Drawing.Point(209, 524);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(152, 38);
            this.TxtSifre.TabIndex = 5;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.Azure;
            this.TxtSoyad.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtSoyad.Location = new System.Drawing.Point(209, 331);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(152, 38);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.Azure;
            this.TxtAd.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtAd.Location = new System.Drawing.Point(209, 269);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(152, 38);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTcNo
            // 
            this.MskTcNo.BackColor = System.Drawing.Color.Azure;
            this.MskTcNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.MskTcNo.Location = new System.Drawing.Point(209, 394);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(152, 38);
            this.MskTcNo.TabIndex = 3;
            this.MskTcNo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(81, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 35);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cinsiyet: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(114, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 35);
            this.label5.TabIndex = 21;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(46, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(18, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(102, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(139, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastahaneSistemi.Properties.Resources.png_transparent_gray_and_teal_patient_patient_computer_icons_hospital_patient_icon_drawing_miscellaneous_blue_angle_thumbnail_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(45, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(461, 39);
            this.label7.TabIndex = 30;
            this.label7.Text = "HASTA BİLGİ DÜZENLEME PANELİ";
            // 
            // BilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(522, 761);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuncelle);
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
            this.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "BilgiDuzenle";
            this.Text = "BilgiDuzenle";
            this.Load += new System.EventHandler(this.BilgiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox MskTelNo;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTcNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}