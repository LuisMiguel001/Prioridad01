using Microsoft.EntityFrameworkCore;
using Prioridad.DAL;
using Prioridad.Models;
using System.Linq.Expressions;

namespace Prioridad.BLL
{
	public class SistemaBLL
	{
		private readonly PrioridadContext _contexto;

		public SistemaBLL(PrioridadContext contexto)
		{
			_contexto = contexto;
		}

		public bool Existe(int PrioridadId)
		{
			return _contexto.PrioridadR.Any(s => s.PrioridadId == PrioridadId);
		}
		
		private bool Insertar(PrioridadR prioridad)
		{
			_contexto.PrioridadR.Add(prioridad);
			int cantidad = _contexto.SaveChanges();
			return cantidad > 0;
		}
		
		private bool Modificar(PrioridadR prioridad)
		{
			_contexto.Update(prioridad);
			int cantidad = _contexto.SaveChanges();
			return cantidad > 0;
		}

		public bool Guardar(PrioridadR prioridad)
		{
			if (!Existe(prioridad.PrioridadId))
				return Insertar(prioridad);
			else
				return Modificar(prioridad);
		}

		public bool Eliminar(PrioridadR prioridad)
		{
			_contexto.PrioridadR.Remove(prioridad);
			int cantidad = _contexto.SaveChanges();
			return cantidad > 0;
		}

		public PrioridadR? Buscar(int PrioridadId)
		{
			return _contexto.PrioridadR
				.AsNoTracking()
				.FirstOrDefault(s => s.PrioridadId == PrioridadId);
		}

		public List<PrioridadR> GetList(Expression<Func<PrioridadR, bool>> Criterio)
		{
			return _contexto.PrioridadR
				.Where(Criterio)
				.AsNoTracking()
				.ToList();
		}
	}
}
