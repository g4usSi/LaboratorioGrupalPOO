using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    public class Corporativo : Contacto
    {
        private string InformacionDeContacto { get; set; }
        public Corporativo(string nombre, int numeroTelefono, string direccion, string redSocial)
            : base(nombre, numeroTelefono, direccion)
        {
            this.InformacionDeContacto = redSocial;
        }

    }
}
