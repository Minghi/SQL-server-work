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
        string _ProNO;
        
        public Modify(string ProNO)
        {
            InitializeComponent();
            _ProNO = ProNO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            DataTable dt = Check.gettable("select * from Product");


            if (textBoxProNO.Text.Length != 0 && textBoxProName.Text.Length != 0 && textBoxProPrice.Text.Length != 0 && textBoxStoNO.Text.Length != 0 && textBoxStoCount.Text.Length != 0)
            {
                string sql = "update Product set ProName='" + textBoxProName.Text.Trim() + "',ProPrice='" + textBoxProPrice.Text.Trim() + "',StoNO='" + textBoxStoNO.Text.Trim() + "',StoCount='" + textBoxStoCount.Text.Trim() + "'where ProNO='" + _ProNO + "'";
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

        private void modify_Load(object sender, EventArgs e)
        {
            DataTable dt = Check.gettable("select * from Product where ProNO =  '" + _ProNO + "'");
            textBoxProNO.Text = _ProNO;
            textBoxProName.Text = dt.Rows[0][1].ToString().Trim();
            textBoxProPrice.Text = dt.Rows[0][2].ToString().Trim();
            textBoxStoNO.Text = dt.Rows[0][3].ToString().Trim();
            textBoxStoCount.Text = dt.Rows[0][4].ToString().Trim();
        }
    }
}
