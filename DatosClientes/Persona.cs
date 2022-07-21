using Pablo_Caneva_parcial.DatosCuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal class Persona : Cliente
    {
        private string nombre;
        private string apellido;
        private decimal totalRecibos;
        private bool recibos;

        public Persona(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos)
        {
            this.CUIT1 = cuit;
            this.nombre = nombre;
            this.apellido = apellido;
            this.CondicionFiscal = condicionFiscal;
            this.totalRecibos = totalRecibos;
            this.recibos = recibos;
        }

        /*
        public Persona(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, int dias, decimal total)
        {
            this.CUIT1 = cuit;
            this.nombre = nombre;
            this.apellido = apellido;
            this.CondicionFiscal = condicionFiscal;
            this.totalRecibos = totalRecibos;
            this.recibos = recibos;
            PlazoFijo plazoFijo = new PlazoFijo(dias, total);
            Cuenta cuenta1 = new CajaDeAhorro(CBU, saldo, plazoFijo);
            this.Cuentas.Add(cuenta1);
        }

        public Persona(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, decimal descubierto)
        {
            this.CUIT1 = cuit;
            this.nombre = nombre;
            this.apellido = apellido;
            this.CondicionFiscal = condicionFiscal;
            this.totalRecibos = totalRecibos;
            this.recibos = recibos;
            Cuenta cuenta1 = new CuentaCorriente(CBU, this, saldo, descubierto);
            this.Cuentas.Add(cuenta1);
        }

        public Persona(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, decimal descubierto, int dias, decimal total)
        {
            this.CUIT1 = cuit;
            this.nombre = nombre;
            this.apellido = apellido;
            this.CondicionFiscal = condicionFiscal;
            this.totalRecibos = totalRecibos;
            this.recibos = recibos;
            PlazoFijo plazoFijo = new PlazoFijo(dias, total);
            Cuenta cuenta1 = new CuentaCorriente(CBU, this, saldo, descubierto, plazoFijo);
            this.Cuentas.Add(cuenta1);
        }*/

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal TotalRecibos { get => totalRecibos; set => totalRecibos = value; }
        public bool Recibos { get => recibos; set => recibos = value; }

        public bool CargarRecibos()
        {
            return true;
        }

        public decimal CalcularCredito()
        {
            decimal total = 0;
            foreach (Cuenta cuenta in Cuentas)
            {
                total += cuenta.Saldo;
            }
            return total;
        }
    }
}
