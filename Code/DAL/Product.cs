using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Productjxc.DAL
{
	/// <summary>
	/// 数据访问类:Product
	/// </summary>
	public class Product
	{
		public Product()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ProNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Product");
			strSql.Append(" where ProNO=@ProNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Product(");
			strSql.Append("ProNO,ProName,ProPrice,StoNO,StoCount)");
			strSql.Append(" values (");
			strSql.Append("@ProNO,@ProName,@ProPrice,@StoNO,@StoCount)");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ProName", SqlDbType.VarChar,50),
					new SqlParameter("@ProPrice", SqlDbType.Float,8),
					new SqlParameter("@StoNO", SqlDbType.VarChar,50),
					new SqlParameter("@StoCount", SqlDbType.Int,4)};
			parameters[0].Value = model.ProNO;
			parameters[1].Value = model.ProName;
			parameters[2].Value = model.ProPrice;
			parameters[3].Value = model.StoNO;
			parameters[4].Value = model.StoCount;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Product set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("ProPrice=@ProPrice,");
			strSql.Append("StoNO=@StoNO,");
			strSql.Append("StoCount=@StoCount");
			strSql.Append(" where ProNO=@ProNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50),
					new SqlParameter("@ProName", SqlDbType.VarChar,50),
					new SqlParameter("@ProPrice", SqlDbType.Float,8),
					new SqlParameter("@StoNO", SqlDbType.VarChar,50),
					new SqlParameter("@StoCount", SqlDbType.Int,4)};
			parameters[0].Value = model.ProNO;
			parameters[1].Value = model.ProName;
			parameters[2].Value = model.ProPrice;
			parameters[3].Value = model.StoNO;
			parameters[4].Value = model.StoCount;

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
		public bool Delete(string ProNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Product ");
			strSql.Append(" where ProNO=@ProNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;

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
		public bool DeleteList(string ProNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Product ");
			strSql.Append(" where ProNO in ("+ProNOlist + ")  ");
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
		public Productjxc.Model.Product GetModel(string ProNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProNO,ProName,ProPrice,StoNO,StoCount from Product ");
			strSql.Append(" where ProNO=@ProNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProNO", SqlDbType.VarChar,50)};
			parameters[0].Value = ProNO;

			Productjxc.Model.Product model=new Productjxc.Model.Product();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ProNO=ds.Tables[0].Rows[0]["ProNO"].ToString();
				model.ProName=ds.Tables[0].Rows[0]["ProName"].ToString();
				if(ds.Tables[0].Rows[0]["ProPrice"].ToString()!="")
				{
					model.ProPrice=decimal.Parse(ds.Tables[0].Rows[0]["ProPrice"].ToString());
				}
				model.StoNO=ds.Tables[0].Rows[0]["StoNO"].ToString();
				if(ds.Tables[0].Rows[0]["StoCount"].ToString()!="")
				{
					model.StoCount=int.Parse(ds.Tables[0].Rows[0]["StoCount"].ToString());
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
			strSql.Append("select ProNO,ProName,ProPrice,StoNO,StoCount ");
			strSql.Append(" FROM Product ");
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
			strSql.Append(" ProNO,ProName,ProPrice,StoNO,StoCount ");
			strSql.Append(" FROM Product ");
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
			parameters[0].Value = "Product";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method


        #region  Method(生活用品类)
        /// <summary>
        /// 根据商品号和商品名获得生活用品类的数据列表
        /// </summary>
        public DataSet GetList(string ProNO, string ProName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ProNO,ProName,ProPrice,StoNO,StoCount ");
           // strSql.Append(" FROM Product where 1=1");
            strSql.Append(" FROM Product where StoNO=0");
            if (ProNO.Trim() != "")
                strSql.Append(" and ProNO like '%" + ProNO + "%'");
            if (ProName.Trim() != "")
                strSql.Append(" and ProName like '%" + ProName + "%'");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method(生活用品类)


        #region  Method(食品类)
        /// <summary>
        /// 根据商品号和商品名获得食品类的数据列表
        /// </summary>
        public DataSet GetListFood(string ProNO, string ProName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ProNO,ProName,ProPrice,StoNO,StoCount ");
            strSql.Append(" FROM Product where StoNO=1");
            if (ProNO.Trim() != "")
                strSql.Append(" and ProNO like '%" + ProNO + "%'");
            if (ProName.Trim() != "")
                strSql.Append(" and ProName like '%" + ProName + "%'");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method(食品类)


        #region  Method(文具类)
        /// <summary>
        /// 根据商品号和商品名获得文具类的数据列表
        /// </summary>
        public DataSet GetListStationery(string ProNO, string ProName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ProNO,ProName,ProPrice,StoNO,StoCount ");
            strSql.Append(" FROM Product where StoNO=2");
            if (ProNO.Trim() != "")
                strSql.Append(" and ProNO like '%" + ProNO + "%'");
            if (ProName.Trim() != "")
                strSql.Append(" and ProName like '%" + ProName + "%'");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method(文具类)


        #region  Method(体育用品类)
        /// <summary>
        /// 根据商品号和商品名获得体育用品类的数据列表
        /// </summary>
        public DataSet GetListSport(string ProNO, string ProName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ProNO,ProName,ProPrice,StoNO,StoCount ");
            strSql.Append(" FROM Product where StoNO=3");
            if (ProNO.Trim() != "")
                strSql.Append(" and ProNO like '%" + ProNO + "%'");
            if (ProName.Trim() != "")
                strSql.Append(" and ProName like '%" + ProName + "%'");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method(体育用品类)
    }
}

