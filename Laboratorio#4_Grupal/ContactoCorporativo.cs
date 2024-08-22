using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio_4_Grupal
{
    internal class ContactoCorporativo : Contacto
    {
        public string CorreoElectronico {  get; set; }
        public string NombreEmpresa { get; set; }
        private string Cargo { get; set; }
        public ContactoCorporativo(string nombre, int numeroTelefono, string direccion, string NombreEmpresa, string Cargo, string CorreoElectronico)
            : base(nombre, numeroTelefono, direccion)
        {
            this.NombreEmpresa = NombreEmpresa;
            this.Cargo = Cargo;
            this.CorreoElectronico = CorreoElectronico;
        }
        public string ObtenerNombreEmpresa()
        {
            return NombreEmpresa;
        }

        public string ObtenerCargo()
        {
            return Cargo;
        }
        public string ObtenerCorreoElectronico()
        {
            return CorreoElectronico;
        }


        public void MostrarContactoCorporativo()
        {
            Console.WriteLine($"Nombre: {ObtenerNombre()}");
            Console.WriteLine($"Teléfono: {ObtenerNumeroTelefono()}");
            Console.WriteLine($"Dirección: {ObtenerDireccion()}");
            Console.WriteLine($"Empresa: {ObtenerNombreEmpresa()}");
            Console.WriteLine($"Cargo: {ObtenerCargo()}");
            Console.WriteLine($"Correo Electrónico: {ObtenerCorreoElectronico()}");

        }

    }
}
