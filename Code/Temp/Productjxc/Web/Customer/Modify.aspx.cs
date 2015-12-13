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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string CusNO= Request.Params["id"];
					ShowInfo(CusNO);
				}
			}
		}
			
	private void ShowInfo(string CusNO)
	{
		Productjxc.BLL.Customer bll=new Productjxc.BLL.Customer();
		Productjxc.Model.Customer model=bll.GetModel(CusNO);
		this.lblCusNO.Text=model.CusNO;
		this.txtCusName.Text=model.CusName;
		this.txtCusTel.Text=model.CusTel;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			string CusNO=this.lblCusNO.Text;
			string CusName=this.txtCusName.Text;
			string CusTel=this.txtCusTel.Text;


			Productjxc.Model.Customer model=new Productjxc.Model.Customer();
			model.CusNO=CusNO;
			model.CusName=CusName;
			model.CusTel=CusTel;

			Productjxc.BLL.Customer bll=new Productjxc.BLL.Customer();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
