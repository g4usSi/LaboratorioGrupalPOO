using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    internal class Contacto
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
        public Contacto()
        {
            
        }
        public string ObtenerNombre()
        {
            return Nombre;
        }
        public int ObtenerNumeroTelefono()
        {
            return NumeroDeTelefono;
        }

        public string ObtenerDireccion()
        {
            return Direccion;
        }

        public void AgregarContacto()
        {

        }

        public void MostrarContacto()
        {

        }

        public void EliminarContacto()
        {

        }

    }
}
