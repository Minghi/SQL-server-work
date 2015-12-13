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
namespace Productjxc.Web.P_CUS
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string ProNO = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					ProNO= Request.Params["id0"];
				}
				string CusNO = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					CusNO= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(ProNO,CusNO);
			}
		}
			
	private void ShowInfo(string ProNO,string CusNO)
	{
		Productjxc.BLL.P_CUS bll=new Productjxc.BLL.P_CUS();
		Productjxc.Model.P_CUS model=bll.GetModel(ProNO,CusNO);
		this.lblProNO.Text=model.ProNO;
		this.lblCusNO.Text=model.CusNO;
		this.txtSaleCount.Text=model.SaleCount.ToString();
		this.txtStaffName.Text=model.StaffName;
		this.txtSalePrice.Text=model.SalePrice.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtSaleCount.Text))
			{
				strErr+="SaleCount格式错误！\\n";	
			}
			if(this.txtStaffName.Text.Trim().Length==0)
			{
				strErr+="StaffName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSalePrice.Text))
			{
				strErr+="SalePrice格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProNO=this.lblProNO.Text;
			string CusNO=this.lblCusNO.Text;
			int SaleCount=int.Parse(this.txtSaleCount.Text);
			string StaffName=this.txtStaffName.Text;
			decimal SalePrice=decimal.Parse(this.txtSalePrice.Text);


			Productjxc.Model.P_CUS model=new Productjxc.Model.P_CUS();
			model.ProNO=ProNO;
			model.CusNO=CusNO;
			model.SaleCount=SaleCount;
			model.StaffName=StaffName;
			model.SalePrice=SalePrice;

			Productjxc.BLL.P_CUS bll=new Productjxc.BLL.P_CUS();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
