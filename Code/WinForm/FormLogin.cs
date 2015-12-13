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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserId.Text.Length!=0&&textBoxUserPwd.Text.Length!=0)
            {
                if (Check.checkUser(textBoxUserId.Text.Trim(),textBoxUserPwd.Text.Trim()))
                {
                    Program.isLogin = true;
                    FormMainNew formtemp = new FormMainNew();
                  //  this.DialogResult = DialogResult.OK;
                    this.Hide();
                    formtemp.Show();

                } 
      /*          else
                {
                    MessageBox.Show("用户名或密码错误，请重试！", "提示");
                }
                */
            } 
            else
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
            }
        }
    }
}
