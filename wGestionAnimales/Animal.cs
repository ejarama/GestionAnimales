using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionAnimales
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Animal( string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public abstract void HacerSonido();

    }
}
