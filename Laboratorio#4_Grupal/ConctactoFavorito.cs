using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    public class ConctactoFavorito : Contacto
    {
        public int DiasDeRacha { get; set; }
        public ConctactoFavorito(string nombre, int numeroTelefono, string direccion, int diasRacha)
        : base(nombre, numeroTelefono, direccion)
        {
            this.DiasDeRacha = 0;
        }
        public ConctactoFavorito()
        {
            this.DiasDeRacha = 0;
        }
        public override void MostrarContacto(Contacto contactoActual)
        {
            base.MostrarContacto(contactoActual);
            this.DiasDeRacha++;
            Console.Write("Los dias de racha son: ");
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

        private void MostrarRacha (Co)
        {
            
            this.DiasDeRacha++;
            Console.WriteLine($"LOS DIAS DE RACHA CON ESTE CONTACTO: {DiasDeRacha}  ");
        }
    }

}
