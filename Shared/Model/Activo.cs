using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Shared.Model
{
	public class Activo
    {
		public string Nombre { get; set; }
		public int Cantidad { get; set; }
		public decimal Precio { get; set; }
		public decimal PrecioTotal => Precio * Cantidad;
		public decimal Depreciacion { get; set; }

    }
}

