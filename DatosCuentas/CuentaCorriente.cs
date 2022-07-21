using Pablo_Caneva_parcial.DatosCuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal class CuentaCorriente : Cuenta, ICuenta
    {
        private decimal saldoDescubierto;

        public decimal SaldoDescubierto { get => saldoDescubierto; set => saldoDescubierto = value; }

        public int[] CBU => throw new NotImplementedException();

        public decimal saldo => throw new NotImplementedException();

        public List<Cliente> usuarios => throw new NotImplementedException();

        public CuentaCorriente(string CBU, decimal saldo, decimal saldoDescubierto)
        {
            this.CBU1 = CBU;
            this.Saldo = saldo;
            this.SaldoDescubierto = saldoDescubierto;
        }
    }
}
