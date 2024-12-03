using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Shared.Model
{
    public class GastoAdministrativo
    {
        public string Concepto { get; set; }
        public double Cantidad { get; set; }
        public decimal Monto { get; set; }
    }
}
