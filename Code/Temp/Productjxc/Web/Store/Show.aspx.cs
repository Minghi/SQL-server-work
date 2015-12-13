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
namespace Productjxc.Web.Store
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
		this.lblAdminName.Text=model.AdminName;

	}


    }
}
