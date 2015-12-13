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
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string ProNO)
		{
			return dal.Exists(ProNO);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Productjxc.Model.Product model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Productjxc.Model.Product model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string ProNO)
		{
			
			return dal.Delete(ProNO);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string ProNOlist )
		{
			return dal.DeleteList(ProNOlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Productjxc.Model.Product GetModel(string ProNO)
		{
			
			return dal.GetModel(ProNO);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
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
		public List<Productjxc.Model.Product> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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
	}
}

