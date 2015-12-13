using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Productjxc.Model;
namespace Productjxc.BLL
{
	/// <summary>
	/// P_CUS
	/// </summary>
	public class P_CUS
	{
		private readonly Productjxc.DAL.P_CUS dal=new Productjxc.DAL.P_CUS();
		public P_CUS()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string ProNO,string CusNO)
		{
			return dal.Exists(ProNO,CusNO);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Productjxc.Model.P_CUS model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Productjxc.Model.P_CUS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string ProNO,string CusNO)
		{
			
			return dal.Delete(ProNO,CusNO);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Productjxc.Model.P_CUS GetModel(string ProNO,string CusNO)
		{
			
			return dal.GetModel(ProNO,CusNO);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Productjxc.Model.P_CUS GetModelByCache(string ProNO,string CusNO)
		{
			
			string CacheKey = "P_CUSModel-" + ProNO+CusNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ProNO,CusNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Productjxc.Model.P_CUS)objModel;
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
		public List<Productjxc.Model.P_CUS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Productjxc.Model.P_CUS> DataTableToList(DataTable dt)
		{
			List<Productjxc.Model.P_CUS> modelList = new List<Productjxc.Model.P_CUS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Productjxc.Model.P_CUS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Productjxc.Model.P_CUS();
					model.ProNO=dt.Rows[n]["ProNO"].ToString();
					model.CusNO=dt.Rows[n]["CusNO"].ToString();
					if(dt.Rows[n]["SaleCount"].ToString()!="")
					{
						model.SaleCount=int.Parse(dt.Rows[n]["SaleCount"].ToString());
					}
					model.StaffName=dt.Rows[n]["StaffName"].ToString();
					if(dt.Rows[n]["SalePrice"].ToString()!="")
					{
						model.SalePrice=decimal.Parse(dt.Rows[n]["SalePrice"].ToString());
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

