namespace PKMSMKN2.Restoran
{
    partial class OrderMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pKategori = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.lHarga = new System.Windows.Forms.Label();
            this.lMenu = new System.Windows.Forms.Label();
            this.bSimpan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pKategori, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pMenu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pKategori
            // 
            this.pKategori.AutoScroll = true;
            this.pKategori.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pKategori.Location = new System.Drawing.Point(0, 0);
            this.pKategori.Margin = new System.Windows.Forms.Padding(0);
            this.pKategori.Name = "pKategori";
            this.pKategori.Size = new System.Drawing.Size(200, 450);
            this.pKategori.TabIndex = 0;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.White;
            this.pMenu.Controls.Add(this.lHarga);
            this.pMenu.Controls.Add(this.lMenu);
            this.pMenu.Controls.Add(this.bSimpan);
            this.pMenu.Controls.Add(this.label3);
            this.pMenu.Controls.Add(this.nQty);
            this.pMenu.Controls.Add(this.label2);
            this.pMenu.Controls.Add(this.label1);
            this.pMenu.Controls.Add(this.dgvMenu);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMenu.Location = new System.Drawing.Point(200, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(600, 450);
            this.pMenu.TabIndex = 1;
            // 
            // lHarga
            // 
            this.lHarga.AutoSize = true;
            this.lHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHarga.Location = new System.Drawing.Point(472, 210);
            this.lHarga.Name = "lHarga";
            this.lHarga.Size = new System.Drawing.Size(0, 17);
            this.lHarga.TabIndex = 6;
            // 
            // lMenu
            // 
            this.lMenu.AutoSize = true;
            this.lMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenu.Location = new System.Drawing.Point(472, 69);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(0, 17);
            this.lMenu.TabIndex = 6;
            // 
            // bSimpan
            // 
            this.bSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSimpan.Location = new System.Drawing.Point(406, 309);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(150, 40);
            this.bSimpan.TabIndex = 5;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga : ";
            // 
            // nQty
            // 
            this.nQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nQty.Location = new System.Drawing.Point(475, 133);
            this.nQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(50, 26);
            this.nQty.TabIndex = 3;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qty     : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu  : ";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMenu.Location = new System.Drawing.Point(15, 15);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowTemplate.Height = 40;
            this.dgvMenu.Size = new System.Drawing.Size(350, 423);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderMenu_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pKategori;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Label lHarga;
        private System.Windows.Forms.Label lMenu;
    }
}