using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal class Cliente
    {
        private string CUIT;
        private List<Cuenta> cuentas { get; set; } = new List<Cuenta>();
        private string condicionFiscal;

        public string CUIT1 { get => CUIT; set => CUIT = value; }
        public string CondicionFiscal { get => condicionFiscal; set => condicionFiscal = value; }
        public List<Cuenta> Cuentas { get => cuentas; set => cuentas = value; }

        public void Depositar (decimal deposito, Cuenta cuenta)
        {
            decimal saldoAnterior = cuenta.Saldo;
            cuenta.Saldo = cuenta.Saldo + deposito;
            CargaArchivos.ActualizarSaldo(cuenta.CBU1, saldoAnterior, cuenta.Saldo);
        }

        public void Extraer(decimal extraccion, Cuenta cuenta)
        {
            decimal saldoAnterior = cuenta.Saldo;
            cuenta.Saldo = cuenta.Saldo-extraccion;
            CargaArchivos.ActualizarSaldo(cuenta.CBU1, saldoAnterior, cuenta.Saldo);
        }

        public decimal ConsultarSaldo (Cuenta cuenta)
        {
            return cuenta.Saldo;
        }

        public static decimal SimularPlazoFijo (decimal monto, int dias)
        {
            decimal resultado;
            decimal interesPlazos = decimal.Parse(System.Configuration.ConfigurationSettings.AppSettings["interes"]);
            resultado = monto + (monto * (((interesPlazos*(decimal)dias))/36000));
            return resultado;
        }

        public bool ConstituirPlazoFijo (decimal monto, int dias, Cuenta cuenta)
        {
            decimal interesPlazos = decimal.Parse(System.Configuration.ConfigurationSettings.AppSettings["interes"]);
            if (monto <= cuenta.Saldo)
            {
                decimal saldoAnterior = cuenta.Saldo;
                decimal total = monto +(monto * (((interesPlazos * (decimal)dias)) / 36000));
                cuenta.PlazoFijos.Add(new DatosCuentas.PlazoFijo(dias, total));
                cuenta.Saldo -= monto;
                CargaArchivos.ActualizarSaldo(cuenta.CBU1, saldoAnterior, cuenta.Saldo);
                CargaArchivos.GuardarPlazoFijo(cuenta.CBU1, dias, total);
                return true;
            } else { return false; }
        }
    }
}
