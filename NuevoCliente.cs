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
    internal partial class NuevoCliente : Form
    {
        private Banco banco { get; set; }
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private bool recibo1Cargado = false;
        private bool recibo2Cargado = false;
        private bool recibo3Cargado = false;
        private bool balanceCargado = false;
        private bool actaCargada = false;
        public NuevoCliente(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
            this.Text = "Nuevo Cliente";
        }

        private void radio_cambio(object sender, EventArgs e)
        {
            textDescubierto.Enabled = radioCC.Checked;
            textDescubierto2.Enabled = radioCC2.Checked;
        }

        private void btnRecibo1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            recibo1Cargado = true;
        }

        private void btnRecibo2_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            recibo2Cargado = true;
        }

        private void btnRecibo3_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            recibo3Cargado = true;
        }

        private void btnCargarBalance_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            balanceCargado = true;
        }

        private void btnActa_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            actaCargada = true;
        }

        private void btnCrearClientePersona_Click(object sender, EventArgs e)
        {
            long nroPrueba;
            string cuit = textCUIT.Text;
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string condicionFiscal = comboCondFiscal.Text;
            decimal recibo1 = 0;
            decimal recibo2 = 0;
            decimal recibo3 = 0;
            decimal totalrecibos;
            string codPostal = textCP.Text;
            string filial = textFilial.Text;
            string nrocuenta = textNroCuenta.Text;
            string cbu;
            decimal saldo = 0;
            decimal descubierto = 0;
            bool recibosCargados = false;
            bool cargar = false;

            if ((recibo1Cargado) && (recibo2Cargado) && (recibo3Cargado))
            {
                recibosCargados = true;
            }
            if(!long.TryParse(cuit, out nroPrueba))
            {
                MessageBox.Show("El Cuit ingresado no es correcto");
            } else if (!banco.ValidarCuit(cuit))
            {
                MessageBox.Show("El Cuit ingresado no es correcto");
            } else if (!banco.ValidarTexto(nombre))
            {
                MessageBox.Show("El nombre ingresado no es correcto");
            } else if (!banco.ValidarTexto(apellido))
            {
                MessageBox.Show("El apellido ingresado no es correcto");
            } else if (comboCondFiscal.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar la condicion fiscal");
            } else if (!decimal.TryParse(textRecibo1.Text, out recibo1))
            {
                MessageBox.Show("El total del recibo 1 ingresado no es correcto");
            } else if (!decimal.TryParse(textRecibo2.Text, out recibo2))
            {
                MessageBox.Show("El total del recibo 2 ingresado no es correcto");
            } else if (!decimal.TryParse(textRecibo3.Text, out recibo3))
            {
                MessageBox.Show("El total del recibo 3 ingresado no es correcto");
            } else if(!long.TryParse(codPostal, out nroPrueba))
            {
                MessageBox.Show("El codigo postal ingresado no es correcto");
            } else if(!long.TryParse(filial, out nroPrueba))
            {
                MessageBox.Show("El numero de filial ingresado no es corecto");
            } else if(!long.TryParse(nrocuenta, out nroPrueba))
            {
                MessageBox.Show("El numero de cuenta ingresado no es correcto");
            } else if (!radioCA.Checked && !radioCC.Checked)
            {
                MessageBox.Show("Debe elegir si es una Caja de Ahorro o una Cuenta Corriente");
            } else if (!decimal.TryParse(textSaldo.Text, out saldo))
            {
                MessageBox.Show("El saldo ingresado no es correcto");
            } else if (!decimal.TryParse(textDescubierto.Text, out descubierto))
            {
                MessageBox.Show("El descubierto ingresado no es correcto");
            } else if (!recibosCargados)
            {
                MessageBox.Show("Debe cargar los recibos");
            } else { cargar = true; }

            totalrecibos = recibo1 + recibo2 + recibo3;

            if (cargar)
            {
                if (radioCA.Checked)
                {
                    cbu = codPostal + filial + nrocuenta + "01";
                    banco.AgregarCliente(cuit, nombre, apellido, condicionFiscal, totalrecibos, recibosCargados, cbu, saldo);
                    CargaArchivos.GuardarPersonaCA(cuit, nombre, apellido, condicionFiscal, totalrecibos, recibosCargados, cbu, saldo);
                    this.Close();
                }
                if (radioCC.Checked)
                {
                    cbu = codPostal + filial + nrocuenta + "02";
                    banco.AgregarCliente(cuit, nombre, apellido, condicionFiscal, totalrecibos, recibosCargados, cbu, saldo, descubierto);
                    CargaArchivos.GuardarPersonaCC(cuit, nombre, apellido, condicionFiscal, totalrecibos, recibosCargados, cbu, saldo, descubierto);
                    this.Close();
                }
            }
        }

        private void btnCrearClienteEmpresa_Click(object sender, EventArgs e)
        {
            long nroPrueba;
            string cuit = textCUIT2.Text;
            string razonSocial = textRazonSocial.Text;
            string condicionFiscal = comboCondFisc2.Text;
            long nroIIBB = 0;
            bool balance = false;
            bool acta = false;
            string codPostal = textCP2.Text;
            string filial = textFilial2.Text;
            string nrocuenta = textNroCuenta2.Text;
            string cbu;
            decimal saldo = 0;
            decimal descubierto = 0;
            bool cargar = false;

            if (balanceCargado)
            {
                balance = true;
            }
            if (actaCargada)
            {
                acta = true;
            }

            if (!long.TryParse(cuit, out nroPrueba))
            {
                MessageBox.Show("El Cuit ingresado no es correcto");
            }
            else if (!banco.ValidarCuit(cuit))
            {
                MessageBox.Show("El Cuit ingresado no es correcto");
            }
            else if (razonSocial == "")
            {
                MessageBox.Show("Debe ingresar la razon social de la empresa");
            }
            else if (comboCondFisc2.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar la condicion fiscal");
            }
            else if (!long.TryParse(textIIBB.Text, out nroIIBB))
            {
                MessageBox.Show("El numero de inscripcion de Ingresos Brutos no es correcto");
            }
            else if (!long.TryParse(codPostal, out nroPrueba))
            {
                MessageBox.Show("El codigo postal ingresado no es correcto");
            }
            else if (!long.TryParse(filial, out nroPrueba))
            {
                MessageBox.Show("El numero de filial ingresado no es corecto");
            }
            else if (!long.TryParse(nrocuenta, out nroPrueba))
            {
                MessageBox.Show("El numero de cuenta ingresado no es correcto");
            }
            else if (!radioCA2.Checked && !radioCC2.Checked)
            {
                MessageBox.Show("Debe elegir si es una Caja de Ahorro o una Cuenta Corriente");
            }
            else if (!decimal.TryParse(textSaldo2.Text, out saldo))
            {
                MessageBox.Show("El saldo ingresado no es correcto");
            }
            else if (!decimal.TryParse(textDescubierto2.Text, out descubierto))
            {
                MessageBox.Show("El descubierto ingresado no es correcto");
            }
            else if (!balance)
            {
                MessageBox.Show("Debe cargar el último balance");
            }
            else if (!acta)
            {
                MessageBox.Show("Debe cargar el acta societaria");
            }
            else { cargar = true; }

            if (cargar)
            {
                if (radioCA2.Checked)
                {
                    cbu = codPostal + filial + nrocuenta + "01";
                    banco.AgregarCliente(cuit, razonSocial, condicionFiscal, balance.ToString(), nroIIBB, acta, cbu, saldo);
                    CargaArchivos.GuardarEmpresaCA(cuit, razonSocial, condicionFiscal, balance, nroIIBB, acta, cbu, saldo);
                    this.Close();
                }
                if (radioCC2.Checked)
                {
                    cbu = codPostal + filial + nrocuenta + "02";
                    banco.AgregarCliente(cuit, razonSocial, condicionFiscal, balance, nroIIBB, acta, cbu, saldo, descubierto);
                    CargaArchivos.GuardarEmpresaCC(cuit, razonSocial, condicionFiscal, balance, nroIIBB, acta, cbu, saldo, descubierto);
                    this.Close();
                }
            }
        }
    }
}
