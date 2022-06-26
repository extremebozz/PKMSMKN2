namespace PKMSMKN2.Restoran
{
    partial class AddFood
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
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.tNama = new System.Windows.Forms.TextBox();
            this.tHarga = new System.Windows.Forms.TextBox();
            this.bSimpan = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(191, 53);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 21);
            this.cbKategori.TabIndex = 0;
            // 
            // tNama
            // 
            this.tNama.Location = new System.Drawing.Point(211, 132);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(100, 20);
            this.tNama.TabIndex = 1;
            // 
            // tHarga
            // 
            this.tHarga.Location = new System.Drawing.Point(226, 218);
            this.tHarga.Name = "tHarga";
            this.tHarga.Size = new System.Drawing.Size(100, 20);
            this.tHarga.TabIndex = 2;
            // 
            // bSimpan
            // 
            this.bSimpan.Location = new System.Drawing.Point(259, 272);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(75, 23);
            this.bSimpan.TabIndex = 3;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(135, 271);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.tHarga);
            this.Controls.Add(this.tNama);
            this.Controls.Add(this.cbKategori);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tNama;
        private System.Windows.Forms.TextBox tHarga;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Button bCancel;
    }
}