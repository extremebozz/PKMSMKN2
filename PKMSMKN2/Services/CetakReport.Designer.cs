
namespace PKMSMKN2.Services
{
    partial class CetakReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rRestoran = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bCetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAkhir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAwal = new System.Windows.Forms.DateTimePicker();
            this.MReportServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MReportInformasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MReportServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MReportInformasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rRestoran
            // 
            this.rRestoran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataService";
            reportDataSource1.Value = this.MReportServiceBindingSource;
            reportDataSource2.Name = "DataReport";
            reportDataSource2.Value = this.MReportInformasiBindingSource;
            this.rRestoran.LocalReport.DataSources.Add(reportDataSource1);
            this.rRestoran.LocalReport.DataSources.Add(reportDataSource2);
            this.rRestoran.LocalReport.ReportEmbeddedResource = "PKMSMKN2.Report.ReportService.rdlc";
            this.rRestoran.Location = new System.Drawing.Point(12, 53);
            this.rRestoran.Name = "rRestoran";
            this.rRestoran.ServerReport.BearerToken = null;
            this.rRestoran.Size = new System.Drawing.Size(776, 385);
            this.rRestoran.TabIndex = 11;
            this.rRestoran.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // bCetak
            // 
            this.bCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCetak.Location = new System.Drawing.Point(638, 12);
            this.bCetak.Name = "bCetak";
            this.bCetak.Size = new System.Drawing.Size(150, 30);
            this.bCetak.TabIndex = 10;
            this.bCetak.Text = "Cetak";
            this.bCetak.UseVisualStyleBackColor = true;
            this.bCetak.Click += new System.EventHandler(this.bCetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "to";
            // 
            // dtpAkhir
            // 
            this.dtpAkhir.CustomFormat = "dd MMMM yyyy";
            this.dtpAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAkhir.Location = new System.Drawing.Point(307, 14);
            this.dtpAkhir.Name = "dtpAkhir";
            this.dtpAkhir.Size = new System.Drawing.Size(175, 23);
            this.dtpAkhir.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tanggal : ";
            // 
            // dtpAwal
            // 
            this.dtpAwal.CustomFormat = "dd MMMM yyyy";
            this.dtpAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAwal.Location = new System.Drawing.Point(100, 14);
            this.dtpAwal.Name = "dtpAwal";
            this.dtpAwal.Size = new System.Drawing.Size(175, 23);
            this.dtpAwal.TabIndex = 6;
            // 
            // MReportServiceBindingSource
            // 
            this.MReportServiceBindingSource.DataSource = typeof(PKMSMKN2.Model.MReportService);
            // 
            // MReportInformasiBindingSource
            // 
            this.MReportInformasiBindingSource.DataSource = typeof(PKMSMKN2.Model.MReportInformasi);
            // 
            // CetakReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rRestoran);
            this.Controls.Add(this.bCetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpAkhir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAwal);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CetakReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cetak Report Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CetakReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MReportServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MReportInformasiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rRestoran;
        private System.Windows.Forms.Button bCetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAkhir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAwal;
        private System.Windows.Forms.BindingSource MReportServiceBindingSource;
        private System.Windows.Forms.BindingSource MReportInformasiBindingSource;
    }
}