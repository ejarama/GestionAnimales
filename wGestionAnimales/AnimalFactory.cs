using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionAnimales
{
    public static class AnimalFactory
    {
        public static Animal CrearAnimal(string tipo, string nombre, int edad)
        {
            try
            {
                switch (tipo)
                {
                    case "León":
                        return new Leon(nombre, edad);
                    case "Elefante":
                        return new Elefante(nombre, edad);
                    case "Serpiente":
                        return new Serpiente(nombre, edad);

                    default:
                        throw new ArgumentException("Tipo de animal no soportado");
                }
            }
            catch (Exception)
            {

                throw new ArgumentException("Tipo de animal no soportado");
            }

        }
    }
}
