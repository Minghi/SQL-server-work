using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Productjxc.Web.Customer
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCusNO.Text.Trim().Length==0)
			{
				strErr+="CusNO不能为空！\\n";	
			}
			if(this.txtCusName.Text.Trim().Length==0)
			{
				strErr+="CusName不能为空！\\n";	
			}
			if(this.txtCusTel.Text.Trim().Length==0)
			{
				strErr+="CusTel不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CusNO=this.txtCusNO.Text;
			string CusName=this.txtCusName.Text;
			string CusTel=this.txtCusTel.Text;

			Productjxc.Model.Customer model=new Productjxc.Model.Customer();
			model.CusNO=CusNO;
			model.CusName=CusName;
			model.CusTel=CusTel;

			Productjxc.BLL.Customer bll=new Productjxc.BLL.Customer();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
