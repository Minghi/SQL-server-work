using System;
namespace Productjxc.Model
{
	/// <summary>
	/// Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Product
	{
		public Product()
		{}
		#region Model
		private string _prono;
		private string _proname;
		private decimal? _proprice;
		private string _stono;
		private int? _stocount;
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
		public string ProName
		{
			set{ _proname=value;}
			get{return _proname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ProPrice
		{
			set{ _proprice=value;}
			get{return _proprice;}
		}
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
		public int? StoCount
		{
			set{ _stocount=value;}
			get{return _stocount;}
		}
		#endregion Model

	}
}

