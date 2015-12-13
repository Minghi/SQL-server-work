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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProNO.Text.Trim().Length==0)
			{
				strErr+="ProNO不能为空！\\n";	
			}
			if(this.txtConNO.Text.Trim().Length==0)
			{
				strErr+="ConNO不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtImportCount.Text))
			{
				strErr+="ImportCount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProNO=this.txtProNO.Text;
			string ConNO=this.txtConNO.Text;
			int ImportCount=int.Parse(this.txtImportCount.Text);

			Productjxc.Model.P_CON model=new Productjxc.Model.P_CON();
			model.ProNO=ProNO;
			model.ConNO=ConNO;
			model.ImportCount=ImportCount;

			Productjxc.BLL.P_CON bll=new Productjxc.BLL.P_CON();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
