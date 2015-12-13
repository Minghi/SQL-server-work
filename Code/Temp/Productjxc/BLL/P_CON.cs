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
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string ProNO,string ConNO)
		{
			return dal.Exists(ProNO,ConNO);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Productjxc.Model.P_CON model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Productjxc.Model.P_CON model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string ProNO,string ConNO)
		{
			
			return dal.Delete(ProNO,ConNO);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Productjxc.Model.P_CON GetModel(string ProNO,string ConNO)
		{
			
			return dal.GetModel(ProNO,ConNO);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
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
		public List<Productjxc.Model.P_CON> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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

