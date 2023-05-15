using Microsoft.EntityFrameworkCore;
using Prioridad.Models;

namespace Prioridad.DAL
{
	public class PrioridadContext : DbContext
	{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public PrioridadContext(DbContextOptions<PrioridadContext> Options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
			: base(Options) { }

		public DbSet<Models.PrioridadR> PrioridadR { get; set; }
		public object Registros { get; internal set; }
	}
}
