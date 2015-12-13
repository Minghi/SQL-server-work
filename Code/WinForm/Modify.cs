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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (textBoxProNO.Text.Length != 0 && textBoxProName.Text.Length != 0 && textBoxProPrice.Text.Length != 0 && textBoxStoNO.Text.Length != 0 && textBoxStoCount.Text.Length != 0)
            {
                string sql = "update Product set ProNO='" + textBoxProNO.Text.Trim() + "',ProPrice='" + textBoxProPrice.Text.Trim() + "',StoNO='" + textBoxStoNO.Text.Trim() + "',StoCount='" + textBoxStoCount.Text.Trim() + "'where ProName='" + textBoxProName.Text.Trim() + "'";
                if (Check.adminSql(sql))
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else
            {
                MessageBox.Show("完整信息请填写！");
            }
        }


    }
}
