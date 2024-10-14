namespace HastahaneSistemi
{
    partial class DoktorBilgiDuzenle
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
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.Azure;
            this.TxtSoyad.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtSoyad.Location = new System.Drawing.Point(162, 348);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(152, 34);
            this.TxtSoyad.TabIndex = 15;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.Azure;
            this.TxtAd.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtAd.Location = new System.Drawing.Point(162, 286);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(152, 34);
            this.TxtAd.TabIndex = 14;
            // 
            // MskTcNo
            // 
            this.MskTcNo.BackColor = System.Drawing.Color.Azure;
            this.MskTcNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.MskTcNo.Location = new System.Drawing.Point(162, 411);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(152, 34);
            this.MskTcNo.TabIndex = 13;
            this.MskTcNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(10, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(81, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(105, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.Azure;
            this.TxtSifre.Location = new System.Drawing.Point(162, 510);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(152, 34);
            this.TxtSifre.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(91, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Şifre:";
            // 
            // CmbBrans
            // 
            this.CmbBrans.BackColor = System.Drawing.Color.Azure;
            this.CmbBrans.ForeColor = System.Drawing.Color.DarkBlue;
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(162, 451);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(152, 38);
            this.CmbBrans.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(76, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Branş :";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Azure;
            this.BtnGuncelle.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnGuncelle.Location = new System.Drawing.Point(162, 550);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(152, 51);
            this.BtnGuncelle.TabIndex = 30;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastahaneSistemi.Properties.Resources.pngtree_flat_form_icon_with_form_sign_on_a_photo_png_image_14285069_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(58, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 42);
            this.label6.TabIndex = 32;
            this.label6.Text = "Doktor  Bilgi Düzenleme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(184, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 42);
            this.label7.TabIndex = 33;
            this.label7.Text = "Paneli";
            // 
            // DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(416, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTcNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DoktorBilgiDuzenle";
            this.Text = "DoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.DoktorBilgiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}