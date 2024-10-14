namespace HastahaneSistemi
{
    partial class Hasta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LnkKayıtOl = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(79, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(189, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.Azure;
            this.MskTC.ForeColor = System.Drawing.Color.DarkBlue;
            this.MskTC.Location = new System.Drawing.Point(282, 289);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(165, 41);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.Azure;
            this.TxtSifre.ForeColor = System.Drawing.Color.DarkBlue;
            this.TxtSifre.Location = new System.Drawing.Point(282, 355);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(165, 41);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // LnkKayıtOl
            // 
            this.LnkKayıtOl.AutoSize = true;
            this.LnkKayıtOl.LinkColor = System.Drawing.Color.Azure;
            this.LnkKayıtOl.Location = new System.Drawing.Point(337, 457);
            this.LnkKayıtOl.Name = "LnkKayıtOl";
            this.LnkKayıtOl.Size = new System.Drawing.Size(120, 39);
            this.LnkKayıtOl.TabIndex = 5;
            this.LnkKayıtOl.TabStop = true;
            this.LnkKayıtOl.Text = "Kayıt Ol";
            this.LnkKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayıtOl_LinkClicked);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.Azure;
            this.BtnGirisYap.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnGirisYap.Location = new System.Drawing.Point(282, 402);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(165, 52);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(41, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kayıtlı Değil misiniz?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(161, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "HASTA GİRİŞ PANELI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastahaneSistemi.Properties.Resources.images_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Hasta
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(606, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.LnkKayıtOl);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "Hasta";
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.LinkLabel LnkKayıtOl;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}