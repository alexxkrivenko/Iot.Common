using System;
using System.ComponentModel.DataAnnotations;

namespace Iot.Common
{
	[Serializable]
	public abstract class EntityDto
	{
		#region Properties
		[Required]
		public Guid Id
		{
			get;
			set;
		}
		#endregion
	}
}