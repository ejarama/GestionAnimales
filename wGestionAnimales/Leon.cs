using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace wGestionAnimales
{
    public class Leon : Animal
    {
        public Leon(string nombre, int edad) : base(nombre, edad) { }

        public override void HacerSonido()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Marcela\source\repos\wGestionAnimales\sonidoLeon.wav");
            player.Play();
        }
    }
}
