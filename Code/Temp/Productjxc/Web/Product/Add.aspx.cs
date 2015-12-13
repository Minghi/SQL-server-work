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
namespace Productjxc.Web.Product
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
			if(this.txtProName.Text.Trim().Length==0)
			{
				strErr+="ProName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtProPrice.Text))
			{
				strErr+="ProPrice格式错误！\\n";	
			}
			if(this.txtStoNO.Text.Trim().Length==0)
			{
				strErr+="StoNO不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStoCount.Text))
			{
				strErr+="StoCount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProNO=this.txtProNO.Text;
			string ProName=this.txtProName.Text;
			decimal ProPrice=decimal.Parse(this.txtProPrice.Text);
			string StoNO=this.txtStoNO.Text;
			int StoCount=int.Parse(this.txtStoCount.Text);

			Productjxc.Model.Product model=new Productjxc.Model.Product();
			model.ProNO=ProNO;
			model.ProName=ProName;
			model.ProPrice=ProPrice;
			model.StoNO=StoNO;
			model.StoCount=StoCount;

			Productjxc.BLL.Product bll=new Productjxc.BLL.Product();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
