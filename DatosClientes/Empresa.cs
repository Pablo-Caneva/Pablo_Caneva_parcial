using Pablo_Caneva_parcial.DatosCuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal class Empresa : Cliente
    {
        private string razonSocial;
        private bool balance;
        private long nroInscripcionIIBB;
        private bool actaSocios;

        public Empresa(string cuit, string razonSocial, string condicionFiscal, bool balance, long nroIIBB, bool actaSocios)
        {
            this.CUIT1 = cuit;
            this.razonSocial = razonSocial;
            this.CondicionFiscal = condicionFiscal;
            this.balance = balance;
            this.nroInscripcionIIBB = nroIIBB;
            this.actaSocios = actaSocios;
        }

        /*
        public Empresa(string cuit, string razonSocial, string condicionFiscal, bool balance, int nroIIBB, bool actaSocios, string CBU, decimal saldo, int dias, decimal total)
        {
            this.CUIT1 = cuit;
            this.razonSocial = razonSocial;
            this.CondicionFiscal = condicionFiscal;
            this.balance = balance;
            this.nroInscripcionIIBB = nroIIBB;
            this.actaSocios = actaSocios;
            PlazoFijo plazoFijo = new PlazoFijo(dias, total);
            Cuenta cuenta1 = new CajaDeAhorro(CBU, saldo, plazoFijo);
            this.Cuentas.Add(cuenta1);
        }

        public Empresa(string cuit, string razonSocial, string condicionFiscal, bool balance, int nroIIBB, bool actaSocios, string CBU, decimal saldo, decimal descubierto)
        {
            this.CUIT1 = cuit;
            this.razonSocial = razonSocial;
            this.CondicionFiscal = condicionFiscal;
            this.balance = balance;
            this.nroInscripcionIIBB = nroIIBB;
            this.actaSocios = actaSocios;
            Cuenta cuenta1 = new CuentaCorriente(CBU, this, saldo, descubierto);
            this.Cuentas.Add(cuenta1);
        }

        public Empresa(string cuit, string razonSocial, string condicionFiscal, bool balance, int nroIIBB, bool actaSocios, string CBU, decimal saldo, decimal descubierto, int dias, decimal total)
        {
            this.CUIT1 = cuit;
            this.razonSocial = razonSocial;
            this.CondicionFiscal = condicionFiscal;
            this.balance = balance;
            this.nroInscripcionIIBB = nroIIBB;
            this.actaSocios = actaSocios;
            PlazoFijo plazoFijo = new PlazoFijo(dias, total);
            Cuenta cuenta1 = new CuentaCorriente(CBU, this, saldo, descubierto, plazoFijo);
            this.Cuentas.Add(cuenta1);
        }*/

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public bool Balance { get => balance; set => balance = value; }
        public long NroInscripcionIIBB { get => nroInscripcionIIBB; set => nroInscripcionIIBB = value; }
        public bool ActaSocios { get => actaSocios; set => actaSocios = value; }


    }
}
