using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    class Cica : Allat
    {
        public int Elet { get; set; } = 9;
        public ConsoleColor Szin { get; set; }


        public static Cica Parse(object valami)
        {
            return (Cica)valami;
        }
        public new string ToString()
        {
            return this.Nev;
        }
        public void Nyavog()
        {
            Console.WriteLine("meow-meow!");
        }
    }
}
