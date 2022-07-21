using Pablo_Caneva_parcial.DatosCuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal class CajaDeAhorro : Cuenta, ICuenta
    {
        public CajaDeAhorro(string CBU, decimal saldo)
        {
            this.CBU1 = CBU;
            this.Saldo = saldo;
        }

        public int[] CBU => throw new NotImplementedException();

        public decimal saldo => throw new NotImplementedException();

        public List<Cliente> usuarios => throw new NotImplementedException();
    }
}
