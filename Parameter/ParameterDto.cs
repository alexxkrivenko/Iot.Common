using System;

namespace Iot.Common.Parameter
{
	[Serializable]
	public class ParameterDto : EntityDto
	{
		#region Properties
		public string Name
		{
			get;
			set;
		}
		#endregion
	}
}
