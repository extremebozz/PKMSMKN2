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
            this.bAddRoom = new System.Windows.Forms.Button();
            this.bAddRoomCategory = new System.Windows.Forms.Button();
            this.dgvJenisKamar = new System.Windows.Forms.DataGridView();
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.bCheckIn = new System.Windows.Forms.Button();
            this.bPesanKamar = new System.Windows.Forms.Button();
            this.bCheckOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKamar = new System.Windows.Forms.TabPage();
            this.tpJenisKamar = new System.Windows.Forms.TabPage();
            this.bEditRoom = new System.Windows.Forms.Button();
            this.bEditRoomCategory = new System.Windows.Forms.Button();
            this.bDeleteRoomCategory = new System.Windows.Forms.Button();
            this.bDeleteRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpKamar.SuspendLayout();
            this.tpJenisKamar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddRoom
            // 
            this.bAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddRoom.Location = new System.Drawing.Point(472, 10);
            this.bAddRoom.Name = "bAddRoom";
            this.bAddRoom.Size = new System.Drawing.Size(100, 23);
            this.bAddRoom.TabIndex = 1;
            this.bAddRoom.Text = "Tambah Kamar";
            this.bAddRoom.UseVisualStyleBackColor = true;
            this.bAddRoom.Click += new System.EventHandler(this.bAddRoom_Click);
            // 
            // bAddRoomCategory
            // 
            this.bAddRoomCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddRoomCategory.Location = new System.Drawing.Point(615, 26);
            this.bAddRoomCategory.Name = "bAddRoomCategory";
            this.bAddRoomCategory.Size = new System.Drawing.Size(150, 50);
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
            this.dgvJenisKamar.Location = new System.Drawing.Point(8, 10);
            this.dgvJenisKamar.Name = "dgvJenisKamar";
            this.dgvJenisKamar.ReadOnly = true;
            this.dgvJenisKamar.RowHeadersVisible = false;
            this.dgvJenisKamar.Size = new System.Drawing.Size(575, 406);
            this.dgvJenisKamar.TabIndex = 3;
            this.dgvJenisKamar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenisKamar_CellDoubleClick);
            // 
            // dgvKamar
            // 
            this.dgvKamar.AllowUserToAddRows = false;
            this.dgvKamar.AllowUserToDeleteRows = false;
            this.dgvKamar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamar.Location = new System.Drawing.Point(8, 44);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersVisible = false;
            this.dgvKamar.Size = new System.Drawing.Size(776, 372);
            this.dgvKamar.TabIndex = 4;
            this.dgvKamar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellDoubleClick);
            // 
            // bCheckIn
            // 
            this.bCheckIn.Location = new System.Drawing.Point(114, 10);
            this.bCheckIn.Name = "bCheckIn";
            this.bCheckIn.Size = new System.Drawing.Size(100, 23);
            this.bCheckIn.TabIndex = 5;
            this.bCheckIn.Text = "Check In";
            this.bCheckIn.UseVisualStyleBackColor = true;
            this.bCheckIn.Click += new System.EventHandler(this.bCheckIn_Click);
            // 
            // bPesanKamar
            // 
            this.bPesanKamar.Location = new System.Drawing.Point(8, 10);
            this.bPesanKamar.Name = "bPesanKamar";
            this.bPesanKamar.Size = new System.Drawing.Size(100, 23);
            this.bPesanKamar.TabIndex = 6;
            this.bPesanKamar.Text = "Pesan Kamar";
            this.bPesanKamar.UseVisualStyleBackColor = true;
            this.bPesanKamar.Click += new System.EventHandler(this.bPesanKamar_Click);
            // 
            // bCheckOut
            // 
            this.bCheckOut.Location = new System.Drawing.Point(220, 10);
            this.bCheckOut.Name = "bCheckOut";
            this.bCheckOut.Size = new System.Drawing.Size(100, 23);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 8;
            // 
            // tpKamar
            // 
            this.tpKamar.Controls.Add(this.dgvKamar);
            this.tpKamar.Controls.Add(this.bCheckOut);
            this.tpKamar.Controls.Add(this.bDeleteRoom);
            this.tpKamar.Controls.Add(this.bEditRoom);
            this.tpKamar.Controls.Add(this.bAddRoom);
            this.tpKamar.Controls.Add(this.bPesanKamar);
            this.tpKamar.Controls.Add(this.bCheckIn);
            this.tpKamar.Location = new System.Drawing.Point(4, 22);
            this.tpKamar.Name = "tpKamar";
            this.tpKamar.Padding = new System.Windows.Forms.Padding(3);
            this.tpKamar.Size = new System.Drawing.Size(792, 424);
            this.tpKamar.TabIndex = 0;
            this.tpKamar.Text = "Kamar";
            this.tpKamar.UseVisualStyleBackColor = true;
            // 
            // tpJenisKamar
            // 
            this.tpJenisKamar.Controls.Add(this.dgvJenisKamar);
            this.tpJenisKamar.Controls.Add(this.bDeleteRoomCategory);
            this.tpJenisKamar.Controls.Add(this.bEditRoomCategory);
            this.tpJenisKamar.Controls.Add(this.bAddRoomCategory);
            this.tpJenisKamar.Location = new System.Drawing.Point(4, 22);
            this.tpJenisKamar.Name = "tpJenisKamar";
            this.tpJenisKamar.Padding = new System.Windows.Forms.Padding(3);
            this.tpJenisKamar.Size = new System.Drawing.Size(792, 424);
            this.tpJenisKamar.TabIndex = 1;
            this.tpJenisKamar.Text = "Jenis Kamar";
            this.tpJenisKamar.UseVisualStyleBackColor = true;
            // 
            // bEditRoom
            // 
            this.bEditRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditRoom.Location = new System.Drawing.Point(578, 10);
            this.bEditRoom.Name = "bEditRoom";
            this.bEditRoom.Size = new System.Drawing.Size(100, 23);
            this.bEditRoom.TabIndex = 1;
            this.bEditRoom.Text = "Edit Kamar";
            this.bEditRoom.UseVisualStyleBackColor = true;
            // 
            // bEditRoomCategory
            // 
            this.bEditRoomCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditRoomCategory.Location = new System.Drawing.Point(615, 97);
            this.bEditRoomCategory.Name = "bEditRoomCategory";
            this.bEditRoomCategory.Size = new System.Drawing.Size(150, 50);
            this.bEditRoomCategory.TabIndex = 2;
            this.bEditRoomCategory.Text = "Edit Jenis Kamar";
            this.bEditRoomCategory.UseVisualStyleBackColor = true;
            this.bEditRoomCategory.Click += new System.EventHandler(this.bEditRoomCategory_Click);
            // 
            // bDeleteRoomCategory
            // 
            this.bDeleteRoomCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteRoomCategory.Location = new System.Drawing.Point(615, 168);
            this.bDeleteRoomCategory.Name = "bDeleteRoomCategory";
            this.bDeleteRoomCategory.Size = new System.Drawing.Size(150, 50);
            this.bDeleteRoomCategory.TabIndex = 2;
            this.bDeleteRoomCategory.Text = "Hapus Jenis Kamar";
            this.bDeleteRoomCategory.UseVisualStyleBackColor = true;
            this.bDeleteRoomCategory.Click += new System.EventHandler(this.bAddRoomCategory_Click);
            // 
            // bDeleteRoom
            // 
            this.bDeleteRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteRoom.Location = new System.Drawing.Point(684, 10);
            this.bDeleteRoom.Name = "bDeleteRoom";
            this.bDeleteRoom.Size = new System.Drawing.Size(100, 23);
            this.bDeleteRoom.TabIndex = 1;
            this.bDeleteRoom.Text = "Hapus Kamar";
            this.bDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpKamar.ResumeLayout(false);
            this.tpJenisKamar.ResumeLayout(false);
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
    }
}