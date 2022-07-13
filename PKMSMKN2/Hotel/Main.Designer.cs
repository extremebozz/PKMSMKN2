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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.bCheckIn = new System.Windows.Forms.Button();
            this.bPesanKamar = new System.Windows.Forms.Button();
            this.bCheckOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKamar = new System.Windows.Forms.TabPage();
            this.bRoomService = new System.Windows.Forms.Button();
            this.tpJenisKamar = new System.Windows.Forms.TabPage();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvKamar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKamar.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvKamar.Location = new System.Drawing.Point(8, 70);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKamar.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKamar.RowTemplate.Height = 30;
            this.dgvKamar.Size = new System.Drawing.Size(860, 445);
            this.dgvKamar.TabIndex = 4;
            // 
            // bCheckIn
            // 
            this.bCheckIn.Location = new System.Drawing.Point(164, 10);
            this.bCheckIn.Name = "bCheckIn";
            this.bCheckIn.Size = new System.Drawing.Size(150, 50);
            this.bCheckIn.TabIndex = 5;
            this.bCheckIn.Text = "Check In";
            this.bCheckIn.UseVisualStyleBackColor = true;
            this.bCheckIn.Click += new System.EventHandler(this.bCheckIn_Click);
            // 
            // bPesanKamar
            // 
            this.bPesanKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPesanKamar.Location = new System.Drawing.Point(8, 10);
            this.bPesanKamar.Name = "bPesanKamar";
            this.bPesanKamar.Size = new System.Drawing.Size(150, 50);
            this.bPesanKamar.TabIndex = 6;
            this.bPesanKamar.Text = "Pesan Kamar";
            this.bPesanKamar.UseVisualStyleBackColor = true;
            this.bPesanKamar.Click += new System.EventHandler(this.bPesanKamar_Click);
            // 
            // bCheckOut
            // 
            this.bCheckOut.Location = new System.Drawing.Point(320, 10);
            this.bCheckOut.Name = "bCheckOut";
            this.bCheckOut.Size = new System.Drawing.Size(150, 50);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 561);
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
            this.tpKamar.Name = "tpKamar";
            this.tpKamar.Padding = new System.Windows.Forms.Padding(3);
            this.tpKamar.Size = new System.Drawing.Size(876, 523);
            this.tpKamar.TabIndex = 0;
            this.tpKamar.Text = "Kamar";
            this.tpKamar.UseVisualStyleBackColor = true;
            // 
            // bRoomService
            // 
            this.bRoomService.Location = new System.Drawing.Point(476, 10);
            this.bRoomService.Name = "bRoomService";
            this.bRoomService.Size = new System.Drawing.Size(150, 50);
            this.bRoomService.TabIndex = 8;
            this.bRoomService.Text = "Room Service";
            this.bRoomService.UseVisualStyleBackColor = true;
            this.bRoomService.Click += new System.EventHandler(this.bRoomService_Click);
            // 
            // tpJenisKamar
            // 
            this.tpJenisKamar.Controls.Add(this.dgvTransaksi);
            this.tpJenisKamar.Location = new System.Drawing.Point(4, 34);
            this.tpJenisKamar.Name = "tpJenisKamar";
            this.tpJenisKamar.Padding = new System.Windows.Forms.Padding(5);
            this.tpJenisKamar.Size = new System.Drawing.Size(876, 523);
            this.tpJenisKamar.TabIndex = 1;
            this.tpJenisKamar.Text = "Riwayat Transaksi";
            this.tpJenisKamar.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaksi.Location = new System.Drawing.Point(5, 5);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersVisible = false;
            this.dgvTransaksi.RowTemplate.Height = 40;
            this.dgvTransaksi.RowTemplate.ReadOnly = true;
            this.dgvTransaksi.Size = new System.Drawing.Size(866, 513);
            this.dgvTransaksi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cetak Faktur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
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