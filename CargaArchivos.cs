using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Pablo_Caneva_parcial.DatosCuentas;
using System.Threading;

namespace Pablo_Caneva_parcial
{
    public static class CargaArchivos
    {
        internal static void PersonasCA(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personasca.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (StreamReader archivoBanco = new StreamReader(fs))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], input[3], decimal.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture));
                    }
                    archivoBanco.Close();
                    archivoBanco.Dispose();
                }
                fs.Close();
                fs.Dispose();
            }
        }

        internal static void PersonasCC(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personascc.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (StreamReader archivoBanco = new StreamReader(fs))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], input[3], decimal.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), decimal.Parse(input[8], CultureInfo.CurrentCulture));
                    }
                    archivoBanco.Close();
                    archivoBanco.Dispose();
                }
                fs.Close();
                fs.Dispose();
            }
        }

        internal static void EmpresasCA(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresasca.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (StreamReader archivoBanco = new StreamReader(fs))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], bool.Parse(input[3]), long.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture));
                    }
                    archivoBanco.Close();
                    archivoBanco.Dispose();
                }
                fs.Close();
                fs.Dispose();
            }
        }

        internal static void EmpresasCC(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresascc.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (StreamReader archivoBanco = new StreamReader(fs))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], bool.Parse(input[3]), long.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), decimal.Parse(input[8], CultureInfo.CurrentCulture));
                    }
                    archivoBanco.Close();
                    archivoBanco.Dispose();
                }
                fs.Close();
                fs.Dispose();
            }
        }

        internal static void PlazosFijos(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\plazosfijos.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (StreamReader archivoBanco = new StreamReader(fs))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        int indice = banco.OperarCuenta(input[0]);
                        PlazoFijo pf = new PlazoFijo(int.Parse(input[1], CultureInfo.CurrentCulture), decimal.Parse(input[2], CultureInfo.CurrentCulture));
                        banco.Cuentas[indice].PlazoFijos.Add(pf);
                    }
                    archivoBanco.Close();
                    archivoBanco.Dispose();
                }
                fs.Close();
                fs.Dispose();
            }
        }

        internal static void GuardarPersonaCA(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo)
        {
            const int intentos = 5;
            const int delay = 1000;
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personasca.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                using (StreamWriter archivoGuardar = new StreamWriter(fs))
                {
                    var line = cuit + "|" + nombre + "|" + apellido + "|" + condicionFiscal + "|" + totalRecibos.ToString() + "|" + recibos.ToString() + "|" + CBU + "|" + saldo.ToString();
                    for (int i = 0; i <= intentos; i++)
                    {
                        try
                        {
                            archivoGuardar.Write("\n" + line);
                            break;
                        }
                        catch (IOException e) when (i <= intentos)
                        {
                            Thread.Sleep(delay);
                        }
                    }
                    archivoGuardar.Close();
                }
            }
        }

        internal static void GuardarPersonaCC(string cuit, string nombre, string apellido, string condicionFiscal, decimal totalRecibos, bool recibos, string CBU, decimal saldo, decimal descubierto)
        {
            const int intentos = 5;
            const int delay = 1000;
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personascc.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                using (StreamWriter archivoGuardar = new StreamWriter(fs))
                {
                    var line = cuit + "|" + nombre + "|" + apellido + "|" + condicionFiscal + "|" + totalRecibos.ToString() + "|" + recibos.ToString() + "|" + CBU + "|" + saldo.ToString() + "|" + descubierto.ToString();
                    for (int i = 0; i <= intentos; i++)
                    {
                        try
                        {
                            archivoGuardar.Write("\n" + line);
                            break;
                        }
                        catch (IOException e) when (i <= intentos)
                        {
                            Thread.Sleep(delay);
                        }
                    }
                    archivoGuardar.Close();
                }
            }
        }

        internal static void GuardarEmpresaCA(string cuit, string razonSocial, string condicionFiscal, bool balance, long ingresosBrutos, bool acta, string CBU, decimal saldo)
        {
            const int intentos = 5;
            const int delay = 1000;
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresasca.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                using (StreamWriter archivoGuardar = new StreamWriter(fs))
                {
                    var line = cuit + "|" + razonSocial + "|" + condicionFiscal + "|" + balance.ToString() + "|" + ingresosBrutos.ToString() + "|" + acta.ToString() + "|" + CBU + "|" + saldo.ToString();
                    for (int i = 0; i <= intentos; i++)
                    {
                        try
                        {
                            archivoGuardar.Write("\n" + line);
                            break;
                        }
                        catch (IOException e) when (i <= intentos)
                        {
                            Thread.Sleep(delay);
                        }
                    }
                    archivoGuardar.Close();
                }
            }
        }

        internal static void GuardarEmpresaCC(string cuit, string razonSocial, string condicionFiscal, bool balance, long ingresosBrutos, bool acta, string CBU, decimal saldo, decimal descubierto)
        {
            const int intentos = 5;
            const int delay = 1000;
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresascc.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                using (StreamWriter archivoGuardar = new StreamWriter(fs))
                {
                    var line = cuit + "|" + razonSocial + "|" + condicionFiscal + "|" + balance.ToString() + "|" + ingresosBrutos.ToString() + "|" + acta.ToString() + "|" + CBU + "|" + saldo.ToString() + "|" + descubierto.ToString();
                    for (int i = 0; i <= intentos; i++)
                    {
                        try
                        {
                            archivoGuardar.Write("\n" + line);
                            break;
                        }
                        catch (IOException e) when (i <= intentos)
                        {
                            Thread.Sleep(delay);
                        }
                    }
                    archivoGuardar.Close();
                }
            }
        }

        internal static void GuardarPlazoFijo(string CBU, int dias, decimal total)
        {
            const int intentos = 5;
            const int delay = 1000;
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\plazosfijos.txt";
            if (File.Exists(rutaArchivo))
            {
                var fs = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                using (StreamWriter archivoGuardar = new StreamWriter(fs))
                {
                    var line = CBU + "|" + dias.ToString() + "|" + total.ToString("0.00");
                    for (int i = 0; i <= intentos; i++)
                    {
                        try
                        {
                            archivoGuardar.Write("\n" + line);
                            break;
                        }
                        catch (IOException e) when (i <= intentos)
                        {
                            Thread.Sleep(delay);
                        }
                    }
                    archivoGuardar.Close();
                }
            }
        }

        internal static void ActualizarSaldo(string cbu, decimal saldoAnterior, decimal saldoNuevo)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
            string saldoAnt = "|" + saldoAnterior.ToString();
            string saldoN = "|" + saldoNuevo.ToString();
            string line;
            bool bandera1 = false;
            bool bandera2 = false;
            bool bandera3 = false;
            bool bandera4 = false;
            string rutaArchivo1, rutaArchivo2, rutaArchivo3, rutaArchivo4;
            rutaArchivo1 = rutaArchivo2 = rutaArchivo3 = rutaArchivo4 = Directory.GetCurrentDirectory();
            rutaArchivo1 = rutaArchivo1 + @"\bancos\personasca.txt";
            rutaArchivo2 = rutaArchivo2 + @"\bancos\personascc.txt";
            rutaArchivo3 = rutaArchivo3 + @"\bancos\empresasca.txt";
            rutaArchivo4 = rutaArchivo4 + @"\bancos\empresasca.txt";
            var fs1 = new FileStream(rutaArchivo1, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            var fs2 = new FileStream(rutaArchivo2, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            var fs3 = new FileStream(rutaArchivo3, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            var fs4 = new FileStream(rutaArchivo4, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            using (StreamReader archivoBancoPCA = new StreamReader(fs1))
            {
                while ((line = archivoBancoPCA.ReadLine()) != null)
                {
                    if (line.Contains(cbu))
                    {
                        bandera1 = true;
                        archivoBancoPCA.Close();
                        break;
                    }
                }
            }
            fs1.Close();
            if (bandera1)
            {
                string text = File.ReadAllText(rutaArchivo1);
                text = text.Replace(saldoAnt, saldoN);
                using (StreamWriter archivoGuardar = new StreamWriter(rutaArchivo1))
                {
                    archivoGuardar.Write(text);
                }
            }

            using (StreamReader archivoBancoPCC = new StreamReader(fs2))
            {
                while ((line = archivoBancoPCC.ReadLine()) != null)
                {
                    if (line.Contains(cbu))
                    {
                        bandera2 = true;
                        archivoBancoPCC.Close();
                        break;
                    }
                }
            }
            fs2.Close();
            if (bandera2)
            {
                string text = File.ReadAllText(rutaArchivo2);
                text = text.Replace(saldoAnt, saldoN);
                using (StreamWriter archivoGuardar = new StreamWriter(rutaArchivo2))
                {
                    archivoGuardar.Write(text);
                }
            }

            using(StreamReader archivoBancoECA = new StreamReader(fs3))
            {
                while ((line = archivoBancoECA.ReadLine()) != null)
                {
                    if (line.Contains(cbu))
                    {
                        bandera3 = true;
                        archivoBancoECA.Close();
                        break;
                    }
                }
            }
            fs3.Close();
            if (bandera3)
            {
                string text = File.ReadAllText(rutaArchivo3);
                text = text.Replace(saldoAnt, saldoN);
                using (StreamWriter archivoGuardar = new StreamWriter(rutaArchivo3))
                {
                    archivoGuardar.Write(text);
                }
            }

            using(StreamReader archivoBancoECC = new StreamReader(fs4))
            {
                while ((line = archivoBancoECC.ReadLine()) != null)
                {
                    if (line.Contains(cbu))
                    {
                        bandera4 = true;
                        archivoBancoECC.Close();
                        break;
                    }
                }
            }
            fs4.Close();
            if (bandera4)
            {
                string text = File.ReadAllText(rutaArchivo4);
                text = text.Replace(saldoAnt, saldoN);
                using (StreamWriter archivoGuardar = new StreamWriter(rutaArchivo4))
                {
                    archivoGuardar.Write(text);
                }
            }
        }
    }
}
