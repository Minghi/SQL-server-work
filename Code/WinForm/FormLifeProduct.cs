﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormLifeProduct : Form
    {
        public FormLifeProduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            Productjxc.BLL.Product bll = new Productjxc.BLL.Product();
            this.dataGridView1.DataSource = bll.GetList(this.textBoxProNO.Text, this.textBoxProName.Text).Tables[0].DefaultView;
        }

        private void AddRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isLogin)
            {
                Insert formtemp = new Insert();
                formtemp.StartPosition = FormStartPosition.CenterScreen;
                formtemp.Show();
            } 
            else
            {
                contextMenuStrip1.Close();
                MessageBox.Show("请登录！", "提示");
            }
            
        }

        private void ModifyRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ProNO;
            int index = dataGridView1.CurrentRow.Index;
            ProNO = dataGridView1["ProNO", index].Value.ToString().Trim();
            Modify formtemp = new Modify(ProNO);
            formtemp.StartPosition = FormStartPosition.CenterScreen;
            formtemp.Show();
        }

        private void DeletRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ProNO;
            int index = dataGridView1.CurrentRow.Index;
            ProNO = dataGridView1["ProNO", index].Value.ToString().Trim();
            string sql = "delete Product where ProNO='" + ProNO + "'";
            if (MessageBox.Show("是否要删除？","提示",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Check.adminSql(sql))
                {
                    MessageBox.Show("删除成功！","提示");
                } 
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && Program.isLogin) 
            {
              //  ContextMenuStrip cm = new ContextMenuStrip();
                contextMenuStrip1.Show(MousePosition);
            } 
        }
    }
}
