using System;
namespace Productjxc.Model
{
	/// <summary>
	/// Customer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Customer
	{
		public Customer()
		{}
		#region Model
		private string _cusno;
		private string _cusname;
		private string _custel;
		/// <summary>
		/// 
		/// </summary>
		public string CusNO
		{
			set{ _cusno=value;}
			get{return _cusno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusName
		{
			set{ _cusname=value;}
			get{return _cusname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusTel
		{
			set{ _custel=value;}
			get{return _custel;}
		}
		#endregion Model

	}
}

