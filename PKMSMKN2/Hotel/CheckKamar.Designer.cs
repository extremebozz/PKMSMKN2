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
            this.bCheck = new System.Windows.Forms.Button();
            this.dtTanggalCheck = new System.Windows.Forms.DateTimePicker();
            this.dtJamCheck = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(150, 179);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 23);
            this.bCheck.TabIndex = 0;
            this.bCheck.Text = "Check Out";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // dtTanggalCheck
            // 
            this.dtTanggalCheck.CustomFormat = "dd MMMM yyyy";
            this.dtTanggalCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTanggalCheck.Location = new System.Drawing.Point(103, 124);
            this.dtTanggalCheck.Name = "dtTanggalCheck";
            this.dtTanggalCheck.Size = new System.Drawing.Size(150, 20);
            this.dtTanggalCheck.TabIndex = 1;
            // 
            // dtJamCheck
            // 
            this.dtJamCheck.CustomFormat = "HH:mm:ss";
            this.dtJamCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJamCheck.Location = new System.Drawing.Point(270, 124);
            this.dtJamCheck.Name = "dtJamCheck";
            this.dtJamCheck.ShowUpDown = true;
            this.dtJamCheck.Size = new System.Drawing.Size(75, 20);
            this.dtJamCheck.TabIndex = 2;
            // 
            // CheckKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtJamCheck);
            this.Controls.Add(this.dtTanggalCheck);
            this.Controls.Add(this.bCheck);
            this.Name = "CheckKamar";
            this.Text = "Check In";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.DateTimePicker dtTanggalCheck;
        private System.Windows.Forms.DateTimePicker dtJamCheck;
    }
}