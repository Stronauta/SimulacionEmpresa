using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresaa.Shared.Model
{
	public class GastoDeCompra
	{
		public string Nombre { get; set; } = string.Empty;
        public decimal Monto { get; set; } // Total distribuido proporcionalmente entre compras.
	}
}
