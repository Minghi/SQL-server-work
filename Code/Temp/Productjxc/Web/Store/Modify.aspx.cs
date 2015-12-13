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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string StoNO= Request.Params["id"];
					ShowInfo(StoNO);
				}
			}
		}
			
	private void ShowInfo(string StoNO)
	{
		Productjxc.BLL.Store bll=new Productjxc.BLL.Store();
		Productjxc.Model.Store model=bll.GetModel(StoNO);
		this.lblStoNO.Text=model.StoNO;
		this.txtAdminName.Text=model.AdminName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtAdminName.Text.Trim().Length==0)
			{
				strErr+="AdminName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string StoNO=this.lblStoNO.Text;
			string AdminName=this.txtAdminName.Text;


			Productjxc.Model.Store model=new Productjxc.Model.Store();
			model.StoNO=StoNO;
			model.AdminName=AdminName;

			Productjxc.BLL.Store bll=new Productjxc.BLL.Store();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
