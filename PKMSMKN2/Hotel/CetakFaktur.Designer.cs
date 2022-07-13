
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mMakananTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mRoomTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mMakananTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRoomTransaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataMakanan";
            reportDataSource1.Value = this.mMakananTransaksiBindingSource;
            reportDataSource2.Name = "DataKamar";
            reportDataSource2.Value = this.mRoomTransaksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PKMSMKN2.Report.Faktur.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1258, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // mMakananTransaksiBindingSource
            // 
            this.mMakananTransaksiBindingSource.DataSource = typeof(PKMSMKN2.Model.MMakananTransaksi);
            // 
            // mRoomTransaksiBindingSource
            // 
            this.mRoomTransaksiBindingSource.DataSource = typeof(PKMSMKN2.Model.MRoomTransaksi);
            // 
            // CetakFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CetakFaktur";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CetakFaktur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CetakFaktur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMakananTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRoomTransaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mMakananTransaksiBindingSource;
        private System.Windows.Forms.BindingSource mRoomTransaksiBindingSource;
    }
}