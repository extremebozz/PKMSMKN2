namespace PKMSMKN2.Admin
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpHotel = new System.Windows.Forms.TabPage();
            this.tpService = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bHapusUser = new System.Windows.Forms.Button();
            this.bEditUser = new System.Windows.Forms.Button();
            this.bAddUser = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpHotel);
            this.tcMain.Controls.Add(this.tpService);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(100, 30);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(884, 611);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 1;
            // 
            // tpHotel
            // 
            this.tpHotel.Location = new System.Drawing.Point(4, 34);
            this.tpHotel.Name = "tpHotel";
            this.tpHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tpHotel.Size = new System.Drawing.Size(876, 573);
            this.tpHotel.TabIndex = 0;
            this.tpHotel.Text = "Hotel";
            this.tpHotel.UseVisualStyleBackColor = true;
            // 
            // tpService
            // 
            this.tpService.Location = new System.Drawing.Point(4, 34);
            this.tpService.Name = "tpService";
            this.tpService.Padding = new System.Windows.Forms.Padding(3);
            this.tpService.Size = new System.Drawing.Size(876, 573);
            this.tpService.TabIndex = 1;
            this.tpService.Text = "Service";
            this.tpService.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(876, 573);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Restoran";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(876, 573);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bHapusUser
            // 
            this.bHapusUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bHapusUser.Location = new System.Drawing.Point(57, 26);
            this.bHapusUser.Name = "bHapusUser";
            this.bHapusUser.Size = new System.Drawing.Size(109, 50);
            this.bHapusUser.TabIndex = 3;
            this.bHapusUser.Text = "Delete User";
            this.bHapusUser.UseVisualStyleBackColor = true;
            this.bHapusUser.Click += new System.EventHandler(this.bHapusUser_Click);
            // 
            // bEditUser
            // 
            this.bEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditUser.Location = new System.Drawing.Point(105, 144);
            this.bEditUser.Name = "bEditUser";
            this.bEditUser.Size = new System.Drawing.Size(109, 14);
            this.bEditUser.TabIndex = 2;
            this.bEditUser.Text = "Edit User";
            this.bEditUser.UseVisualStyleBackColor = true;
            this.bEditUser.Click += new System.EventHandler(this.bEditUser_Click);
            // 
            // bAddUser
            // 
            this.bAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddUser.Location = new System.Drawing.Point(77, 82);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(150, 14);
            this.bAddUser.TabIndex = 1;
            this.bAddUser.Text = "Tambah User";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.Size = new System.Drawing.Size(637, 567);
            this.dgvUser.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.tableLayoutPanel1.Controls.Add(this.dgvUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 573);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bHapusUser);
            this.panel1.Controls.Add(this.bEditUser);
            this.panel1.Controls.Add(this.bAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(646, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 567);
            this.panel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.tcMain);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tcMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpHotel;
        private System.Windows.Forms.TabPage tpService;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Button bEditUser;
        private System.Windows.Forms.Button bHapusUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}