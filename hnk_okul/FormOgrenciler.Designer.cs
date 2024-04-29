namespace hnk_okul
{
    partial class FormOgrenciler
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
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.cbMezun = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.Arama = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.AllowUserToAddRows = false;
            this.dgwOgrenciler.AllowUserToDeleteRows = false;
            this.dgwOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(12, 216);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.ReadOnly = true;
            this.dgwOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOgrenciler.Size = new System.Drawing.Size(776, 222);
            this.dgwOgrenciler.TabIndex = 0;
            this.dgwOgrenciler.SelectionChanged += new System.EventHandler(this.dgwOgrenciler_SelectionChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(669, 155);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 42);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(669, 99);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 42);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(76, 152);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(136, 21);
            this.cmbCinsiyet.TabIndex = 24;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(76, 93);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(136, 20);
            this.dtTarih.TabIndex = 23;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(76, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(136, 20);
            this.txtSoyad.TabIndex = 22;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(76, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(136, 20);
            this.txtAd.TabIndex = 21;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(76, 15);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(136, 20);
            this.txtNo.TabIndex = 20;
            // 
            // cbMezun
            // 
            this.cbMezun.AutoSize = true;
            this.cbMezun.Location = new System.Drawing.Point(27, 193);
            this.cbMezun.Name = "cbMezun";
            this.cbMezun.Size = new System.Drawing.Size(58, 17);
            this.cbMezun.TabIndex = 19;
            this.cbMezun.Text = "Mezun";
            this.cbMezun.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dtarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Okul No";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(347, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(136, 20);
            this.txtArama.TabIndex = 27;
            // 
            // Arama
            // 
            this.Arama.AutoSize = true;
            this.Arama.Location = new System.Drawing.Point(264, 15);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(77, 13);
            this.Arama.TabIndex = 26;
            this.Arama.Text = "Öğrenci Arama";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(669, 41);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(108, 42);
            this.btnAra.TabIndex = 28;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FormOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.Arama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.cbMezun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwOgrenciler);
            this.Name = "FormOgrenciler";
            this.Text = "FormOgrenciler";
            this.Load += new System.EventHandler(this.FormOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.CheckBox cbMezun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label Arama;
        private System.Windows.Forms.Button btnAra;
    }
}