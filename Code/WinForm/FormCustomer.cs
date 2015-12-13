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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            Productjxc.BLL.Customer bll = new Productjxc.BLL.Customer();
            this.dataGridView1.DataSource = bll.GetListCustomer(this.textBoxCusNO.Text, this.textBoxCusName.Text).Tables[0].DefaultView;
        }
    }
}
