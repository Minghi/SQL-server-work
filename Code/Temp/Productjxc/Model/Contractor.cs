using System;
namespace Productjxc.Model
{
	/// <summary>
	/// Contractor:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class Contractor
	{
		public Contractor()
		{}
		#region Model
		private string _conno;
		private string _conname;
		private string _conaddress;
		/// <summary>
		/// 
		/// </summary>
		public string ConNO
		{
			set{ _conno=value;}
			get{return _conno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConName
		{
			set{ _conname=value;}
			get{return _conname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConAddress
		{
			set{ _conaddress=value;}
			get{return _conaddress;}
		}
		#endregion Model

	}
}

