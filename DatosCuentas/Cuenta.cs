using Pablo_Caneva_parcial.DatosCuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Caneva_parcial
{
    internal abstract class Cuenta
    {
        private string CBU;
        private decimal saldo;
        private List<Cliente> usuarios { get; set; }=new List<Cliente>();
        private List<PlazoFijo> plazoFijos { get; set; }=new List<PlazoFijo>();

        public string CBU1 { get => CBU; set => CBU = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public List<PlazoFijo> PlazoFijos { get => plazoFijos; set => plazoFijos = value; }
        public List<Cliente> Usuarios { get => usuarios; set => usuarios = value; }

        public void AgregarClienteenCuenta (Cliente cliente, Cuenta cuenta)
        {
            cuenta.Usuarios.Add(cliente);
        }
    }
}
