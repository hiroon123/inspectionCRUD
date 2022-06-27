using System;
using System.ComponentModel.DataAnnotations;

namespace webAPI
{
	public class InspectionType
	{

		public int Id { get; set; }

		[StringLength(50)]
		public string InspectionName { get; set; } = string.Empty;

    }
}
