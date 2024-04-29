namespace hnk_okul
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
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgrenciler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(58, 76);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(162, 67);
            this.btnOgrenciEkle.TabIndex = 0;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.Location = new System.Drawing.Point(249, 76);
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.Size = new System.Drawing.Size(162, 67);
            this.btnOgrenciler.TabIndex = 1;
            this.btnOgrenciler.Text = "Öğrenciler";
            this.btnOgrenciler.UseVisualStyleBackColor = true;
            this.btnOgrenciler.Click += new System.EventHandler(this.btnOgrenciler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 218);
            this.Controls.Add(this.btnOgrenciler);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciler;
    }
}

