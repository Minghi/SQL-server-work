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
    public partial class FormMainNew : Form
    {
        public FormMainNew()
        {
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
                if (formfood == null || formfood.IsDisposed)
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
                if (formstationery == null || formstationery.IsDisposed)
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
                if (formsport == null || formsport.IsDisposed)
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

        FormContractor formcontractor = null;
        private void contractorInfo_Click(object sender, EventArgs e)
        {
            toolStripMenuItem10.Checked = !toolStripMenuItem10.Checked;
            toolStripMenuItem12.Checked = false;

            if (toolStripMenuItem10.Checked)
            {

                if (formcontractor == null || formcontractor.IsDisposed)
                {
                    formcontractor = new FormContractor();
                    formcontractor.MdiParent = this;
                }
                if (!formcontractor.Created)
                {
                    formcontractor.WindowState = FormWindowState.Maximized;
                    formcontractor.Show();
                }
            }
        }

        FormCustomer formcustomer = null;
        private void customerInfo_Click(object sender, EventArgs e)
        {
            toolStripMenuItem12.Checked = !toolStripMenuItem12.Checked;
            toolStripMenuItem10.Checked = false;

            if (toolStripMenuItem12.Checked)
            {
                if (formcustomer == null || formcustomer.IsDisposed)
                {
                    formcustomer = new FormCustomer();
                    formcustomer.MdiParent = this;
                }
                if (!formcustomer.Created)
                {
                    formcustomer.WindowState = FormWindowState.Maximized;
                    formcustomer.Show();
                }
            }
        }

        

        private void FormMainNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result==DialogResult.OK)
            {
                e.Cancel = false;
                Environment.Exit(Environment.ExitCode);
               // Application.Exit();
            } 
            else
            {
                e.Cancel = true;
            }
        }

  /*      private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            WinForm.FormLogin formtemp = new FormLogin();
            formtemp.MdiParent = this;

            formtemp.StartPosition = FormStartPosition.CenterScreen;
      //      formtemp.Location = new Point(formtemp.Parent.Location.X, formtemp.Parent.Location.Y);

            formtemp.Show();

        }
        */
    }
}
