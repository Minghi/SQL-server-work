namespace WinForm
{
    partial class FormStationeryProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonQuery);
            this.panel1.Controls.Add(this.textBoxProName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxProNO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 51);
            this.panel1.TabIndex = 0;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(495, 12);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 4;
            this.buttonQuery.Text = "查 询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxProName
            // 
            this.textBoxProName.Location = new System.Drawing.Point(274, 13);
            this.textBoxProName.Name = "textBoxProName";
            this.textBoxProName.Size = new System.Drawing.Size(100, 21);
            this.textBoxProName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名";
            // 
            // textBoxProNO
            // 
            this.textBoxProNO.Location = new System.Drawing.Point(88, 13);
            this.textBoxProNO.Name = "textBoxProNO";
            this.textBoxProNO.Size = new System.Drawing.Size(100, 21);
            this.textBoxProNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品号";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 380);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProNO,
            this.ProName,
            this.ProPrice,
            this.StoNO,
            this.StoCount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(697, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ProNO
            // 
            this.ProNO.DataPropertyName = "ProNO";
            this.ProNO.HeaderText = "商品号";
            this.ProNO.Name = "ProNO";
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "ProName";
            this.ProName.HeaderText = "商品名";
            this.ProName.Name = "ProName";
            // 
            // ProPrice
            // 
            this.ProPrice.DataPropertyName = "ProPrice";
            this.ProPrice.HeaderText = "商品单价";
            this.ProPrice.Name = "ProPrice";
            // 
            // StoNO
            // 
            this.StoNO.DataPropertyName = "StoNO";
            this.StoNO.HeaderText = "仓库号";
            this.StoNO.Name = "StoNO";
            // 
            // StoCount
            // 
            this.StoCount.DataPropertyName = "StoCount";
            this.StoCount.HeaderText = "库存量";
            this.StoCount.Name = "StoCount";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecordToolStripMenuItem,
            this.ModifyRecordToolStripMenuItem,
            this.DeletRecordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // AddRecordToolStripMenuItem
            // 
            this.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem";
            this.AddRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddRecordToolStripMenuItem.Text = "增加记录";
            this.AddRecordToolStripMenuItem.Click += new System.EventHandler(this.AddRecordToolStripMenuItem_Click);
            // 
            // ModifyRecordToolStripMenuItem
            // 
            this.ModifyRecordToolStripMenuItem.Name = "ModifyRecordToolStripMenuItem";
            this.ModifyRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ModifyRecordToolStripMenuItem.Text = "修改记录";
            this.ModifyRecordToolStripMenuItem.Click += new System.EventHandler(this.ModifyRecordToolStripMenuItem_Click);
            // 
            // DeletRecordToolStripMenuItem
            // 
            this.DeletRecordToolStripMenuItem.Name = "DeletRecordToolStripMenuItem";
            this.DeletRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeletRecordToolStripMenuItem.Text = "删除记录";
            this.DeletRecordToolStripMenuItem.Click += new System.EventHandler(this.DeletRecordToolStripMenuItem_Click);
            // 
            // FormStationeryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStationeryProduct";
            this.Text = "文具类";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxProName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletRecordToolStripMenuItem;
    }
}