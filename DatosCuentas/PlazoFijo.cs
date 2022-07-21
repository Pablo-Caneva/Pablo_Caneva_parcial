using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial.DatosCuentas
{
    internal class PlazoFijo
    {
        private int dias;
        private decimal monto;

        public int Dias { get => dias; set => dias = value; }
        public decimal Monto { get => monto; set => monto = value; }

        public PlazoFijo(int dias, decimal monto)
        {
            this.dias = dias;
            this.monto = monto;
        }
    }
}
