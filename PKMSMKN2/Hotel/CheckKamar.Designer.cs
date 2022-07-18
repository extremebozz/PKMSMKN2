namespace PKMSMKN2.Hotel
{
    partial class CheckKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckKamar));
            this.bCheck = new System.Windows.Forms.Button();
            this.dtTanggalCheck = new System.Windows.Forms.DateTimePicker();
            this.dtJamCheck = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lJenisKelamin = new System.Windows.Forms.Label();
            this.lIdentitas = new System.Windows.Forms.Label();
            this.lNama = new System.Windows.Forms.Label();
            this.gbInformasi = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.lCheckWaktu = new System.Windows.Forms.Label();
            this.lCheckTanggal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbInformasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(336, 137);
            this.bCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(225, 77);
            this.bCheck.TabIndex = 0;
            this.bCheck.Text = "Check In";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // dtTanggalCheck
            // 
            this.dtTanggalCheck.CustomFormat = "dd MMMM yyyy";
            this.dtTanggalCheck.Enabled = false;
            this.dtTanggalCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTanggalCheck.Location = new System.Drawing.Point(34, 74);
            this.dtTanggalCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTanggalCheck.Name = "dtTanggalCheck";
            this.dtTanggalCheck.Size = new System.Drawing.Size(260, 30);
            this.dtTanggalCheck.TabIndex = 1;
            // 
            // dtJamCheck
            // 
            this.dtJamCheck.CustomFormat = "HH:mm:ss";
            this.dtJamCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtJamCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJamCheck.Location = new System.Drawing.Point(336, 74);
            this.dtJamCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtJamCheck.Name = "dtJamCheck";
            this.dtJamCheck.ShowUpDown = true;
            this.dtJamCheck.Size = new System.Drawing.Size(186, 30);
            this.dtJamCheck.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lJenisKelamin);
            this.groupBox1.Controls.Add(this.lIdentitas);
            this.groupBox1.Controls.Add(this.lNama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(600, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Pelanggan";
            // 
            // lJenisKelamin
            // 
            this.lJenisKelamin.AutoSize = true;
            this.lJenisKelamin.Location = new System.Drawing.Point(30, 160);
            this.lJenisKelamin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lJenisKelamin.Name = "lJenisKelamin";
            this.lJenisKelamin.Size = new System.Drawing.Size(161, 25);
            this.lJenisKelamin.TabIndex = 2;
            this.lJenisKelamin.Text = "Jenis Kelamin   : ";
            // 
            // lIdentitas
            // 
            this.lIdentitas.AutoSize = true;
            this.lIdentitas.Location = new System.Drawing.Point(30, 103);
            this.lIdentitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIdentitas.Name = "lIdentitas";
            this.lIdentitas.Size = new System.Drawing.Size(151, 25);
            this.lIdentitas.TabIndex = 1;
            this.lIdentitas.Text = "Identitas           : ";
            // 
            // lNama
            // 
            this.lNama.AutoSize = true;
            this.lNama.Location = new System.Drawing.Point(30, 46);
            this.lNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNama.Name = "lNama";
            this.lNama.Size = new System.Drawing.Size(150, 25);
            this.lNama.TabIndex = 0;
            this.lNama.Text = "Nama               : ";
            // 
            // gbInformasi
            // 
            this.gbInformasi.Controls.Add(this.bCancel);
            this.gbInformasi.Controls.Add(this.lCheckWaktu);
            this.gbInformasi.Controls.Add(this.lCheckTanggal);
            this.gbInformasi.Controls.Add(this.bCheck);
            this.gbInformasi.Controls.Add(this.dtTanggalCheck);
            this.gbInformasi.Controls.Add(this.dtJamCheck);
            this.gbInformasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformasi.Location = new System.Drawing.Point(18, 245);
            this.gbInformasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformasi.Name = "gbInformasi";
            this.gbInformasi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformasi.Size = new System.Drawing.Size(600, 231);
            this.gbInformasi.TabIndex = 4;
            this.gbInformasi.TabStop = false;
            this.gbInformasi.Text = "Informasi Check ";
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(34, 137);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(225, 77);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lCheckWaktu
            // 
            this.lCheckWaktu.AutoSize = true;
            this.lCheckWaktu.Location = new System.Drawing.Point(332, 43);
            this.lCheckWaktu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCheckWaktu.Name = "lCheckWaktu";
            this.lCheckWaktu.Size = new System.Drawing.Size(136, 25);
            this.lCheckWaktu.TabIndex = 4;
            this.lCheckWaktu.Text = "Waktu Check ";
            // 
            // lCheckTanggal
            // 
            this.lCheckTanggal.AutoSize = true;
            this.lCheckTanggal.Location = new System.Drawing.Point(30, 43);
            this.lCheckTanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCheckTanggal.Name = "lCheckTanggal";
            this.lCheckTanggal.Size = new System.Drawing.Size(151, 25);
            this.lCheckTanggal.TabIndex = 3;
            this.lCheckTanggal.Text = "Tanggal Check ";
            // 
            // CheckKamar
            // 
            this.AcceptButton = this.bCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(636, 492);
            this.Controls.Add(this.gbInformasi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckKamar";
            this.Text = "Check In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInformasi.ResumeLayout(false);
            this.gbInformasi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.DateTimePicker dtTanggalCheck;
        private System.Windows.Forms.DateTimePicker dtJamCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lIdentitas;
        private System.Windows.Forms.Label lNama;
        private System.Windows.Forms.Label lJenisKelamin;
        private System.Windows.Forms.GroupBox gbInformasi;
        private System.Windows.Forms.Label lCheckWaktu;
        private System.Windows.Forms.Label lCheckTanggal;
        private System.Windows.Forms.Button bCancel;
    }
}