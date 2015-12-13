using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Productjxc.DAL
{
	/// <summary>
	/// 数据访问类:Contractor
	/// </summary>
	public class Contractor
	{
		public Contractor()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ConNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Contractor");
			strSql.Append(" where ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ConNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ConNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Contractor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Contractor(");
			strSql.Append("ConNO,ConName,ConAddress)");
			strSql.Append(" values (");
			strSql.Append("@ConNO,@ConName,@ConAddress)");
			SqlParameter[] parameters = {
					new SqlParameter("@ConNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConName", SqlDbType.VarChar,50),
					new SqlParameter("@ConAddress", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ConNO;
			parameters[1].Value = model.ConName;
			parameters[2].Value = model.ConAddress;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Contractor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Contractor set ");
			strSql.Append("ConName=@ConName,");
			strSql.Append("ConAddress=@ConAddress");
			strSql.Append(" where ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ConNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConName", SqlDbType.VarChar,50),
					new SqlParameter("@ConAddress", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ConNO;
			parameters[1].Value = model.ConName;
			parameters[2].Value = model.ConAddress;

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
		public bool Delete(string ConNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Contractor ");
			strSql.Append(" where ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ConNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ConNO;

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
		public bool DeleteList(string ConNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Contractor ");
			strSql.Append(" where ConNO in ("+ConNOlist + ")  ");
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
		public Productjxc.Model.Contractor GetModel(string ConNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ConNO,ConName,ConAddress from Contractor ");
			strSql.Append(" where ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ConNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ConNO;

			Productjxc.Model.Contractor model=new Productjxc.Model.Contractor();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ConNO=ds.Tables[0].Rows[0]["ConNO"].ToString();
				model.ConName=ds.Tables[0].Rows[0]["ConName"].ToString();
				model.ConAddress=ds.Tables[0].Rows[0]["ConAddress"].ToString();
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
			strSql.Append("select ConNO,ConName,ConAddress ");
			strSql.Append(" FROM Contractor ");
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
			strSql.Append(" ConNO,ConName,ConAddress ");
			strSql.Append(" FROM Contractor ");
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
			parameters[0].Value = "Contractor";
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

