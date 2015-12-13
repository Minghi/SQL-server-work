using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Productjxc.Model;
namespace Productjxc.BLL
{
	/// <summary>
	/// Product
	/// </summary>
	public class Product
	{
		private readonly Productjxc.DAL.Product dal=new Productjxc.DAL.Product();
		public Product()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ProNO)
		{
			return dal.Exists(ProNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Product model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Product model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ProNO)
		{
			
			return dal.Delete(ProNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ProNOlist )
		{
			return dal.DeleteList(ProNOlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Productjxc.Model.Product GetModel(string ProNO)
		{
			
			return dal.GetModel(ProNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Productjxc.Model.Product GetModelByCache(string ProNO)
		{
			
			string CacheKey = "ProductModel-" + ProNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ProNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Productjxc.Model.Product)objModel;
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
		public List<Productjxc.Model.Product> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Productjxc.Model.Product> DataTableToList(DataTable dt)
		{
			List<Productjxc.Model.Product> modelList = new List<Productjxc.Model.Product>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Productjxc.Model.Product model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Productjxc.Model.Product();
					model.ProNO=dt.Rows[n]["ProNO"].ToString();
					model.ProName=dt.Rows[n]["ProName"].ToString();
					if(dt.Rows[n]["ProPrice"].ToString()!="")
					{
						model.ProPrice=decimal.Parse(dt.Rows[n]["ProPrice"].ToString());
					}
					model.StoNO=dt.Rows[n]["StoNO"].ToString();
					if(dt.Rows[n]["StoCount"].ToString()!="")
					{
						model.StoCount=int.Parse(dt.Rows[n]["StoCount"].ToString());
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

