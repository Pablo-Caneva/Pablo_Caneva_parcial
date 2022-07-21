using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Pablo_Caneva_parcial.DatosCuentas;

namespace Pablo_Caneva_parcial
{
    internal class Banco: IValidar
    {
        private List<Cliente> clientes { get; set; } = new List<Cliente>();
        private List<Cuenta> cuentas { get; set; } = new List<Cuenta>();
        private string nombre { get; set; }
        private decimal saldoGeneral { get; set; }

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal SaldoGeneral { get => saldoGeneral; set => saldoGeneral = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public void AgregarCliente(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo)
        {
            this.saldoGeneral += saldo;
            Cliente cliente1 = new Persona(cuit, nombre, apellido, condicionFiscal, totalRecibos, recibos);
            Cuenta clienteca = new CajaDeAhorro(CBU, saldo);
            clienteca.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(clienteca);
            this.clientes.Add(cliente1);
            this.cuentas.Add(clienteca);
        }

        public void AgregarCliente(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, decimal descubierto)
        {
            this.saldoGeneral += saldo;
            Cliente cliente1 = new Persona(cuit, nombre, apellido, condicionFiscal, totalRecibos, recibos);
            Cuenta clientecc = new CuentaCorriente(CBU, saldo, descubierto);
            clientecc.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(clientecc);
            this.clientes.Add(cliente1);
            this.cuentas.Add(clientecc);
        }

        public void AgregarCliente(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, int dias, decimal total)
        {
            this.saldoGeneral += saldo;
            this.saldoGeneral += total;
            Cliente cliente1 = new Persona(cuit, nombre, apellido, condicionFiscal, totalRecibos, recibos);
            Cuenta clienteca = new CajaDeAhorro(CBU, saldo);
            PlazoFijo pf = new PlazoFijo(dias, total);
            clienteca.PlazoFijos.Add(pf);
            clienteca.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(clienteca);
            this.clientes.Add(cliente1);
            this.cuentas.Add(clienteca);
        }

        public void AgregarCliente(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, decimal descubierto, int dias, decimal total)
        {
            this.saldoGeneral += saldo;
            this.saldoGeneral += total;
            Cliente cliente1 = new Persona(cuit, nombre, apellido, condicionFiscal, totalRecibos, recibos);
            Cuenta clientecc = new CuentaCorriente(CBU, saldo, descubierto);
            PlazoFijo pf = new PlazoFijo(dias, total);
            clientecc.PlazoFijos.Add(pf);
            clientecc.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(clientecc);
            this.clientes.Add(cliente1);
            this.cuentas.Add(clientecc);
        }

        public void AgregarCliente(string cuit, string razonSocial, string condicionFiscal, bool balance, long nroIIBB, bool actaSocios, string CBU, decimal saldo)
        {
            this.saldoGeneral += saldo;
            Cliente cliente1 = new Empresa(cuit, razonSocial, condicionFiscal, balance, nroIIBB, actaSocios);
            Cuenta empresaca = new CajaDeAhorro(CBU, saldo);
            empresaca.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(empresaca);
            this.clientes.Add(cliente1);
            this.cuentas.Add(empresaca);
        }

        public void AgregarCliente(string cuit, string razonSocial, string condicionFiscal, bool balance, long nroIIBB, bool actaSocios, string CBU, decimal saldo, decimal descubierto)
        {
            this.saldoGeneral += saldo;
            Cliente cliente1 = new Empresa(cuit, razonSocial, condicionFiscal, balance, nroIIBB, actaSocios);
            Cuenta empresacc = new CuentaCorriente(CBU, saldo, descubierto);
            empresacc.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(empresacc);
            this.clientes.Add(cliente1);
        }

        public void AgregarCliente(string cuit, string razonSocial, string condicionFiscal, bool balance, long nroIIBB, bool actaSocios, string CBU, decimal saldo, int dias, decimal total)
        {
            this.saldoGeneral += saldo;
            this.saldoGeneral += total;
            Cliente cliente1 = new Empresa(cuit, razonSocial, condicionFiscal, balance, nroIIBB, actaSocios);
            Cuenta empresaca = new CajaDeAhorro(CBU, saldo);
            PlazoFijo pf = new PlazoFijo(dias, total);
            empresaca.PlazoFijos.Add(pf);
            empresaca.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(empresaca);
            this.clientes.Add(cliente1);
            this.cuentas.Add(empresaca);
        }

        public void AgregarCliente(string cuit, string razonSocial, string condicionFiscal, bool balance, long nroIIBB, bool actaSocios, string CBU, decimal saldo, decimal descubierto, int dias, decimal total)
        {
            this.saldoGeneral += saldo;
            this.saldoGeneral += total;
            Cliente cliente1 = new Empresa(cuit, razonSocial, condicionFiscal, balance, nroIIBB, actaSocios);
            Cuenta empresacc = new CuentaCorriente(CBU, saldo, descubierto);
            PlazoFijo pf = new PlazoFijo(dias, total);
            empresacc.PlazoFijos.Add(pf);
            empresacc.Usuarios.Add(cliente1);
            cliente1.Cuentas.Add(empresacc);
            this.clientes.Add(cliente1);
            this.cuentas.Add(empresacc);
        }

        public int OperarCliente(string CUIT)
        {
            foreach (var cliente in Clientes)
            {
                if (cliente.CUIT1 == CUIT)
                    return Clientes.IndexOf(cliente);
            }
            return -1;
        }

        public void ActualizarSaldo (decimal cambio, bool tipoOperacion)
        {
            if (tipoOperacion)
            {
                saldoGeneral += cambio;
            }
            else
            {
                saldoGeneral -= cambio;
            }
        }

        public bool ValidarCuit(string numero)
        {
            int total = 0;
            int lastDigito = 0;
            int[] arraycuit = new int[numero.Length - 1];
            int[] divisores = new int[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < numero.Length; i++)
            {
                if (i < arraycuit.Length)
                {
                    arraycuit[i] = Convert.ToInt32(Char.GetNumericValue(numero[i]));
                }
                else { lastDigito = Convert.ToInt32(Char.GetNumericValue(numero[i])); }
            }
            for (int i = 0; i < divisores.Length; i++)
            {
                total += arraycuit[i] * divisores[i];
            }
            var resto = total % 11;
            if (resto > 0)
            {
                if (resto == 1)
                {
                    resto = 9;
                }
                else { resto = 11 - resto; }
            }
            return lastDigito == resto;
        }

        public bool ValidarTexto(string texto)
        {
            return (Regex.IsMatch(texto, @"^[a-zA-Z]+$"));
        }
        public void CerrarPrograma()
        {

        }
    }
}
