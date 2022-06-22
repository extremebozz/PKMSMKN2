namespace PKMSMKN2.Services
{
    partial class ServiceMenu
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
            this.bDoneService = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bCallService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bDoneService
            // 
            this.bDoneService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDoneService.Location = new System.Drawing.Point(12, 68);
            this.bDoneService.Name = "bDoneService";
            this.bDoneService.Size = new System.Drawing.Size(200, 50);
            this.bDoneService.TabIndex = 2;
            this.bDoneService.Text = "Done Service";
            this.bDoneService.UseVisualStyleBackColor = true;
            this.bDoneService.Click += new System.EventHandler(this.bDoneService_Click);
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(12, 124);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(200, 50);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bCallService
            // 
            this.bCallService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCallService.Location = new System.Drawing.Point(12, 12);
            this.bCallService.Name = "bCallService";
            this.bCallService.Size = new System.Drawing.Size(200, 50);
            this.bCallService.TabIndex = 1;
            this.bCallService.Text = "Call Room Service";
            this.bCallService.UseVisualStyleBackColor = true;
            this.bCallService.Click += new System.EventHandler(this.bCallService_Click);
            // 
            // ServiceMenu
            // 
            this.AcceptButton = this.bDoneService;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(224, 185);
            this.Controls.Add(this.bCallService);
            this.Controls.Add(this.bDoneService);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 167);
            this.Name = "ServiceMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kamar X";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDoneService;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bCallService;
    }
}