using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Productjxc.Model;
namespace Productjxc.BLL
{
	/// <summary>
	/// Contractor
	/// </summary>
	public class Contractor
	{
		private readonly Productjxc.DAL.Contractor dal=new Productjxc.DAL.Contractor();
		public Contractor()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string ConNO)
		{
			return dal.Exists(ConNO);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Productjxc.Model.Contractor model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Productjxc.Model.Contractor model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string ConNO)
		{
			
			return dal.Delete(ConNO);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string ConNOlist )
		{
			return dal.DeleteList(ConNOlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Productjxc.Model.Contractor GetModel(string ConNO)
		{
			
			return dal.GetModel(ConNO);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Productjxc.Model.Contractor GetModelByCache(string ConNO)
		{
			
			string CacheKey = "ContractorModel-" + ConNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ConNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Productjxc.Model.Contractor)objModel;
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
		public List<Productjxc.Model.Contractor> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Productjxc.Model.Contractor> DataTableToList(DataTable dt)
		{
			List<Productjxc.Model.Contractor> modelList = new List<Productjxc.Model.Contractor>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Productjxc.Model.Contractor model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Productjxc.Model.Contractor();
					model.ConNO=dt.Rows[n]["ConNO"].ToString();
					model.ConName=dt.Rows[n]["ConName"].ToString();
					model.ConAddress=dt.Rows[n]["ConAddress"].ToString();
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

