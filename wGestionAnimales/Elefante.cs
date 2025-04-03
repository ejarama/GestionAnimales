using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace wGestionAnimales
{
    public class Elefante : Animal
    {
        public Elefante(string nombre, int edad) : base(nombre, edad) { }

        public override void HacerSonido()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Marcela\source\repos\wGestionAnimales\sonidos\elefante.wav");
            player.Play();
        }
    }
}
