using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Productjxc.DAL
{
	/// <summary>
	/// 数据访问类:P_CUS
	/// </summary>
	public class P_CUS
	{
		public P_CUS()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ProNO,string CusNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from P_CUS");
			strSql.Append(" where ProNO=@ProNO and CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;
			parameters[1].Value = CusNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.P_CUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into P_CUS(");
			strSql.Append("ProNO,CusNO,SaleCount,StaffName,SalePrice)");
			strSql.Append(" values (");
			strSql.Append("@ProNO,@CusNO,@SaleCount,@StaffName,@SalePrice)");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusNO", SqlDbType.VarChar,50),
					new SqlParameter("@SaleCount", SqlDbType.Int,4),
					new SqlParameter("@StaffName", SqlDbType.VarChar,50),
					new SqlParameter("@SalePrice", SqlDbType.Float,8)};
			parameters[0].Value = model.ProNO;
			parameters[1].Value = model.CusNO;
			parameters[2].Value = model.SaleCount;
			parameters[3].Value = model.StaffName;
			parameters[4].Value = model.SalePrice;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.P_CUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update P_CUS set ");
			strSql.Append("SaleCount=@SaleCount,");
			strSql.Append("StaffName=@StaffName,");
			strSql.Append("SalePrice=@SalePrice");
			strSql.Append(" where ProNO=@ProNO and CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusNO", SqlDbType.VarChar,50),
					new SqlParameter("@SaleCount", SqlDbType.Int,4),
					new SqlParameter("@StaffName", SqlDbType.VarChar,50),
					new SqlParameter("@SalePrice", SqlDbType.Float,8)};
			parameters[0].Value = model.ProNO;
			parameters[1].Value = model.CusNO;
			parameters[2].Value = model.SaleCount;
			parameters[3].Value = model.StaffName;
			parameters[4].Value = model.SalePrice;

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
		public bool Delete(string ProNO,string CusNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from P_CUS ");
			strSql.Append(" where ProNO=@ProNO and CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;
			parameters[1].Value = CusNO;

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
		/// 得到一个对象实体
		/// </summary>
		public Productjxc.Model.P_CUS GetModel(string ProNO,string CusNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProNO,CusNO,SaleCount,StaffName,SalePrice from P_CUS ");
			strSql.Append(" where ProNO=@ProNO and CusNO=@CusNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@CusNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;
			parameters[1].Value = CusNO;

			Productjxc.Model.P_CUS model=new Productjxc.Model.P_CUS();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ProNO=ds.Tables[0].Rows[0]["ProNO"].ToString();
				model.CusNO=ds.Tables[0].Rows[0]["CusNO"].ToString();
				if(ds.Tables[0].Rows[0]["SaleCount"].ToString()!="")
				{
					model.SaleCount=int.Parse(ds.Tables[0].Rows[0]["SaleCount"].ToString());
				}
				model.StaffName=ds.Tables[0].Rows[0]["StaffName"].ToString();
				if(ds.Tables[0].Rows[0]["SalePrice"].ToString()!="")
				{
					model.SalePrice=decimal.Parse(ds.Tables[0].Rows[0]["SalePrice"].ToString());
				}
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
			strSql.Append("select ProNO,CusNO,SaleCount,StaffName,SalePrice ");
			strSql.Append(" FROM P_CUS ");
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
			strSql.Append(" ProNO,CusNO,SaleCount,StaffName,SalePrice ");
			strSql.Append(" FROM P_CUS ");
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
			parameters[0].Value = "P_CUS";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

