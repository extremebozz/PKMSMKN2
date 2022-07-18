namespace PKMSMKN2.Hotel
{
    partial class Service
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
            this.bCallService = new System.Windows.Forms.Button();
            this.bExtraBed = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCallService
            // 
            this.bCallService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCallService.Location = new System.Drawing.Point(12, 11);
            this.bCallService.Name = "bCallService";
            this.bCallService.Size = new System.Drawing.Size(200, 50);
            this.bCallService.TabIndex = 4;
            this.bCallService.Text = "Call Room Service";
            this.bCallService.UseVisualStyleBackColor = true;
            this.bCallService.Click += new System.EventHandler(this.bCallService_Click);
            // 
            // bExtraBed
            // 
            this.bExtraBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExtraBed.Location = new System.Drawing.Point(12, 67);
            this.bExtraBed.Name = "bExtraBed";
            this.bExtraBed.Size = new System.Drawing.Size(200, 50);
            this.bExtraBed.TabIndex = 5;
            this.bExtraBed.Text = "Add Extra Bed";
            this.bExtraBed.UseVisualStyleBackColor = true;
            this.bExtraBed.Click += new System.EventHandler(this.bExtraBed_Click);
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(12, 123);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(200, 50);
            this.bClose.TabIndex = 6;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 185);
            this.Controls.Add(this.bCallService);
            this.Controls.Add(this.bExtraBed);
            this.Controls.Add(this.bClose);
            this.MaximumSize = new System.Drawing.Size(240, 224);
            this.MinimumSize = new System.Drawing.Size(240, 224);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCallService;
        private System.Windows.Forms.Button bExtraBed;
        private System.Windows.Forms.Button bClose;
    }
}