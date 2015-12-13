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
namespace Productjxc.Web.P_CUS
{
    public partial class Show : Page
    {        
        		public string id=""; 
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
		this.lblSaleCount.Text=model.SaleCount.ToString();
		this.lblStaffName.Text=model.StaffName;
		this.lblSalePrice.Text=model.SalePrice.ToString();

	}


    }
}
