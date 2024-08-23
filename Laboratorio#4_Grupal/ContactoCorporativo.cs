using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio_4_Grupal
{
    public class ContactoCorporativo : Contacto
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

        public ContactoCorporativo()
        {
        }

        public override void AgregarContacto()
        {
            base.AgregarContacto();
            Console.Write("Ingrese el nombre de la empresa: ");
            this.NombreEmpresa = Utilidades.LlenarString();
            Console.Write("Ingrese el cargo: ");
            this.Cargo = Utilidades.LlenarString();
            Console.Write("Ingrese el correo electrónico: ");
            this.CorreoElectronico = Utilidades.LlenarString();
        }

        public override void MostrarContacto(Contacto contactoActual)
        {
            base.MostrarContacto(contactoActual);
            if (contactoActual is ContactoCorporativo contactoCorporativo)
            {
                Console.WriteLine($"Nombre de la Empresa: {contactoCorporativo.NombreEmpresa}");
                Console.WriteLine($"Cargo: {contactoCorporativo.Cargo}");
                Console.WriteLine($"Correo Electrónico: {contactoCorporativo.CorreoElectronico}");
            }
        }

        public override void ModificarNumero(Contacto contactoActual)
        {
            base.ModificarNumero(contactoActual);
        }

        public ContactoCorporativo BuscarContactoCorporativo(List<ContactoCorporativo> listaContactosCorporativos)
        {
            Console.Write("Ingrese el nombre de la empresa: ");
            string empresaBuscar = Utilidades.LlenarString();

            foreach (var contactoBuscar in listaContactosCorporativos)
            {
                if (contactoBuscar.NombreEmpresa == empresaBuscar)
                {
                    return contactoBuscar;
                }
            }

            return null;
        }

    }
}
