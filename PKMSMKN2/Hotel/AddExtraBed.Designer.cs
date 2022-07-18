namespace PKMSMKN2.Hotel
{
    partial class AddExtraBed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExtraBed));
            this.label1 = new System.Windows.Forms.Label();
            this.nExtraBed = new System.Windows.Forms.NumericUpDown();
            this.bSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nExtraBed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra Bed";
            // 
            // nExtraBed
            // 
            this.nExtraBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nExtraBed.Location = new System.Drawing.Point(43, 60);
            this.nExtraBed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nExtraBed.Name = "nExtraBed";
            this.nExtraBed.Size = new System.Drawing.Size(150, 23);
            this.nExtraBed.TabIndex = 1;
            // 
            // bSimpan
            // 
            this.bSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSimpan.Location = new System.Drawing.Point(43, 98);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(150, 40);
            this.bSimpan.TabIndex = 2;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // AddExtraBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 172);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.nExtraBed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(257, 211);
            this.MinimumSize = new System.Drawing.Size(257, 211);
            this.Name = "AddExtraBed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Extra Bed";
            ((System.ComponentModel.ISupportInitialize)(this.nExtraBed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nExtraBed;
        private System.Windows.Forms.Button bSimpan;
    }
}