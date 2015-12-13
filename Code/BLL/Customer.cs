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
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string CusNO)
		{
			return dal.Exists(CusNO);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Productjxc.Model.Customer model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Productjxc.Model.Customer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string CusNO)
		{
			
			return dal.Delete(CusNO);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string CusNOlist )
		{
			return dal.DeleteList(CusNOlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Productjxc.Model.Customer GetModel(string CusNO)
		{
			
			return dal.GetModel(CusNO);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Productjxc.Model.Customer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method


        #region  Method(�ͻ���Ϣ)
        /// <summary>
        /// ���ݿͻ��źͿͻ�����ÿͻ���Ϣ�������б�
        /// </summary>
        public DataSet GetListCustomer(string CusNO, string CusName)
        {
            return dal.GetListCustomer(CusNO, CusName);
        }
        #endregion  Method(�ͻ���Ϣ)
	}
}

