﻿namespace PKMSMKN2.Restoran
{
    partial class LinkRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKamar = new System.Windows.Forms.ComboBox();
            this.lNama = new System.Windows.Forms.Label();
            this.bLink = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lNama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(400, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // cbKamar
            // 
            this.cbKamar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKamar.FormattingEnabled = true;
            this.cbKamar.Location = new System.Drawing.Point(18, 124);
            this.cbKamar.Name = "cbKamar";
            this.cbKamar.Size = new System.Drawing.Size(400, 33);
            this.cbKamar.TabIndex = 1;
            this.cbKamar.SelectedIndexChanged += new System.EventHandler(this.cbKamar_SelectedIndexChanged);
            // 
            // lNama
            // 
            this.lNama.AutoSize = true;
            this.lNama.Location = new System.Drawing.Point(150, 43);
            this.lNama.Name = "lNama";
            this.lNama.Size = new System.Drawing.Size(64, 25);
            this.lNama.TabIndex = 1;
            this.lNama.Text = "label2";
            // 
            // bLink
            // 
            this.bLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLink.Location = new System.Drawing.Point(18, 176);
            this.bLink.Name = "bLink";
            this.bLink.Size = new System.Drawing.Size(400, 80);
            this.bLink.TabIndex = 2;
            this.bLink.Text = "Link";
            this.bLink.UseVisualStyleBackColor = true;
            this.bLink.Click += new System.EventHandler(this.bLink_Click);
            // 
            // LinkRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 275);
            this.Controls.Add(this.bLink);
            this.Controls.Add(this.cbKamar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(458, 229);
            this.Name = "LinkRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LinkRoom_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKamar;
        private System.Windows.Forms.Label lNama;
        private System.Windows.Forms.Button bLink;
    }
}