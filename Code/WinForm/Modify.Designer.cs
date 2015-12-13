namespace WinForm
{
    partial class Modify
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProNO = new System.Windows.Forms.TextBox();
            this.textBoxProName = new System.Windows.Forms.TextBox();
            this.textBoxProPrice = new System.Windows.Forms.TextBox();
            this.textBoxStoNO = new System.Windows.Forms.TextBox();
            this.textBoxStoCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "商 品 号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商 品 名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "商 品 单 价：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "库 存 量：";
            // 
            // textBoxProNO
            // 
            this.textBoxProNO.Location = new System.Drawing.Point(184, 90);
            this.textBoxProNO.Name = "textBoxProNO";
            this.textBoxProNO.Size = new System.Drawing.Size(100, 21);
            this.textBoxProNO.TabIndex = 17;
            // 
            // textBoxProName
            // 
            this.textBoxProName.Location = new System.Drawing.Point(184, 136);
            this.textBoxProName.Name = "textBoxProName";
            this.textBoxProName.Size = new System.Drawing.Size(100, 21);
            this.textBoxProName.TabIndex = 18;
            // 
            // textBoxProPrice
            // 
            this.textBoxProPrice.Location = new System.Drawing.Point(184, 186);
            this.textBoxProPrice.Name = "textBoxProPrice";
            this.textBoxProPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxProPrice.TabIndex = 19;
            // 
            // textBoxStoNO
            // 
            this.textBoxStoNO.Location = new System.Drawing.Point(184, 236);
            this.textBoxStoNO.Name = "textBoxStoNO";
            this.textBoxStoNO.Size = new System.Drawing.Size(100, 21);
            this.textBoxStoNO.TabIndex = 24;
            // 
            // textBoxStoCount
            // 
            this.textBoxStoCount.Location = new System.Drawing.Point(184, 286);
            this.textBoxStoCount.Name = "textBoxStoCount";
            this.textBoxStoCount.Size = new System.Drawing.Size(100, 21);
            this.textBoxStoCount.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "修 改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.modify_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "取 消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "仓 库 号：";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStoCount);
            this.Controls.Add(this.textBoxStoNO);
            this.Controls.Add(this.textBoxProPrice);
            this.Controls.Add(this.textBoxProName);
            this.Controls.Add(this.textBoxProNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modify";
            this.Text = "修改记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProNO;
        private System.Windows.Forms.TextBox textBoxProName;
        private System.Windows.Forms.TextBox textBoxProPrice;
        private System.Windows.Forms.TextBox textBoxStoNO;
        private System.Windows.Forms.TextBox textBoxStoCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}