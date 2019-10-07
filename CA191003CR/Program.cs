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
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //var list = new List<Allat>()
            //{
            //    new Kutya() { Nev = "Brandon" },
            //    new Cica() { Nev = "Stahanov" },
            //    new Kutya() { Nev = "Pötyi" },
            //    new Kutya() { Nev = "Tanárúr" },
            //    new Cica() { Nev = "Rengar" },
            //};

            //foreach (var a in list)
            //{
            //    Console.Write($"{a.Nev} mondja: ");

            //    if (a is Kutya)
            //    {
            //        //((Kutya)a).Ugat();
            //        (a as Kutya).Ugat();
            //    }
            //    else
            //    {
            //        //Cica.Parse(a).Nyavog();
            //        (a as Cica).Nyavog();
            //    }
            //}


            //var c = new Cica();
            //var k = new Kutya();

            ////abstract osztályt NEM lehet példányosítani!
            ////var a = new Allat();

            ////Allat a = new Kutya();

            var c1 = new Cica() { X = 0, Y = 0 };
            var c2 = new Cica() { X = 1, Y = 0 };
            var k = new Kocsog() {
                X = 5, Y = 5,
                Material = "vibranium"};

            for (int i = 0; i < 1000; i++)
            {
                c1.X = rnd.Next(10);
                c1.Y = rnd.Next(10);
                c2.X = rnd.Next(10);
                c2.Y = rnd.Next(10);
                k.X = rnd.Next(10);
                k.Y = rnd.Next(10);

                if (k.X == c1.X && k.Y == c1.Y) c1.Elet--;
                if (k.X == c2.X && k.Y == c2.Y) c2.Elet--;
            }

            var menteniValok = new List<ISaveanle>
            {
                c1, c2, k
            };

            foreach (var s in menteniValok)
            {
                s.Save();
            }

            Console.ReadKey();
        }
    }
}
