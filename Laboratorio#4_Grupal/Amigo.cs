using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    internal class Amigo : Contacto
    {
        private string RedesSociales { get; set; }
        public Amigo(string nombre, int numeroTelefono, string direccion, string redSocial)
            :base(nombre, numeroTelefono, direccion)
        {
            this.RedesSociales = redSocial;
        }


    }
}
