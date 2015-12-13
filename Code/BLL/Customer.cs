using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Productjxc.Model;
namespace Productjxc.BLL
{
	/// <summary>
	/// Customer
	/// </summary>
	public class Customer
	{
		private readonly Productjxc.DAL.Customer dal=new Productjxc.DAL.Customer();
		public Customer()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CusNO)
		{
			return dal.Exists(CusNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Productjxc.Model.Customer model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Productjxc.Model.Customer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CusNO)
		{
			
			return dal.Delete(CusNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CusNOlist )
		{
			return dal.DeleteList(CusNOlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Productjxc.Model.Customer GetModel(string CusNO)
		{
			
			return dal.GetModel(CusNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Productjxc.Model.Customer GetModelByCache(string CusNO)
		{
			
			string CacheKey = "CustomerModel-" + CusNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CusNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Productjxc.Model.Customer)objModel;
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
		public List<Productjxc.Model.Customer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Productjxc.Model.Customer> DataTableToList(DataTable dt)
		{
			List<Productjxc.Model.Customer> modelList = new List<Productjxc.Model.Customer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Productjxc.Model.Customer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Productjxc.Model.Customer();
					model.CusNO=dt.Rows[n]["CusNO"].ToString();
					model.CusName=dt.Rows[n]["CusName"].ToString();
					model.CusTel=dt.Rows[n]["CusTel"].ToString();
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


        #region  Method(客户信息)
        /// <summary>
        /// 根据客户号和客户名获得客户信息的数据列表
        /// </summary>
        public DataSet GetListCustomer(string CusNO, string CusName)
        {
            return dal.GetListCustomer(CusNO, CusName);
        }
        #endregion  Method(客户信息)
	}
}

