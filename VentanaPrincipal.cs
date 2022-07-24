using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Pablo_Caneva_parcial.DatosCuentas;
using Pablo_Caneva_parcial.Properties;
using Pablo_Caneva_parcial;

namespace Pablo_Caneva_parcial
{
    internal partial class VentanaPrincipal : Form
    {
        private Banco banco { get; set; }

        public VentanaPrincipal(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
            this.Text = "Banco Santa Fe";
            this.ControlBox = false;
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new NuevoCliente(banco);
            nuevoCliente.Show();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            int indice = 0;
            long nroPrueba;
            string ingresoCUIT = VentanaIngreso.ShowDialog("Ingrese el CUIT:", "Ingreso");
            if(!long.TryParse(ingresoCUIT, out nroPrueba))
            {
                MessageBox.Show("Debe ingresar un numero de CUIT correcto");
            }
            else if (ingresoCUIT.Length != 11)
            {
                MessageBox.Show("Debe ingresar un numero de CUIT correcto");
            }
            else if (banco.OperarCliente(ingresoCUIT) == -1)
            {
                MessageBox.Show("El CUIT ingresado no esta en la lista de clientes");
            }
            else
            {
                indice = banco.OperarCliente(ingresoCUIT);
                var operaciones = new Operaciones(banco, indice, ingresoCUIT);
                operaciones.Show();
            }
        }

        private void btnSaldoTesoreria_Click(object sender, EventArgs e)
        {
            string saldo = "El saldo de la tesoreria es de: $ " + this.banco.SaldoGeneral.ToString();
            string tesoreria = "Saldo Tesoreria";
            MessageBox.Show(saldo, tesoreria);
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
