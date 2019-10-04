using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Iot.Common.Parameter;

namespace Iot.Common
{
	/// <summary>
	/// Представляет объект передачи данных - устройство.
	/// </summary>
	/// <seealso cref="Iot.Common.EntityDto" />
	public class DeviceDto : EntityDto
	{
		#region Properties
		/// <summary>
		/// Возвращает или устанавливает имя устройства.
		/// </summary>
		/// <value>
		/// Имя устройства.
		/// </value>
		[Required]
		[StringLength(32)]
		public string DeviceName
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает перечень параметров.
		/// </summary>
		/// <value>
		/// The parameters.
		/// </value>
		public IEnumerable<ParameterDto> Parameters
		{
			get;
			set;
		}
		#endregion
	}
}
