using System;
namespace Productjxc.Model
{
	/// <summary>
	/// Store:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class Store
	{
		public Store()
		{}
		#region Model
		private string _stono;
		private string _adminname;
		/// <summary>
		/// 
		/// </summary>
		public string StoNO
		{
			set{ _stono=value;}
			get{return _stono;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		#endregion Model

	}
}

