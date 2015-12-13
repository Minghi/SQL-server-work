using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Productjxc.DAL
{
	/// <summary>
	/// 数据访问类:Store
	/// </summary>
	public class Store
	{
		public Store()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string StoNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Store");
			strSql.Append(" where StoNO=@StoNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@StoNO", SqlDbType.VarChar,50)};
			parameters[0].Value = StoNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Store(");
			strSql.Append("StoNO,AdminName)");
			strSql.Append(" values (");
			strSql.Append("@StoNO,@AdminName)");
			SqlParameter[] parameters = {
					new SqlParameter("@StoNO", SqlDbType.VarChar,50),
					new SqlParameter("@AdminName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.StoNO;
			parameters[1].Value = model.AdminName;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Store set ");
			strSql.Append("AdminName=@AdminName");
			strSql.Append(" where StoNO=@StoNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@StoNO", SqlDbType.VarChar,50),
					new SqlParameter("@AdminName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.StoNO;
			parameters[1].Value = model.AdminName;

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
		public bool Delete(string StoNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Store ");
			strSql.Append(" where StoNO=@StoNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@StoNO", SqlDbType.VarChar,50)};
			parameters[0].Value = StoNO;

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
		public bool DeleteList(string StoNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Store ");
			strSql.Append(" where StoNO in ("+StoNOlist + ")  ");
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
		public Productjxc.Model.Store GetModel(string StoNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 StoNO,AdminName from Store ");
			strSql.Append(" where StoNO=@StoNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@StoNO", SqlDbType.VarChar,50)};
			parameters[0].Value = StoNO;

			Productjxc.Model.Store model=new Productjxc.Model.Store();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.StoNO=ds.Tables[0].Rows[0]["StoNO"].ToString();
				model.AdminName=ds.Tables[0].Rows[0]["AdminName"].ToString();
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
			strSql.Append("select StoNO,AdminName ");
			strSql.Append(" FROM Store ");
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
			strSql.Append(" StoNO,AdminName ");
			strSql.Append(" FROM Store ");
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
			parameters[0].Value = "Store";
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

