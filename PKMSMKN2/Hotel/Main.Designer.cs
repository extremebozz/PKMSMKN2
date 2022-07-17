namespace PKMSMKN2.Hotel
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.bCheckIn = new System.Windows.Forms.Button();
            this.bPesanKamar = new System.Windows.Forms.Button();
            this.bCheckOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKamar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.bRoomService = new System.Windows.Forms.Button();
            this.tpJenisKamar = new System.Windows.Forms.TabPage();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpKamar.SuspendLayout();
            this.tpJenisKamar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
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
            this.dgvKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKamar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKamar.Location = new System.Drawing.Point(12, 108);
            this.dgvKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersVisible = false;
            this.dgvKamar.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKamar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKamar.RowTemplate.Height = 30;
            this.dgvKamar.Size = new System.Drawing.Size(1290, 685);
            this.dgvKamar.TabIndex = 4;
            // 
            // bCheckIn
            // 
            this.bCheckIn.Location = new System.Drawing.Point(246, 15);
            this.bCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCheckIn.Name = "bCheckIn";
            this.bCheckIn.Size = new System.Drawing.Size(225, 77);
            this.bCheckIn.TabIndex = 5;
            this.bCheckIn.Text = "Check In";
            this.bCheckIn.UseVisualStyleBackColor = true;
            this.bCheckIn.Click += new System.EventHandler(this.bCheckIn_Click);
            // 
            // bPesanKamar
            // 
            this.bPesanKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPesanKamar.Location = new System.Drawing.Point(12, 15);
            this.bPesanKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPesanKamar.Name = "bPesanKamar";
            this.bPesanKamar.Size = new System.Drawing.Size(225, 77);
            this.bPesanKamar.TabIndex = 6;
            this.bPesanKamar.Text = "Pesan Kamar";
            this.bPesanKamar.UseVisualStyleBackColor = true;
            this.bPesanKamar.Click += new System.EventHandler(this.bPesanKamar_Click);
            // 
            // bCheckOut
            // 
            this.bCheckOut.Location = new System.Drawing.Point(480, 15);
            this.bCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCheckOut.Name = "bCheckOut";
            this.bCheckOut.Size = new System.Drawing.Size(225, 77);
            this.bCheckOut.TabIndex = 7;
            this.bCheckOut.Text = "Check Out";
            this.bCheckOut.UseVisualStyleBackColor = true;
            this.bCheckOut.Click += new System.EventHandler(this.bCheckOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpKamar);
            this.tabControl1.Controls.Add(this.tpJenisKamar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1326, 863);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            // 
            // tpKamar
            // 
            this.tpKamar.Controls.Add(this.button1);
            this.tpKamar.Controls.Add(this.bRoomService);
            this.tpKamar.Controls.Add(this.dgvKamar);
            this.tpKamar.Controls.Add(this.bCheckOut);
            this.tpKamar.Controls.Add(this.bPesanKamar);
            this.tpKamar.Controls.Add(this.bCheckIn);
            this.tpKamar.Location = new System.Drawing.Point(4, 34);
            this.tpKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpKamar.Name = "tpKamar";
            this.tpKamar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpKamar.Size = new System.Drawing.Size(1318, 825);
            this.tpKamar.TabIndex = 0;
            this.tpKamar.Text = "Kamar";
            this.tpKamar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 77);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cetak Faktur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRoomService
            // 
            this.bRoomService.Location = new System.Drawing.Point(714, 15);
            this.bRoomService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRoomService.Name = "bRoomService";
            this.bRoomService.Size = new System.Drawing.Size(225, 77);
            this.bRoomService.TabIndex = 8;
            this.bRoomService.Text = "Room Service";
            this.bRoomService.UseVisualStyleBackColor = true;
            this.bRoomService.Click += new System.EventHandler(this.bRoomService_Click);
            // 
            // tpJenisKamar
            // 
            this.tpJenisKamar.Controls.Add(this.dgvTransaksi);
            this.tpJenisKamar.Location = new System.Drawing.Point(4, 34);
            this.tpJenisKamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpJenisKamar.Name = "tpJenisKamar";
            this.tpJenisKamar.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tpJenisKamar.Size = new System.Drawing.Size(1318, 825);
            this.tpJenisKamar.TabIndex = 1;
            this.tpJenisKamar.Text = "Riwayat Transaksi";
            this.tpJenisKamar.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaksi.Location = new System.Drawing.Point(8, 8);
            this.dgvTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersVisible = false;
            this.dgvTransaksi.RowHeadersWidth = 62;
            this.dgvTransaksi.RowTemplate.Height = 40;
            this.dgvTransaksi.RowTemplate.ReadOnly = true;
            this.dgvTransaksi.Size = new System.Drawing.Size(1302, 809);
            this.dgvTransaksi.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpKamar.ResumeLayout(false);
            this.tpJenisKamar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.Button bCheckIn;
        private System.Windows.Forms.Button bPesanKamar;
        private System.Windows.Forms.Button bCheckOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpKamar;
        private System.Windows.Forms.TabPage tpJenisKamar;
        private System.Windows.Forms.Button bRoomService;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Button button1;
    }
}