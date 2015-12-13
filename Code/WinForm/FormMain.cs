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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            MessageBox.Show("欢迎使用本系统，如果要进行数据修改，请登录到管理员账户！", "提示");
         /*   WinForm.FormLogin formtemp = new FormLogin();
            formtemp.StartPosition = FormStartPosition.CenterScreen;
            formtemp.Show();
            */
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        FormLifeProduct formlife = null;
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.Checked = !toolStripMenuItem6.Checked;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;


            if (toolStripMenuItem6.Checked)
            {

                if (formlife == null || formlife.IsDisposed)
                {
                    formlife = new FormLifeProduct();
                    formlife.MdiParent = this;
                }
                if (!formlife.Created)
                {
                    formlife.WindowState = FormWindowState.Maximized;
                    formlife.Show();
                }

                /*
                WinForm.FormLifeProduct formtemp = new FormLifeProduct();
                formtemp.MdiParent = this;
                //  formtemp.ControlBox = false;
                formtemp.WindowState = FormWindowState.Maximized;
                //  formtemp.Text = "";
                formtemp.Show();
                //   formtemp.Close();
                */
            }
       
        }

        FormFoodProduct formfood = null;
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.Checked = !toolStripMenuItem7.Checked;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;

            if (toolStripMenuItem7.Checked)
            {
                if (formfood == null || formlife.IsDisposed)
                {
                    formfood = new FormFoodProduct();
                    formfood.MdiParent = this;
                }
                if (!formfood.Created)
                {
                    formfood.WindowState = FormWindowState.Maximized;
                    formfood.Show();
                }
            }
            
        }

        FormStationeryProduct formstationery = null;
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStripMenuItem8.Checked = !toolStripMenuItem8.Checked;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem9.Checked = false;

            if (toolStripMenuItem8.Checked)
            {
                if (formstationery == null || formlife.IsDisposed)
                {
                    formstationery = new FormStationeryProduct();
                    formstationery.MdiParent = this;
                }
                if (!formstationery.Created)
                {
                    formstationery.WindowState = FormWindowState.Maximized;
                    formstationery.Show();
                }
            }
            
        }

        FormSportProduct formsport = null;
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            toolStripMenuItem9.Checked = !toolStripMenuItem9.Checked;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;

            if (toolStripMenuItem9.Checked)
            {
                if (formsport == null || formlife.IsDisposed)
                {
                    formsport = new FormSportProduct();
                    formsport.MdiParent = this;
                }
                if (!formsport.Created)
                {
                    formsport.WindowState = FormWindowState.Maximized;
                    formsport.Show();
                }
            }
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormLogin formtemp = new FormLogin();
         //   formtemp.MdiParent = this;

            formtemp.StartPosition = FormStartPosition.CenterScreen;
      //      formtemp.Location = new Point(formtemp.Parent.Location.X, formtemp.Parent.Location.Y);
            
            formtemp.Show();
            this.Hide();
            
            

        }
    }
}
