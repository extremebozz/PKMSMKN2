namespace PKMSMKN2.Restoran
{
    partial class RMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMain));
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.bOrder = new System.Windows.Forms.Button();
            this.bReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKamar
            // 
            this.dgvKamar.AllowUserToAddRows = false;
            this.dgvKamar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKamar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKamar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKamar.Location = new System.Drawing.Point(13, 62);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.RowHeadersVisible = false;
            this.dgvKamar.RowHeadersWidth = 62;
            this.dgvKamar.RowTemplate.Height = 30;
            this.dgvKamar.Size = new System.Drawing.Size(774, 375);
            this.dgvKamar.TabIndex = 1;
            this.dgvKamar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellDoubleClick);
            // 
            // bOrder
            // 
            this.bOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrder.Location = new System.Drawing.Point(13, 13);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(150, 40);
            this.bOrder.TabIndex = 2;
            this.bOrder.Text = "Add Order";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // bReport
            // 
            this.bReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReport.Location = new System.Drawing.Point(637, 13);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(150, 40);
            this.bReport.TabIndex = 3;
            this.bReport.Text = "Cetak Report";
            this.bReport.UseVisualStyleBackColor = true;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
            // 
            // RMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bReport);
            this.Controls.Add(this.bOrder);
            this.Controls.Add(this.dgvKamar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RMain";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Text = "Restoran Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Button bReport;
    }
}