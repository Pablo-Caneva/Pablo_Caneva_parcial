using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal interface IValidar
    {
        Boolean ValidarCuit(string numero);

        Boolean ValidarTexto(string texto);
    }
}
