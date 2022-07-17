
namespace PKMSMKN2.Hotel
{
    partial class CetakFaktur
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetakFaktur));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mRoomTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMakananTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MInformasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mRoomTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMakananTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MInformasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataKamar";
            reportDataSource1.Value = this.mRoomTransaksiBindingSource;
            reportDataSource2.Name = "DataMakanan";
            reportDataSource2.Value = this.mMakananTransaksiBindingSource;
            reportDataSource3.Name = "DataInformasi";
            reportDataSource3.Value = this.MInformasiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PKMSMKN2.Report.Faktur.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1888, 1038);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // mRoomTransaksiBindingSource
            // 
            this.mRoomTransaksiBindingSource.DataSource = typeof(PKMSMKN2.Model.MRoomTransaksi);
            // 
            // mMakananTransaksiBindingSource
            // 
            this.mMakananTransaksiBindingSource.DataSource = typeof(PKMSMKN2.Model.MMakananTransaksi);
            // 
            // MInformasiBindingSource
            // 
            this.MInformasiBindingSource.DataSource = typeof(PKMSMKN2.Model.MInformasi);
            // 
            // CetakFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1909, 1078);
            this.Name = "CetakFaktur";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CetakFaktur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CetakFaktur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mRoomTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMakananTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MInformasiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mMakananTransaksiBindingSource;
        private System.Windows.Forms.BindingSource mRoomTransaksiBindingSource;
        private System.Windows.Forms.BindingSource MInformasiBindingSource;
    }
}