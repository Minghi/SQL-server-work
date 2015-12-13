using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Productjxc.Model;
namespace Productjxc.BLL
{
	/// <summary>
	/// P_CON
	/// </summary>
	public class P_CON
	{
		private readonly Productjxc.DAL.P_CON dal=new Productjxc.DAL.P_CON();
		public P_CON()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ProNO,string ConNO)
		{
			return dal.Exists(ProNO,ConNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.P_CON model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.P_CON model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ProNO,string ConNO)
		{
			
			return dal.Delete(ProNO,ConNO);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Productjxc.Model.P_CON GetModel(string ProNO,string ConNO)
		{
			
			return dal.GetModel(ProNO,ConNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Productjxc.Model.P_CON GetModelByCache(string ProNO,string ConNO)
		{
			
			string CacheKey = "P_CONModel-" + ProNO+ConNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ProNO,ConNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Productjxc.Model.P_CON)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Productjxc.Model.P_CON> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Productjxc.Model.P_CON> DataTableToList(DataTable dt)
		{
			List<Productjxc.Model.P_CON> modelList = new List<Productjxc.Model.P_CON>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Productjxc.Model.P_CON model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Productjxc.Model.P_CON();
					model.ProNO=dt.Rows[n]["ProNO"].ToString();
					model.ConNO=dt.Rows[n]["ConNO"].ToString();
					if(dt.Rows[n]["ImportCount"].ToString()!="")
					{
						model.ImportCount=int.Parse(dt.Rows[n]["ImportCount"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

