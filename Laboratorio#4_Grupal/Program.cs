
using System;
using System.Collections.Generic;
using Laboratorio_4_Grupal;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                            case 3:
                                Amigo nuevoAmigo = new Amigo();
                                nuevoAmigo.AgregarContacto();
                                listaContactos.Add(nuevoAmigo);
                                Console.WriteLine("Se agrego correctamente");
                                Console.WriteLine();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("No ha ingresado una opcion valida...");
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        MostrarTodosContactos(listaContactos);
                        break;
                    case 3:
                        Console.Clear();
                        contacto.MostrarContacto(contacto.BuscarContacto(listaContactos));
                        break;
                    case 4:
                        contacto.ModificarNumero(contacto.BuscarContacto(listaContactos));
                        break;
                    case 5:
                        Console.Clear();
                        EliminarContacto(listaContactos);
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
            Console.WriteLine("2. Favoritos");
            Console.WriteLine("3. Amigos");
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

        public static void EliminarContacto(List<Contacto> contactos)
        { bool existe = false;
            Console.WriteLine("Ingrese el nombre del contacto que desea eliminar");
             string nombre=Console.ReadLine();
            foreach (var contacto in contactos)
            {
                if (contacto.ExisteContacto(nombre) == true)
                {
                    int posicion = contactos.IndexOf(contacto);
                    contactos.RemoveAt(posicion);
                    Console.WriteLine("Se elimino el contacto");
                    existe = true;
                    break;
                }
            }
           if (existe==false)
            {
                Console.WriteLine("No existe el contacto");
            }
        }


    }


}
