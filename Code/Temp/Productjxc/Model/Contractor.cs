using System;
namespace Productjxc.Model
{
	/// <summary>
	/// Contractor:实体类(属性说明自动提取数据库字段的描述信息)
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

