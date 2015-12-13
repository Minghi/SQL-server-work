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
			if(this.txtCusNO.Text.Trim().Length==0)
			{
				strErr+="CusNO不能为空！\\n";	
			}
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
			string ProNO=this.txtProNO.Text;
			string CusNO=this.txtCusNO.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
