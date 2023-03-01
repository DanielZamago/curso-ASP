using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace IntroASP.Models.ViewModels
{
	public class BeerViewModel
	{
		[Required]
		[Display(Name = "Nombre")]
		public string? Name { get; set; }

		[Required]
		[Display(Name= "Marca")]
		public int BrandId { get; set; }
	}
}
