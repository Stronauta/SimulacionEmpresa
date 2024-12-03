using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresaa.Shared.Model
{
    public class Compra
    {
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        public double TotalCosto => PrecioUnitario * Cantidad;
    }

    public class GastoCompra
    {
        public string Concepto { get; set; }
        public double Monto { get; set; }
    }
}
