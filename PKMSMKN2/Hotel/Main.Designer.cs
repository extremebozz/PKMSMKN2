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
            this.bAddRoom = new System.Windows.Forms.Button();
            this.bAddRoomCategory = new System.Windows.Forms.Button();
            this.dgvJenisKamar = new System.Windows.Forms.DataGridView();
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.bCheckIn = new System.Windows.Forms.Button();
            this.bPesanKamar = new System.Windows.Forms.Button();
            this.bCheckOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKamar = new System.Windows.Forms.TabPage();
            this.bRoomService = new System.Windows.Forms.Button();
            this.tpJenisKamar = new System.Windows.Forms.TabPage();
            this.tLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEditRoom = new System.Windows.Forms.Button();
            this.bDeleteRoom = new System.Windows.Forms.Button();
            this.dgvKonfirgurasiKamar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bDeleteRoomCategory = new System.Windows.Forms.Button();
            this.bEditRoomCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpKamar.SuspendLayout();
            this.tpJenisKamar.SuspendLayout();
            this.tLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonfirgurasiKamar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddRoom
            // 
            this.bAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddRoom.Location = new System.Drawing.Point(663, 39);
            this.bAddRoom.Name = "bAddRoom";
            this.bAddRoom.Size = new System.Drawing.Size(175, 50);
            this.bAddRoom.TabIndex = 1;
            this.bAddRoom.Text = "Tambah Kamar";
            this.bAddRoom.UseVisualStyleBackColor = true;
            this.bAddRoom.Click += new System.EventHandler(this.bAddRoom_Click);
            // 
            // bAddRoomCategory
            // 
            this.bAddRoomCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddRoomCategory.Location = new System.Drawing.Point(663, 48);
            this.bAddRoomCategory.Name = "bAddRoomCategory";
            this.bAddRoomCategory.Size = new System.Drawing.Size(175, 50);
            this.bAddRoomCategory.TabIndex = 2;
            this.bAddRoomCategory.Text = "Tambah Jenis Kamar";
            this.bAddRoomCategory.UseVisualStyleBackColor = true;
            this.bAddRoomCategory.Click += new System.EventHandler(this.bAddRoomCategory_Click);
            // 
            // dgvJenisKamar
            // 
            this.dgvJenisKamar.AllowUserToAddRows = false;
            this.dgvJenisKamar.AllowUserToDeleteRows = false;
            this.dgvJenisKamar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJenisKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJenisKamar.Location = new System.Drawing.Point(10, 21);
            this.dgvJenisKamar.Name = "dgvJenisKamar";
            this.dgvJenisKamar.ReadOnly = true;
            this.dgvJenisKamar.RowHeadersVisible = false;
            this.dgvJenisKamar.Size = new System.Drawing.Size(615, 220);
            this.dgvJenisKamar.TabIndex = 3;
            this.dgvJenisKamar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenisKamar_CellDoubleClick);
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
            this.dgvKamar.Location = new System.Drawing.Point(8, 70);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKamar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKamar.RowTemplate.Height = 30;
            this.dgvKamar.Size = new System.Drawing.Size(860, 445);
            this.dgvKamar.TabIndex = 4;
            this.dgvKamar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellDoubleClick);
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
            this.tpJenisKamar.Controls.Add(this.tLayout);
            this.tpJenisKamar.Location = new System.Drawing.Point(4, 34);
            this.tpJenisKamar.Name = "tpJenisKamar";
            this.tpJenisKamar.Padding = new System.Windows.Forms.Padding(3);
            this.tpJenisKamar.Size = new System.Drawing.Size(876, 523);
            this.tpJenisKamar.TabIndex = 1;
            this.tpJenisKamar.Text = "Konfigurasi Hotel";
            this.tpJenisKamar.UseVisualStyleBackColor = true;
            // 
            // tLayout
            // 
            this.tLayout.ColumnCount = 1;
            this.tLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout.Controls.Add(this.groupBox1, 0, 0);
            this.tLayout.Controls.Add(this.groupBox2, 0, 1);
            this.tLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayout.Location = new System.Drawing.Point(3, 3);
            this.tLayout.Name = "tLayout";
            this.tLayout.RowCount = 2;
            this.tLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout.Size = new System.Drawing.Size(870, 517);
            this.tLayout.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bEditRoom);
            this.groupBox1.Controls.Add(this.bDeleteRoom);
            this.groupBox1.Controls.Add(this.bAddRoom);
            this.groupBox1.Controls.Add(this.dgvKonfirgurasiKamar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 252);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamar";
            // 
            // bEditRoom
            // 
            this.bEditRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditRoom.Location = new System.Drawing.Point(663, 105);
            this.bEditRoom.Name = "bEditRoom";
            this.bEditRoom.Size = new System.Drawing.Size(175, 50);
            this.bEditRoom.TabIndex = 1;
            this.bEditRoom.Text = "Edit Kamar";
            this.bEditRoom.UseVisualStyleBackColor = true;
            this.bEditRoom.Click += new System.EventHandler(this.bEditRoom_Click);
            // 
            // bDeleteRoom
            // 
            this.bDeleteRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteRoom.Location = new System.Drawing.Point(663, 171);
            this.bDeleteRoom.Name = "bDeleteRoom";
            this.bDeleteRoom.Size = new System.Drawing.Size(175, 50);
            this.bDeleteRoom.TabIndex = 1;
            this.bDeleteRoom.Text = "Hapus Kamar";
            this.bDeleteRoom.UseVisualStyleBackColor = true;
            this.bDeleteRoom.Click += new System.EventHandler(this.bDeleteRoom_Click);
            // 
            // dgvKonfirgurasiKamar
            // 
            this.dgvKonfirgurasiKamar.AllowUserToAddRows = false;
            this.dgvKonfirgurasiKamar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvKonfirgurasiKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKonfirgurasiKamar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKonfirgurasiKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonfirgurasiKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonfirgurasiKamar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKonfirgurasiKamar.Location = new System.Drawing.Point(10, 21);
            this.dgvKonfirgurasiKamar.Name = "dgvKonfirgurasiKamar";
            this.dgvKonfirgurasiKamar.ReadOnly = true;
            this.dgvKonfirgurasiKamar.RowHeadersVisible = false;
            this.dgvKonfirgurasiKamar.Size = new System.Drawing.Size(615, 220);
            this.dgvKonfirgurasiKamar.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bDeleteRoomCategory);
            this.groupBox2.Controls.Add(this.dgvJenisKamar);
            this.groupBox2.Controls.Add(this.bEditRoomCategory);
            this.groupBox2.Controls.Add(this.bAddRoomCategory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 253);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jenis Kamar";
            // 
            // bDeleteRoomCategory
            // 
            this.bDeleteRoomCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteRoomCategory.Location = new System.Drawing.Point(663, 160);
            this.bDeleteRoomCategory.Name = "bDeleteRoomCategory";
            this.bDeleteRoomCategory.Size = new System.Drawing.Size(175, 50);
            this.bDeleteRoomCategory.TabIndex = 2;
            this.bDeleteRoomCategory.Text = "Hapus Jenis Kamar";
            this.bDeleteRoomCategory.UseVisualStyleBackColor = true;
            this.bDeleteRoomCategory.Click += new System.EventHandler(this.bAddRoomCategory_Click);
            // 
            // bEditRoomCategory
            // 
            this.bEditRoomCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditRoomCategory.Location = new System.Drawing.Point(663, 104);
            this.bEditRoomCategory.Name = "bEditRoomCategory";
            this.bEditRoomCategory.Size = new System.Drawing.Size(175, 50);
            this.bEditRoomCategory.TabIndex = 2;
            this.bEditRoomCategory.Text = "Edit Jenis Kamar";
            this.bEditRoomCategory.UseVisualStyleBackColor = true;
            this.bEditRoomCategory.Click += new System.EventHandler(this.bEditRoomCategory_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpKamar.ResumeLayout(false);
            this.tpJenisKamar.ResumeLayout(false);
            this.tLayout.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonfirgurasiKamar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAddRoom;
        private System.Windows.Forms.Button bAddRoomCategory;
        private System.Windows.Forms.DataGridView dgvJenisKamar;
        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.Button bCheckIn;
        private System.Windows.Forms.Button bPesanKamar;
        private System.Windows.Forms.Button bCheckOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpKamar;
        private System.Windows.Forms.TabPage tpJenisKamar;
        private System.Windows.Forms.Button bEditRoom;
        private System.Windows.Forms.Button bDeleteRoomCategory;
        private System.Windows.Forms.Button bEditRoomCategory;
        private System.Windows.Forms.Button bDeleteRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bRoomService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tLayout;
        private System.Windows.Forms.DataGridView dgvKonfirgurasiKamar;
    }
}