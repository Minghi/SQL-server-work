using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Productjxc.DAL
{
	/// <summary>
	/// 数据访问类:Customer
	/// </summary>
	public class Customer
	{
		public Customer()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CusNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Customer");
			strSql.Append(" where CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CusNO", SqlDbType.VarChar,50)};
			parameters[0].Value = CusNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Customer(");
			strSql.Append("CusNO,CusName,CusTel)");
			strSql.Append(" values (");
			strSql.Append("@CusNO,@CusName,@CusTel)");
			SqlParameter[] parameters = {
					new SqlParameter("@CusNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusName", SqlDbType.VarChar,50),
					new SqlParameter("@CusTel", SqlDbType.VarChar,20)};
			parameters[0].Value = model.CusNO;
			parameters[1].Value = model.CusName;
			parameters[2].Value = model.CusTel;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Customer set ");
			strSql.Append("CusName=@CusName,");
			strSql.Append("CusTel=@CusTel");
			strSql.Append(" where CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CusNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusName", SqlDbType.VarChar,50),
					new SqlParameter("@CusTel", SqlDbType.VarChar,20)};
			parameters[0].Value = model.CusNO;
			parameters[1].Value = model.CusName;
			parameters[2].Value = model.CusTel;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CusNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CusNO", SqlDbType.VarChar,50)};
			parameters[0].Value = CusNO;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CusNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where CusNO in ("+CusNOlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Productjxc.Model.Customer GetModel(string CusNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CusNO,CusName,CusTel from Customer ");
			strSql.Append(" where CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CusNO", SqlDbType.VarChar,50)};
			parameters[0].Value = CusNO;

			Productjxc.Model.Customer model=new Productjxc.Model.Customer();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.CusNO=ds.Tables[0].Rows[0]["CusNO"].ToString();
				model.CusName=ds.Tables[0].Rows[0]["CusName"].ToString();
				model.CusTel=ds.Tables[0].Rows[0]["CusTel"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CusNO,CusName,CusTel ");
			strSql.Append(" FROM Customer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" CusNO,CusName,CusTel ");
			strSql.Append(" FROM Customer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Customer";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method


        #region  Method(客户信息)
        /// <summary>
        /// 根据客户号和客户名获得客户信息的数据列表
        /// </summary>
        public DataSet GetListCustomer(string CusNO, string CusName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CusNO,CusName,CusTel ");
            strSql.Append(" FROM Customer where 1=1");

            if (CusNO.Trim() != "")
            {
                strSql.Append(" and CusNO like '%" + CusNO + "%'");
            }
            if (CusName.Trim() != "")
            {
                strSql.Append(" and CusName like '%" + CusName + "%'");
            }

            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method(客户信息)
    }
}

