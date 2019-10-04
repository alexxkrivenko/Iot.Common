namespace Iot.Common.Parameter
{
	public abstract class ValuedParameterDto : ParameterDto
	{
		#region Properties
		public object Value
		{
			get;
			set;
		}
		#endregion
	}
}
