using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    public static class Utilidades
    {
        public static int LlenarNumeroEntero()
        {
            int numeroEntero = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    while (numeroEntero <= 0)
                    {
                        numeroEntero = Convert.ToInt32(Console.ReadLine());
                        if (numeroEntero <= 0)
                        {
                            Console.Write("[!] No puede ingresar numeros negativos...\nIntente de nuevo: ");
                        }
                        valido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... " + ex);
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroEntero;
        }
        public static bool ObtenerBooleanoNatural(int numero)
        {
            return numero > 0;
        }
        public static string LlenarString()
        {
            string cadena = string.Empty;
            bool valido = false;
            while (!valido)
            {
                cadena = Console.ReadLine();
                if (!string.IsNullOrEmpty(cadena))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("[!] No puede ingresar datos vacíos...");
                    Console.Write("Intente de nuevo: ");
                }
            }
            return cadena;
        }
        public static double LlenarNumeroDouble()
        {
            double numeroDouble = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    numeroDouble = Convert.ToDouble(Console.ReadLine());
                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroDouble;
        }
    }
}
