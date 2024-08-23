
using System;
using System.Collections.Generic;
using Laboratorio_4_Grupal;

namespace Laboratorio_4_Grupal
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto = new Contacto();
            List<Contacto> listaContactos = new List<Contacto>();
            bool continuar = true;
            do
            {
                Console.WriteLine("1. Crear contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Modificar número");
                Console.WriteLine("5. Eliminar contacto");
                Console.WriteLine("6. Salir");

                Console.WriteLine("Ingrese un número:");
                int opcion = Utilidades.LlenarNumeroEntero();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        switch (AgregarContacto())
                        {
                            case 1:
                                ContactoCorporativo nuevoCorporativo = new ContactoCorporativo();
                                nuevoCorporativo.AgregarContacto();
                                listaContactos.Add(nuevoCorporativo);
                                Console.WriteLine("Se agrego correctamente");
                                Console.WriteLine();
                                break;
                            case 2:
                                ContactoFavorito nuevoFavorito = new ContactoFavorito();
                                nuevoFavorito.AgregarContacto();
                                listaContactos.Add(nuevoFavorito);
                                Console.WriteLine("Se agrego correctamente");
                                Console.WriteLine();
                                break;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        MostrarTodosContactos(listaContactos);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (continuar == true);
        }

        public static int AgregarContacto()
        {
            Console.WriteLine("1. Corporativo");
            Console.WriteLine("2. favoritos");
            int opcion = Utilidades.LlenarNumeroEntero();

            return opcion;
        }

        public static void MostrarTodosContactos(List<Contacto> contactos)
        {
            int contador = 0;
            foreach (var contacto in contactos)
            {
                contador++;
                Console.WriteLine($"Contacto #{contador}");
                contacto.MostrarContacto(contacto);
                Console.WriteLine();
            }

        }


    }


}
