using System.ComponentModel.DataAnnotations;

namespace Prioridad.Models
{
	public class PrioridadR
	{
		[Key] //KEY ES EL ID CODE PARA NUESTRA BASE DE DATOS, (LOS ATRIBUTOS DEBEN INICIAR EN MAYUSCULA)

		public int PrioridadId { get; set; }
		[Required(ErrorMessage = "La descripcion es obligatoria")]

		public string? Descripcion { get; set; }

		[Required(ErrorMessage = "Los dias de compromiso son obligatoria")]
		public int DiasCompromiso { get; set; }

	}
}
