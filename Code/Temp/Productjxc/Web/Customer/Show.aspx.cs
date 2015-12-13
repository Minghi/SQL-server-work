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
namespace Productjxc.Web.Customer
{
    public partial class Show : Page
    {        
        		public string id=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					id = Request.Params["id"];
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
		this.lblCusName.Text=model.CusName;
		this.lblCusTel.Text=model.CusTel;

	}


    }
}
