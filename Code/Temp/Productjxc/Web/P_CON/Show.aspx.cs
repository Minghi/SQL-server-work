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
namespace Productjxc.Web.P_CON
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
				string ConNO = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					ConNO= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(ProNO,ConNO);
			}
		}
		
	private void ShowInfo(string ProNO,string ConNO)
	{
		Productjxc.BLL.P_CON bll=new Productjxc.BLL.P_CON();
		Productjxc.Model.P_CON model=bll.GetModel(ProNO,ConNO);
		this.lblProNO.Text=model.ProNO;
		this.lblConNO.Text=model.ConNO;
		this.lblImportCount.Text=model.ImportCount.ToString();

	}


    }
}
