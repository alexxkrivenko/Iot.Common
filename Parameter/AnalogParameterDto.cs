using System;

namespace Iot.Common.Parameter
{
	[Serializable]
	public class AnalogParameterDto : ValuedParameterDto
	{
		#region Properties
		public UnitDto Unit
		{
			get;
			set;
		}
		#endregion
	 
	}
}