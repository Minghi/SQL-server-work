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
namespace Productjxc.Web.Contractor
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtConNO.Text.Trim().Length==0)
			{
				strErr+="ConNO不能为空！\\n";	
			}
			if(this.txtConName.Text.Trim().Length==0)
			{
				strErr+="ConName不能为空！\\n";	
			}
			if(this.txtConAddress.Text.Trim().Length==0)
			{
				strErr+="ConAddress不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ConNO=this.txtConNO.Text;
			string ConName=this.txtConName.Text;
			string ConAddress=this.txtConAddress.Text;

			Productjxc.Model.Contractor model=new Productjxc.Model.Contractor();
			model.ConNO=ConNO;
			model.ConName=ConName;
			model.ConAddress=ConAddress;

			Productjxc.BLL.Contractor bll=new Productjxc.BLL.Contractor();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
