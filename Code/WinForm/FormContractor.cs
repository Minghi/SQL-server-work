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
    public partial class FormContractor : Form
    {
        public FormContractor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            Productjxc.BLL.Contractor bll = new Productjxc.BLL.Contractor();
            this.dataGridView1.DataSource = bll.GetListContractor(this.textBoxConNO.Text, this.textBoxConName.Text).Tables[0].DefaultView;
        }
    }
}
