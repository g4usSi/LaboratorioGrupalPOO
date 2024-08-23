using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    public class ContactoFavorito : Contacto
    {
        public int DiasDeRacha { get; set; }
        public ContactoFavorito(string nombre, int numeroTelefono, string direccion, int diasRacha)
        : base(nombre, numeroTelefono, direccion)
        {
            this.DiasDeRacha = diasRacha;
        }
        public ContactoFavorito()
        {
            this.DiasDeRacha = 0;
        }
        public override void MostrarContacto(Contacto contactoActual)
        {
            base.MostrarContacto(contactoActual);
            MostrarRacha(contactoActual);
        }

        public override void AgregarContacto()
        {
            base.AgregarContacto();
            
        }

        public override void ModificarNumero(Contacto contactoActual)
        {
            this.DiasDeRacha++;
            base.ModificarNumero(contactoActual);
        }

        private void MostrarRacha (Contacto contacto)
        {
            if (contacto is ContactoFavorito favorito)
            {
                favorito.DiasDeRacha++;
                Console.WriteLine($"LOS DIAS DE RACHA CON ESTE CONTACTO: {DiasDeRacha} ");
            }
        }
    }

}
