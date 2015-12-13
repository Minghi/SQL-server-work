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
namespace Productjxc.Web.Contractor
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
					string ConNO= Request.Params["id"];
					ShowInfo(ConNO);
				}
			}
		}
		
	private void ShowInfo(string ConNO)
	{
		Productjxc.BLL.Contractor bll=new Productjxc.BLL.Contractor();
		Productjxc.Model.Contractor model=bll.GetModel(ConNO);
		this.lblConNO.Text=model.ConNO;
		this.lblConName.Text=model.ConName;
		this.lblConAddress.Text=model.ConAddress;

	}


    }
}
