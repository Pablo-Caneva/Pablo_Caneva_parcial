using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pablo_Caneva_parcial
{
    internal partial class Operaciones : Form
    {
        private Banco banco { get; set; }
        private int indice { get; set; }
        private string cuit { get; set; }
        private List<Cuenta> cuentas { get; set; } = new List<Cuenta>();
        private List<string> CBU { get; set; } = new List<string>();
        private decimal descubierto { get; set; }
        public Operaciones(Banco banco, int indice, string cuit)
        {
            InitializeComponent();
            this.banco = banco;
            this.indice = indice;
            this.cuit = cuit;
            this.Text = "Operaciones";
            foreach (var c in this.banco.Clientes[indice].Cuentas)
            {
                cuentas.Add(c);
            }
            foreach (var a in cuentas)
            {
                CBU.Add(a.CBU1);
            }
            comboCuenta.DataSource = CBU;
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            int indiceCBU = comboCuenta.SelectedIndex;
            decimal saldo = banco.Clientes[indice].Cuentas[indiceCBU].Saldo;
            MessageBox.Show("El saldo es: $" + saldo);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            int indiceCBU = comboCuenta.SelectedIndex;
            decimal deposito;
            string ingresoDeposito = VentanaIngreso.ShowDialog("Ingrese el monto:", "Deposito");
            if(!decimal.TryParse(ingresoDeposito, out deposito))
            {
                MessageBox.Show("Monto incorrecto");
            }
            else
            {
                banco.Clientes[indice].Depositar(deposito, banco.Clientes[indice].Cuentas[indiceCBU]);
                banco.ActualizarSaldo(deposito, true);
            }

        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            int indiceCBU = comboCuenta.SelectedIndex;
            decimal extraccion;
            try
            {
                CuentaCorriente cuenta1 = banco.Clientes[indice].Cuentas[indiceCBU] as CuentaCorriente;
                this.descubierto = cuenta1.SaldoDescubierto;
                MessageBox.Show("Su saldo descubierto es de: $" + descubierto);
                string ingresoExtraccion = VentanaIngreso.ShowDialog("Ingrese el monto:", "Extraccion");
                if (!decimal.TryParse(ingresoExtraccion, out extraccion))
                {
                    MessageBox.Show("Monto incorrecto");
                }
                else if (extraccion > (banco.Clientes[indice].Cuentas[indiceCBU].Saldo + descubierto))
                {
                    MessageBox.Show("Saldo insuficiente");
                }
                else
                {
                    banco.Clientes[indice].Extraer(extraccion, banco.Clientes[indice].Cuentas[indiceCBU]);
                    banco.ActualizarSaldo(extraccion, false);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Recuerde que la caja de ahorro no tiene saldo descubierto.");
                string ingresoExtraccion = VentanaIngreso.ShowDialog("Ingrese el monto:", "Extraccion");
                if (!decimal.TryParse(ingresoExtraccion, out extraccion))
                {
                    MessageBox.Show("Monto incorrecto");
                }
                else if (extraccion > banco.Clientes[indice].Cuentas[indiceCBU].Saldo)
                {
                    MessageBox.Show("Saldo insuficiente");
                }
                else
                {
                    banco.Clientes[indice].Extraer(extraccion, banco.Clientes[indice].Cuentas[indiceCBU]);
                    banco.ActualizarSaldo(extraccion, false);
                }
            }
        }

        private void btnSimularPF_Click(object sender, EventArgs e)
        {
            decimal monto = 0;
            int dias = 0;
            decimal total = 0;

            if(!decimal.TryParse(textMonto.Text, out monto))
            {
                MessageBox.Show("El monto ingresado es incorrecto");
            }
            else if (!int.TryParse(textDias.Text, out dias))
            {
                MessageBox.Show("La cantidad de dias ingresada es incorrecta");
            } else if (dias > 365)
            {
                MessageBox.Show("El Plazo Fijo no puede ser mayor a 365 dias");
            }
            else
            {
                total = Cliente.SimularPlazoFijo(monto, dias);
                MessageBox.Show("El Plazo Fijo le dara un monto de $" + total.ToString("0.00") + " al finalizar");
            }
        }

        private void btnPlazoFijo_Click(object sender, EventArgs e)
        {
            decimal monto = 0;
            int dias = 0;
            int indiceCBU = comboCuenta.SelectedIndex;

            if (!decimal.TryParse(textMontoPF.Text, out monto))
            {
                MessageBox.Show("El monto ingresado es incorrecto");
            }
            else if (!int.TryParse(textDiasPF.Text, out dias))
            {
                MessageBox.Show("La cantidad de dias ingresada es incorrecta");
            }
            else if (dias > 365)
            {
                MessageBox.Show("El Plazo Fijo no puede ser mayor a 365 dias");
            }
            else
            {
                if (banco.Clientes[indice].ConstituirPlazoFijo(monto, dias, banco.Clientes[indice].Cuentas[indiceCBU]))
                {
                    MessageBox.Show("El plazo fijo se realizo correctamente");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente para realizar el plazo fijo");
                }
            }
        }
    }
}
