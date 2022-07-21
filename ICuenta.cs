using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal interface ICuenta
    {
        int[] CBU { get; }
        decimal saldo { get; }
        List<Cliente> usuarios { get; }
    }
}
