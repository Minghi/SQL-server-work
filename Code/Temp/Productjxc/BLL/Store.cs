using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Productjxc.Model;
namespace Productjxc.BLL
{
	/// <summary>
	/// Store
	/// </summary>
	public class Store
	{
		private readonly Productjxc.DAL.Store dal=new Productjxc.DAL.Store();
		public Store()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string StoNO)
		{
			return dal.Exists(StoNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Store model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Store model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string StoNO)
		{
			
			return dal.Delete(StoNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string StoNOlist )
		{
			return dal.DeleteList(StoNOlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Productjxc.Model.Store GetModel(string StoNO)
		{
			
			return dal.GetModel(StoNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Productjxc.Model.Store GetModelByCache(string StoNO)
		{
			
			string CacheKey = "StoreModel-" + StoNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(StoNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Productjxc.Model.Store)objModel;
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
		public List<Productjxc.Model.Store> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Productjxc.Model.Store> DataTableToList(DataTable dt)
		{
			List<Productjxc.Model.Store> modelList = new List<Productjxc.Model.Store>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Productjxc.Model.Store model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Productjxc.Model.Store();
					model.StoNO=dt.Rows[n]["StoNO"].ToString();
					model.AdminName=dt.Rows[n]["AdminName"].ToString();
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

