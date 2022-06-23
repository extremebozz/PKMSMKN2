namespace PKMSMKN2.Hotel
{
    partial class PesanKamar
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
            this.lNoKamar = new System.Windows.Forms.Label();
            this.lJenisKamar = new System.Windows.Forms.Label();
            this.lHargaKamar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.bPesanKamar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nExtraBed = new System.Windows.Forms.NumericUpDown();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tNamaPemesan = new System.Windows.Forms.TextBox();
            this.tNomorIdentitas = new System.Windows.Forms.TextBox();
            this.cbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.lTotalHari = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lTotalTrasansaksi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nExtraBed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNoKamar
            // 
            this.lNoKamar.AutoSize = true;
            this.lNoKamar.Location = new System.Drawing.Point(15, 30);
            this.lNoKamar.Name = "lNoKamar";
            this.lNoKamar.Size = new System.Drawing.Size(115, 17);
            this.lNoKamar.TabIndex = 1;
            this.lNoKamar.Text = "Nomor Kamar   : ";
            // 
            // lJenisKamar
            // 
            this.lJenisKamar.AutoSize = true;
            this.lJenisKamar.Location = new System.Drawing.Point(15, 67);
            this.lJenisKamar.Name = "lJenisKamar";
            this.lJenisKamar.Size = new System.Drawing.Size(114, 17);
            this.lJenisKamar.TabIndex = 2;
            this.lJenisKamar.Text = "Jenis Kamar     : ";
            // 
            // lHargaKamar
            // 
            this.lHargaKamar.AutoSize = true;
            this.lHargaKamar.Location = new System.Drawing.Point(15, 104);
            this.lHargaKamar.Name = "lHargaKamar";
            this.lHargaKamar.Size = new System.Drawing.Size(115, 17);
            this.lHargaKamar.TabIndex = 5;
            this.lHargaKamar.Text = "Harga Per Hari : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Check In";
            // 
            // dtCheckin
            // 
            this.dtCheckin.CustomFormat = "dd MMMM yyyy";
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckin.Location = new System.Drawing.Point(212, 139);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(175, 23);
            this.dtCheckin.TabIndex = 3;
            this.dtCheckin.ValueChanged += new System.EventHandler(this.dtCheck_ValueChanged);
            // 
            // bPesanKamar
            // 
            this.bPesanKamar.BackColor = System.Drawing.Color.Silver;
            this.bPesanKamar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bPesanKamar.FlatAppearance.BorderSize = 0;
            this.bPesanKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPesanKamar.Location = new System.Drawing.Point(261, 268);
            this.bPesanKamar.Name = "bPesanKamar";
            this.bPesanKamar.Size = new System.Drawing.Size(220, 40);
            this.bPesanKamar.TabIndex = 6;
            this.bPesanKamar.Text = "Pesan";
            this.bPesanKamar.UseVisualStyleBackColor = false;
            this.bPesanKamar.Click += new System.EventHandler(this.bPesanKamar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Extra Bed";
            // 
            // nExtraBed
            // 
            this.nExtraBed.Location = new System.Drawing.Point(212, 213);
            this.nExtraBed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nExtraBed.Name = "nExtraBed";
            this.nExtraBed.Size = new System.Drawing.Size(50, 23);
            this.nExtraBed.TabIndex = 5;
            this.nExtraBed.ValueChanged += new System.EventHandler(this.nExtraBed_ValueChanged);
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.CustomFormat = "dd MMMM yyyy";
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.Location = new System.Drawing.Point(212, 176);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(175, 23);
            this.dtCheckOut.TabIndex = 4;
            this.dtCheckOut.ValueChanged += new System.EventHandler(this.dtCheck_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal Check Out";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lNoKamar);
            this.groupBox1.Controls.Add(this.lJenisKamar);
            this.groupBox1.Controls.Add(this.lHargaKamar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(521, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Kamar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tNamaPemesan);
            this.groupBox2.Controls.Add(this.tNomorIdentitas);
            this.groupBox2.Controls.Add(this.cbJenisKelamin);
            this.groupBox2.Controls.Add(this.dtCheckin);
            this.groupBox2.Controls.Add(this.dtCheckOut);
            this.groupBox2.Controls.Add(this.nExtraBed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bPesanKamar);
            this.groupBox2.Controls.Add(this.bCancel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 338);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi Pemesan";
            // 
            // tNamaPemesan
            // 
            this.tNamaPemesan.Location = new System.Drawing.Point(212, 27);
            this.tNamaPemesan.Name = "tNamaPemesan";
            this.tNamaPemesan.Size = new System.Drawing.Size(269, 23);
            this.tNamaPemesan.TabIndex = 0;
            // 
            // tNomorIdentitas
            // 
            this.tNomorIdentitas.Location = new System.Drawing.Point(212, 64);
            this.tNomorIdentitas.Name = "tNomorIdentitas";
            this.tNomorIdentitas.Size = new System.Drawing.Size(269, 23);
            this.tNomorIdentitas.TabIndex = 1;
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.BackColor = System.Drawing.Color.Silver;
            this.cbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisKelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbJenisKelamin.FormattingEnabled = true;
            this.cbJenisKelamin.Location = new System.Drawing.Point(212, 101);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(121, 24);
            this.cbJenisKelamin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor KTP / Passport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pemesan";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Silver;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Location = new System.Drawing.Point(23, 268);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(220, 40);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lTotalHari
            // 
            this.lTotalHari.AutoSize = true;
            this.lTotalHari.Location = new System.Drawing.Point(15, 33);
            this.lTotalHari.Name = "lTotalHari";
            this.lTotalHari.Size = new System.Drawing.Size(118, 17);
            this.lTotalHari.TabIndex = 6;
            this.lTotalHari.Text = "Total Hari          : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lTotalTrasansaksi);
            this.groupBox3.Controls.Add(this.lTotalHari);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(521, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 193);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informasi Pesanan";
            // 
            // lTotalTrasansaksi
            // 
            this.lTotalTrasansaksi.AutoSize = true;
            this.lTotalTrasansaksi.Location = new System.Drawing.Point(15, 70);
            this.lTotalTrasansaksi.Name = "lTotalTrasansaksi";
            this.lTotalTrasansaksi.Size = new System.Drawing.Size(136, 17);
            this.lTotalTrasansaksi.TabIndex = 7;
            this.lTotalTrasansaksi.Text = "Total Transaksi : Rp";
            // 
            // PesanKamar
            // 
            this.AcceptButton = this.bPesanKamar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesanKamar";
            this.Text = "Pesan Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.nExtraBed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lNoKamar;
        private System.Windows.Forms.Label lJenisKamar;
        private System.Windows.Forms.Label lHargaKamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.Button bPesanKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nExtraBed;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tNomorIdentitas;
        private System.Windows.Forms.TextBox tNamaPemesan;
        private System.Windows.Forms.ComboBox cbJenisKelamin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lTotalHari;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lTotalTrasansaksi;
    }
}