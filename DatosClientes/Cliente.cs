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

        public bool Depositar (decimal deposito, Cuenta cuenta)
        {
            cuenta.Saldo = cuenta.Saldo + deposito;
            return true;
        }

        public bool Extraer(decimal extraccion, Cuenta cuenta)
        {
            if (extraccion <= cuenta.Saldo)
            {
                cuenta.Saldo = cuenta.Saldo-extraccion;
                return true;
            } else { return false; }
        }

        public decimal ConsultarSaldo (Cuenta cuenta)
        {
            return cuenta.Saldo;
        }

        public decimal SimularPlazoFijo (decimal monto, int dias)
        {
            decimal resultado;
            decimal interesPlazos = decimal.Parse(System.Configuration.ConfigurationSettings.AppSettings["interes"]);
            resultado = monto * (((interesPlazos*(decimal)dias))/360);
            return resultado;
        }

        public bool ConstituirPlazoFijo (decimal monto, int dias, Cuenta cuenta)
        {
            decimal interesPlazos = decimal.Parse(System.Configuration.ConfigurationSettings.AppSettings["interes"]);
            if (monto <= cuenta.Saldo)
            {
                decimal total = monto +(monto * (((interesPlazos * (decimal)dias)) / 360));
                cuenta.PlazoFijos.Add(new DatosCuentas.PlazoFijo(dias, total));
                cuenta.Saldo -= monto;
                return true;
            } else { return false; }
        }
    }
}
