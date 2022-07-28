namespace PKMSMKN2.Restoran
{
    partial class Pembayaran
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
            this.lTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tPembayaran = new System.Windows.Forms.TextBox();
            this.bBayar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(104, 30);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(25, 29);
            this.lTotal.TabIndex = 1;
            this.lTotal.Text = ": ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pembayaran";
            // 
            // tPembayaran
            // 
            this.tPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPembayaran.Location = new System.Drawing.Point(31, 98);
            this.tPembayaran.Name = "tPembayaran";
            this.tPembayaran.Size = new System.Drawing.Size(315, 23);
            this.tPembayaran.TabIndex = 3;
            this.tPembayaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPembayaran_KeyPress);
            this.tPembayaran.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tPembayaran_KeyUp);
            // 
            // bBayar
            // 
            this.bBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBayar.Location = new System.Drawing.Point(31, 149);
            this.bBayar.Name = "bBayar";
            this.bBayar.Size = new System.Drawing.Size(315, 40);
            this.bBayar.TabIndex = 4;
            this.bBayar.Text = "Bayar";
            this.bBayar.UseVisualStyleBackColor = true;
            this.bBayar.Click += new System.EventHandler(this.bBayar_Click);
            // 
            // Pembayaran
            // 
            this.AcceptButton = this.bBayar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 214);
            this.Controls.Add(this.bBayar);
            this.Controls.Add(this.tPembayaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(400, 253);
            this.Name = "Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPembayaran;
        private System.Windows.Forms.Button bBayar;
    }
}