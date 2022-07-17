namespace PKMSMKN2.Restoran
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.bAddOrder = new System.Windows.Forms.Button();
            this.bEditOrder = new System.Windows.Forms.Button();
            this.bDeleteOrder = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrderList.Location = new System.Drawing.Point(16, 15);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowHeadersWidth = 62;
            this.dgvOrderList.RowTemplate.Height = 30;
            this.dgvOrderList.Size = new System.Drawing.Size(571, 422);
            this.dgvOrderList.TabIndex = 0;
            // 
            // bAddOrder
            // 
            this.bAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddOrder.Location = new System.Drawing.Point(617, 35);
            this.bAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bAddOrder.Name = "bAddOrder";
            this.bAddOrder.Size = new System.Drawing.Size(150, 40);
            this.bAddOrder.TabIndex = 1;
            this.bAddOrder.Text = "Add Order";
            this.bAddOrder.UseVisualStyleBackColor = true;
            this.bAddOrder.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEditOrder
            // 
            this.bEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditOrder.Location = new System.Drawing.Point(617, 92);
            this.bEditOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bEditOrder.Name = "bEditOrder";
            this.bEditOrder.Size = new System.Drawing.Size(150, 40);
            this.bEditOrder.TabIndex = 2;
            this.bEditOrder.Text = "Edit Order";
            this.bEditOrder.UseVisualStyleBackColor = true;
            this.bEditOrder.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDeleteOrder
            // 
            this.bDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteOrder.Location = new System.Drawing.Point(617, 148);
            this.bDeleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bDeleteOrder.Name = "bDeleteOrder";
            this.bDeleteOrder.Size = new System.Drawing.Size(150, 40);
            this.bDeleteOrder.TabIndex = 3;
            this.bDeleteOrder.Text = "Delete Order";
            this.bDeleteOrder.UseVisualStyleBackColor = true;
            this.bDeleteOrder.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(617, 377);
            this.bClose.Margin = new System.Windows.Forms.Padding(4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(150, 40);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total :";
            // 
            // lTotal
            // 
            this.lTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(669, 220);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(0, 25);
            this.lTotal.TabIndex = 6;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bDeleteOrder);
            this.Controls.Add(this.bEditOrder);
            this.Controls.Add(this.bAddOrder);
            this.Controls.Add(this.dgvOrderList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button bAddOrder;
        private System.Windows.Forms.Button bEditOrder;
        private System.Windows.Forms.Button bDeleteOrder;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTotal;
    }
}