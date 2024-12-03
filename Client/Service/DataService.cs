using Empresa.Shared.Model;
using Empresaa.Shared.Model;
using System.Collections.Generic;
using System.Linq;

namespace Empresa.Client.Services
{
    public class DataService
    {
        public List<Activo> Activos { get; private set; } = new List<Activo>();
        public List<Compra> Compras { get; private set; } = new List<Compra>();
        public List<GastoFinanciero> GastosFinancieros { get; private set; } = new List<GastoFinanciero>();
        public List<GastoAdministrativo> GastosAdministrativos { get; private set; } = new List<GastoAdministrativo>();
        public List<GastoDeCompra> GastosDeCompra { get; private set; } = new List<GastoDeCompra>();

        // Métodos para Activos
        public void AddActivo(Activo activo) => Activos.Add(activo);
        public void RemoveActivo(Activo activo) => Activos.Remove(activo);
        public void UpdateActivo(Activo activo)
        {
            var existingActivo = Activos.FirstOrDefault(a => a.Nombre == activo.Nombre);
            if (existingActivo != null)
            {
                existingActivo.Cantidad = activo.Cantidad;
                existingActivo.Precio = activo.Precio;
            }
        }

        // Métodos para Compras
        public void AddCompra(Compra compra) => Compras.Add(compra);
        public void RemoveCompra(Compra compra) => Compras.Remove(compra);
        public void UpdateCompra(Compra compra)
        {
            var existingCompra = Compras.FirstOrDefault(c => c.Nombre == compra.Nombre);
            if (existingCompra != null)
            {
                existingCompra.PrecioUnitario = compra.PrecioUnitario;
                existingCompra.Cantidad = compra.Cantidad;
            }
        }

        // Métodos para Gastos Financieros
        public void AddGastoFinanciero(GastoFinanciero gastoFinanciero) => GastosFinancieros.Add(gastoFinanciero);
        public void RemoveGastoFinanciero(GastoFinanciero gastoFinanciero) => GastosFinancieros.Remove(gastoFinanciero);
        public void UpdateGastoFinanciero(GastoFinanciero gastoFinanciero)
        {
            var existingGastoFinanciero = GastosFinancieros.FirstOrDefault(g => g.Concepto == gastoFinanciero.Concepto);
            if (existingGastoFinanciero != null)
            {
                existingGastoFinanciero.MontoPrestamo = gastoFinanciero.MontoPrestamo;
                existingGastoFinanciero.TasaInteres = gastoFinanciero.TasaInteres;
                existingGastoFinanciero.PlazoMeses = gastoFinanciero.PlazoMeses;
            }
        }

        // Métodos para Gastos Administrativos
        public void AddGastoAdministrativo(GastoAdministrativo gastoAdministrativo) => GastosAdministrativos.Add(gastoAdministrativo);
        public void RemoveGastoAdministrativo(GastoAdministrativo gastoAdministrativo) => GastosAdministrativos.Remove(gastoAdministrativo); public void UpdateGastoAdministrativo(GastoAdministrativo gastoAdministrativo)
        {
            var existingGastoAdministrativo = GastosAdministrativos.FirstOrDefault(g => g.Concepto == gastoAdministrativo.Concepto);
            if (existingGastoAdministrativo != null)
            {
                existingGastoAdministrativo.Cantidad = gastoAdministrativo.Cantidad;
                existingGastoAdministrativo.Monto = gastoAdministrativo.Monto;
            }
        }

        // Métodos para Gastos de Compra
        public void AddGastoDeCompra(GastoDeCompra gastoDeCompra) => GastosDeCompra.Add(gastoDeCompra);
        public void RemoveGastoDeCompra(GastoDeCompra gastoDeCompra) => GastosDeCompra.Remove(gastoDeCompra);
        public void UpdateGastoDeCompra(GastoDeCompra gastoDeCompra)
        {
            var existingGastoDeCompra = GastosDeCompra.FirstOrDefault(g => g.Nombre == gastoDeCompra.Nombre);
            if (existingGastoDeCompra != null)
            {
                existingGastoDeCompra.Monto = gastoDeCompra.Monto;
            }
        }
    }
}
