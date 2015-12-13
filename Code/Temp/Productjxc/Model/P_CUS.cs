using System;
namespace Productjxc.Model
{
	/// <summary>
	/// P_CUS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class P_CUS
	{
		public P_CUS()
		{}
		#region Model
		private string _prono;
		private string _cusno;
		private int? _salecount;
		private string _staffname;
		private decimal? _saleprice;
		/// <summary>
		/// 
		/// </summary>
		public string ProNO
		{
			set{ _prono=value;}
			get{return _prono;}
		}
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
		public int? SaleCount
		{
			set{ _salecount=value;}
			get{return _salecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StaffName
		{
			set{ _staffname=value;}
			get{return _staffname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SalePrice
		{
			set{ _saleprice=value;}
			get{return _saleprice;}
		}
		#endregion Model

	}
}

