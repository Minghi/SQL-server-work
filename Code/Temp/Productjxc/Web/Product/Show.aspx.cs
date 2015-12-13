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
namespace Productjxc.Web.Product
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
					string ProNO= Request.Params["id"];
					ShowInfo(ProNO);
				}
			}
		}
		
	private void ShowInfo(string ProNO)
	{
		Productjxc.BLL.Product bll=new Productjxc.BLL.Product();
		Productjxc.Model.Product model=bll.GetModel(ProNO);
		this.lblProNO.Text=model.ProNO;
		this.lblProName.Text=model.ProName;
		this.lblProPrice.Text=model.ProPrice.ToString();
		this.lblStoNO.Text=model.StoNO;
		this.lblStoCount.Text=model.StoCount.ToString();

	}


    }
}
