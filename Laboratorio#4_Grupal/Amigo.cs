using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    public class Amigo : Contacto
    {
        private string RedesSociales { get; set; }

        public Amigo(string nombre, int numeroTelefono, string direccion, string redSocial)
            :base(nombre, numeroTelefono, direccion)
        {
            this.RedesSociales = redSocial;
        }
        public Amigo()
        {}

        public override void AgregarContacto()
        {
            base.AgregarContacto();
            Console.Write("Ingrese la red social  del amigo: ");
            this.RedesSociales = Utilidades.LlenarString();
        }

        public override void MostrarContacto(Contacto contactoActual)
        {
            base.MostrarContacto(contactoActual);
            if (contactoActual is Amigo contactoactual)
            {
                Console.WriteLine($"Red: {RedesSociales}");
            }
        }

        public override void ModificarNumero(Contacto contactoActual)
        {
            base.ModificarNumero(contactoActual);
        }
    }
}
