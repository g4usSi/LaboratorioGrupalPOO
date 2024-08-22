using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Grupal
{
    internal class ConctactoFavorito: Contacto
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
    }

}
