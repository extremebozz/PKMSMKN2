namespace PKMSMKN2.Hotel
{
    partial class AddKategoriKamar
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
            this.tJenisKamar = new System.Windows.Forms.TextBox();
            this.tHarga = new System.Windows.Forms.TextBox();
            this.bTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // tJenisKamar
            // 
            this.tJenisKamar.Location = new System.Drawing.Point(232, 60);
            this.tJenisKamar.Name = "tJenisKamar";
            this.tJenisKamar.Size = new System.Drawing.Size(100, 20);
            this.tJenisKamar.TabIndex = 2;
            // 
            // tHarga
            // 
            this.tHarga.Location = new System.Drawing.Point(232, 109);
            this.tHarga.Name = "tHarga";
            this.tHarga.Size = new System.Drawing.Size(100, 20);
            this.tHarga.TabIndex = 3;
            // 
            // bTambah
            // 
            this.bTambah.Location = new System.Drawing.Point(147, 157);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(185, 23);
            this.bTambah.TabIndex = 4;
            this.bTambah.Text = "Tambah Kategori Kamar";
            this.bTambah.UseVisualStyleBackColor = true;
            this.bTambah.Click += new System.EventHandler(this.bTambah_Click);
            // 
            // AddKategoriKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.tJenisKamar);
            this.Controls.Add(this.tHarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddKategoriKamar";
            this.Text = "Tambah Jenis Kamar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tJenisKamar;
        private System.Windows.Forms.TextBox tHarga;
        private System.Windows.Forms.Button bTambah;
    }
}