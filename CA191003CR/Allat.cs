using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    abstract class Allat
    {
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
        public bool Sex { get; set; }

        public void Eszik()
        {
            Console.WriteLine("nom-nom-nom");
        }
    }
}
