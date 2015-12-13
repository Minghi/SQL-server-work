using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (textBoxProNO.Text.Length!=0 && textBoxProName.Text.Length!=0 && textBoxProPrice.Text.Length!=0 && textBoxStoNO.Text.Length!=0 && textBoxStoNO.Text.Length!=0)
            {
                string sql = "insert into Product(ProNO,ProName,ProPrice,StoNO,StoCount)values('" + textBoxProNO.Text.Trim() + "','" + textBoxProName.Text.Trim() + "','" + textBoxProPrice.Text.Trim() + "','" + textBoxStoNO.Text.Trim() + "','" + textBoxStoCount.Text.Trim() + "')";
                if (Check.adminSql(sql))
                {
                    MessageBox.Show("插入成功！");
                    this.Close();
                } 
                else
                {
                    MessageBox.Show("插入失败！");
                }
            } 
            else
            {
                MessageBox.Show("完整信息请填写！");
            }
        }
        
    }
}
