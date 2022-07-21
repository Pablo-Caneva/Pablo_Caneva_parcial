using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

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
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], input[3], decimal.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void PersonasCAPF(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personascapf.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], input[3], decimal.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), int.Parse(input[8], CultureInfo.CurrentCulture), decimal.Parse(input[9], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void PersonasCC(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personascc.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], input[3], decimal.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), decimal.Parse(input[8], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void PersonasCCPF(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\personasccpf.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], input[3], decimal.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), decimal.Parse(input[8], CultureInfo.CurrentCulture), int.Parse(input[9], CultureInfo.CurrentCulture), decimal.Parse(input[10], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void EmpresasCA(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresasca.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], bool.Parse(input[3]), long.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void EmpresasCAPF(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresascapf.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], bool.Parse(input[3]), long.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), int.Parse(input[8], CultureInfo.CurrentCulture), decimal.Parse(input[9], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void EmpresasCC(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresascc.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], bool.Parse(input[3]), long.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), decimal.Parse(input[8], CultureInfo.CurrentCulture));
                    }
                }
            }
        }

        internal static void EmpresasCCPF(Banco banco)
        {
            string rutaArchivo = Directory.GetCurrentDirectory();
            rutaArchivo = rutaArchivo + @"\bancos\empresasccpf.txt";
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivoBanco = new StreamReader(rutaArchivo))
                {
                    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
                    string line;
                    while ((line = archivoBanco.ReadLine()) != null)
                    {
                        string[] input = line.Split('|');
                        banco.AgregarCliente(input[0], input[1], input[2], bool.Parse(input[3]), long.Parse(input[4], CultureInfo.CurrentCulture), bool.Parse(input[5]), input[6], decimal.Parse(input[7], CultureInfo.CurrentCulture), decimal.Parse(input[8], CultureInfo.CurrentCulture), int.Parse(input[9], CultureInfo.CurrentCulture), decimal.Parse(input[10], CultureInfo.CurrentCulture));
                    }
                }
            }
        }
    }
}
