using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Productjxc.DAL
{
	/// <summary>
	/// ���ݷ�����:P_CON
	/// </summary>
	public class P_CON
	{
		public P_CON()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string ProNO,string ConNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from P_CON");
			strSql.Append(" where ProNO=@ProNO and ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;
			parameters[1].Value = ConNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Productjxc.Model.P_CON model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into P_CON(");
			strSql.Append("ProNO,ConNO,ImportCount)");
			strSql.Append(" values (");
			strSql.Append("@ProNO,@ConNO,@ImportCount)");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConNO", SqlDbType.VarChar,50),
					new SqlParameter("@ImportCount", SqlDbType.Int,4)};
			parameters[0].Value = model.ProNO;
			parameters[1].Value = model.ConNO;
			parameters[2].Value = model.ImportCount;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Productjxc.Model.P_CON model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update P_CON set ");
			strSql.Append("ImportCount=@ImportCount");
			strSql.Append(" where ProNO=@ProNO and ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConNO", SqlDbType.VarChar,50),
					new SqlParameter("@ImportCount", SqlDbType.Int,4)};
			parameters[0].Value = model.ProNO;
			parameters[1].Value = model.ConNO;
			parameters[2].Value = model.ImportCount;

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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string ProNO,string ConNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from P_CON ");
			strSql.Append(" where ProNO=@ProNO and ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;
			parameters[1].Value = ConNO;

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
		/// �õ�һ������ʵ��
		/// </summary>
		public Productjxc.Model.P_CON GetModel(string ProNO,string ConNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProNO,ConNO,ImportCount from P_CON ");
			strSql.Append(" where ProNO=@ProNO and ConNO=@ConNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ConNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;
			parameters[1].Value = ConNO;

			Productjxc.Model.P_CON model=new Productjxc.Model.P_CON();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ProNO=ds.Tables[0].Rows[0]["ProNO"].ToString();
				model.ConNO=ds.Tables[0].Rows[0]["ConNO"].ToString();
				if(ds.Tables[0].Rows[0]["ImportCount"].ToString()!="")
				{
					model.ImportCount=int.Parse(ds.Tables[0].Rows[0]["ImportCount"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ProNO,ConNO,ImportCount ");
			strSql.Append(" FROM P_CON ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ProNO,ConNO,ImportCount ");
			strSql.Append(" FROM P_CON ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "P_CON";
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

