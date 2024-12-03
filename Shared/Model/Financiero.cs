using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Shared.Model
{
    public class GastoFinanciero
    {
        public string Concepto { get; set; } // Ejemplo: "Préstamo Bancario"
        public double MontoPrestamo { get; set; } // Monto total del préstamo
        public double TasaInteres { get; set; }   // Tasa de interés anual (en porcentaje)
        public int PlazoMeses { get; set; }       // Duración del préstamo en meses


    }
}
