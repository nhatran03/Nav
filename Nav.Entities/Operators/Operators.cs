using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nav.Entities.Operators
{
	[Table("Operators")]
	public class Operators
	{
		public const int MaxNameLength = 10;
		public int Id { get; set; }

		[StringLength(MaxNameLength)]
		public string Name { get; set; }
	}
}
