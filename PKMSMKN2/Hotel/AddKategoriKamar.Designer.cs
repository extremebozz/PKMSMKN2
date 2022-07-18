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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKategoriKamar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tJenisKamar = new System.Windows.Forms.TextBox();
            this.tHarga = new System.Windows.Forms.TextBox();
            this.bTambah = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // tJenisKamar
            // 
            this.tJenisKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tJenisKamar.Location = new System.Drawing.Point(225, 65);
            this.tJenisKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tJenisKamar.Name = "tJenisKamar";
            this.tJenisKamar.Size = new System.Drawing.Size(298, 30);
            this.tJenisKamar.TabIndex = 2;
            // 
            // tHarga
            // 
            this.tHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHarga.Location = new System.Drawing.Point(225, 138);
            this.tHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tHarga.Name = "tHarga";
            this.tHarga.Size = new System.Drawing.Size(298, 30);
            this.tHarga.TabIndex = 3;
            this.tHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tHarga_KeyPress);
            this.tHarga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tHarga_KeyUp);
            // 
            // bTambah
            // 
            this.bTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTambah.Location = new System.Drawing.Point(225, 222);
            this.bTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(300, 62);
            this.bTambah.TabIndex = 4;
            this.bTambah.Text = "Tambah Kategori Kamar";
            this.bTambah.UseVisualStyleBackColor = true;
            this.bTambah.Click += new System.EventHandler(this.bTambah_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(72, 222);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(124, 62);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // AddKategoriKamar
            // 
            this.AcceptButton = this.bTambah;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(584, 302);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.tJenisKamar);
            this.Controls.Add(this.tHarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(606, 358);
            this.MinimumSize = new System.Drawing.Size(606, 358);
            this.Name = "AddKategoriKamar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button bCancel;
    }
}