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
            this.tNoKamar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tJenisKamar = new System.Windows.Forms.TextBox();
            this.tHargaPerMalam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.bPesanKamar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nExtraBed = new System.Windows.Forms.NumericUpDown();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nExtraBed)).BeginInit();
            this.SuspendLayout();
            // 
            // tNoKamar
            // 
            this.tNoKamar.Enabled = false;
            this.tNoKamar.Location = new System.Drawing.Point(122, 45);
            this.tNoKamar.Name = "tNoKamar";
            this.tNoKamar.Size = new System.Drawing.Size(50, 20);
            this.tNoKamar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomor Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Kamar";
            // 
            // tJenisKamar
            // 
            this.tJenisKamar.Enabled = false;
            this.tJenisKamar.Location = new System.Drawing.Point(281, 45);
            this.tJenisKamar.Name = "tJenisKamar";
            this.tJenisKamar.Size = new System.Drawing.Size(150, 20);
            this.tJenisKamar.TabIndex = 3;
            // 
            // tHargaPerMalam
            // 
            this.tHargaPerMalam.Enabled = false;
            this.tHargaPerMalam.Location = new System.Drawing.Point(559, 45);
            this.tHargaPerMalam.Name = "tHargaPerMalam";
            this.tHargaPerMalam.Size = new System.Drawing.Size(150, 20);
            this.tHargaPerMalam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga Per Hari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Check In";
            // 
            // dtCheckin
            // 
            this.dtCheckin.CustomFormat = "dd MMMM yyyy";
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckin.Location = new System.Drawing.Point(281, 91);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(150, 20);
            this.dtCheckin.TabIndex = 7;
            // 
            // bPesanKamar
            // 
            this.bPesanKamar.Location = new System.Drawing.Point(48, 149);
            this.bPesanKamar.Name = "bPesanKamar";
            this.bPesanKamar.Size = new System.Drawing.Size(150, 23);
            this.bPesanKamar.TabIndex = 8;
            this.bPesanKamar.Text = "Pesan";
            this.bPesanKamar.UseVisualStyleBackColor = true;
            this.bPesanKamar.Click += new System.EventHandler(this.bPesanKamar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Extra Bed";
            // 
            // nExtraBed
            // 
            this.nExtraBed.Location = new System.Drawing.Point(104, 91);
            this.nExtraBed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nExtraBed.Name = "nExtraBed";
            this.nExtraBed.Size = new System.Drawing.Size(50, 20);
            this.nExtraBed.TabIndex = 10;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.CustomFormat = "dd MMMM yyyy";
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.Location = new System.Drawing.Point(559, 91);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(150, 20);
            this.dtCheckOut.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal Check Out";
            // 
            // PesanKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nExtraBed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bPesanKamar);
            this.Controls.Add(this.dtCheckin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tHargaPerMalam);
            this.Controls.Add(this.tJenisKamar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNoKamar);
            this.Name = "PesanKamar";
            this.Text = "Pesan Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.nExtraBed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNoKamar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tJenisKamar;
        private System.Windows.Forms.TextBox tHargaPerMalam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.Button bPesanKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nExtraBed;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label6;
    }
}