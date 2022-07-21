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
            this.banco = banco;
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new NuevoCliente();
            nuevoCliente.Show();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            var operaciones = new Operaciones();
            operaciones.Show();
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
