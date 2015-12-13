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
namespace Productjxc.Web.P_CON
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
		this.txtImportCount.Text=model.ImportCount.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtImportCount.Text))
			{
				strErr+="ImportCount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProNO=this.lblProNO.Text;
			string ConNO=this.lblConNO.Text;
			int ImportCount=int.Parse(this.txtImportCount.Text);


			Productjxc.Model.P_CON model=new Productjxc.Model.P_CON();
			model.ProNO=ProNO;
			model.ConNO=ConNO;
			model.ImportCount=ImportCount;

			Productjxc.BLL.P_CON bll=new Productjxc.BLL.P_CON();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
