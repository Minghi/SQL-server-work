using System;
namespace Productjxc.Model
{
	/// <summary>
	/// P_CON:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class P_CON
	{
		public P_CON()
		{}
		#region Model
		private string _prono;
		private string _conno;
		private int? _importcount;
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
		public string ConNO
		{
			set{ _conno=value;}
			get{return _conno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ImportCount
		{
			set{ _importcount=value;}
			get{return _importcount;}
		}
		#endregion Model

	}
}

