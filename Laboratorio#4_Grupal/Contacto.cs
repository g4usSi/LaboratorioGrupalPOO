﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    public class Contacto
    {
        public string Nombre { get; set; }
        private int NumeroDeTelefono { get; set;}
        private string Direccion { get; set; }
        public Contacto(string nombre, int numeroTelefono, string direccion) 
        {
            this.Nombre = nombre;
            this.NumeroDeTelefono = numeroTelefono;
            this.Direccion = direccion;
        }
        public Contacto() { }
        public virtual void AgregarContacto()
        {
            Console.Write("Ingrese el nombre: ");
                this.Nombre = Utilidades.LlenarString().ToLower();
            Console.Write("Ingrese el numero de teléfono: ");
                this.NumeroDeTelefono = Utilidades.LlenarNumeroEntero();
            Console.Write("Ingrese la dirección: ");
                this.Direccion = Utilidades.LlenarString();
        }
        public virtual void MostrarContacto(Contacto contactoActual)
        {
            if (contactoActual != null)
            {
                Console.WriteLine($"Nombre: {contactoActual.Nombre}");
                Console.WriteLine($"Numero de Telefono: {contactoActual.NumeroDeTelefono}");
                Console.WriteLine($"Direccion: {contactoActual.Direccion}");
            }
            else
            {
                Console.WriteLine("No existe el contacto...");
                return;
            }
        }
        public void MostrarTodosContactos(List<Contacto> listaContactos)
        {
            if (listaContactos != null && listaContactos.Count > 0)
            {
                foreach (var contactoActual in listaContactos)
                {
                    contactoActual.MostrarContacto(contactoActual);
                    Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine("No hay contactos para mostrar.");
            }
        }

        public bool ExisteContacto(string nombre)
        {
            bool existe = true;

            if (Nombre != nombre)
            {
                existe = false;
            }
            return existe;

        }
        //Modificar
        public virtual void ModificarNumero(Contacto contactoActual) 
        {
            if (contactoActual != null)
            {
                contactoActual.MostrarContacto(contactoActual);
                Console.WriteLine();
                Console.WriteLine($"Ingrese el nuevo numero de telefono: ");
                contactoActual.NumeroDeTelefono = Utilidades.LlenarNumeroEntero();
            }
            else
            {
                Console.WriteLine("No se han encontrado coincidencias...");
                Console.WriteLine();
                return;
            }
        }
        public Contacto BuscarContacto(List<Contacto> listaContactos) 
        {
            Console.Write("Ingrese el nombre: ");
            string nombreBuscar = Utilidades.LlenarString();
            foreach (var contactoBuscar in listaContactos) 
            {
                if (contactoBuscar.Nombre == nombreBuscar) 
                { 
                    return contactoBuscar;
                }
            }
            
            return null;
        }

    }
}
