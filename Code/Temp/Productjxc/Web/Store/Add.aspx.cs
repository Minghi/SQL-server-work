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
namespace Productjxc.Web.Store
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStoNO.Text.Trim().Length==0)
			{
				strErr+="StoNO����Ϊ�գ�\\n";	
			}
			if(this.txtAdminName.Text.Trim().Length==0)
			{
				strErr+="AdminName����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string StoNO=this.txtStoNO.Text;
			string AdminName=this.txtAdminName.Text;

			Productjxc.Model.Store model=new Productjxc.Model.Store();
			model.StoNO=StoNO;
			model.AdminName=AdminName;

			Productjxc.BLL.Store bll=new Productjxc.BLL.Store();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"����ɹ���","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
