namespace PKMSMKN2.Hotel
{
    partial class AddKamar
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
            this.cbJenisKamar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nNomorKamar = new System.Windows.Forms.NumericUpDown();
            this.bTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNomorKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJenisKamar
            // 
            this.cbJenisKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJenisKamar.FormattingEnabled = true;
            this.cbJenisKamar.Location = new System.Drawing.Point(279, 67);
            this.cbJenisKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbJenisKamar.Name = "cbJenisKamar";
            this.cbJenisKamar.Size = new System.Drawing.Size(180, 33);
            this.cbJenisKamar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jenis Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Kamar";
            // 
            // nNomorKamar
            // 
            this.nNomorKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNomorKamar.Location = new System.Drawing.Point(279, 133);
            this.nNomorKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nNomorKamar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nNomorKamar.Name = "nNomorKamar";
            this.nNomorKamar.Size = new System.Drawing.Size(182, 30);
            this.nNomorKamar.TabIndex = 4;
            // 
            // bTambah
            // 
            this.bTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTambah.Location = new System.Drawing.Point(279, 217);
            this.bTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(182, 35);
            this.bTambah.TabIndex = 5;
            this.bTambah.Text = "Tambah";
            this.bTambah.UseVisualStyleBackColor = true;
            this.bTambah.Click += new System.EventHandler(this.bTambah_Click);
            // 
            // AddKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.nNomorKamar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJenisKamar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddKamar";
            this.Text = "Tambah Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.nNomorKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJenisKamar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNomorKamar;
        private System.Windows.Forms.Button bTambah;
    }
}