using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    class Cica : Allat, ISaveanle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Elet { get; set; } = 9;
        public ConsoleColor Szin { get; set; }

        public int Eletkor => DateTime.Now.Year - Szul.Year;

        public void Damage(int dmg) => Elet -= dmg;

        public void Save()
        {
            var sw = new StreamWriter(
                DateTime.Now.ToString("yyyy_MM_dd") + ".txt",
                true, Encoding.UTF8);

            sw.WriteLine("-----");
            sw.WriteLine("obj:CICA");
            sw.WriteLine($"pos:[{X};{Y}]");
            sw.WriteLine($"lif:{this.Elet}");
            sw.Close();
        }

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
