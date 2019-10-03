using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Allat>()
            {
                new Kutya() { Nev = "Brandon" },
                new Cica() { Nev = "Stahanov" },
                new Kutya() { Nev = "Pötyi" },
                new Kutya() { Nev = "Tanárúr" },
                new Cica() { Nev = "Rengar" },
            };

            foreach (var a in list)
            {
                Console.Write($"{a.Nev} mondja: ");

                if (a is Kutya)
                {
                    //((Kutya)a).Ugat();
                    (a as Kutya).Ugat();
                }
                else
                {
                    //Cica.Parse(a).Nyavog();
                    (a as Cica).Nyavog();
                }
            }

            Console.ReadKey();
        }
    }
}
