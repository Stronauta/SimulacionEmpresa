using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Shared.Model
{
    public class Ventas
    {
		public string Nombre { get; set; } = string.Empty;
		public int Cantidad { get; set; }
		public decimal PrecioUnitario { get; set; }
	}
}
