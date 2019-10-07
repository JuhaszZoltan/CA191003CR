using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    class Kocsog : ISaveanle
    {
        public ConsoleColor Szin { get; set; }
        public string Orszag { get; set; }
        public string Material { get; set; }
        public int X { set; get; }
        public int Y { set; get; }

        public void Save()
        {
            var sw = new StreamWriter(
                DateTime.Now.ToString("yyyy_MM_dd") + ".txt",
                true, Encoding.UTF8);

            sw.WriteLine("-----");
            sw.WriteLine("obj:KOCSOG");
            sw.WriteLine($"pos:[{X};{Y}]");
            sw.WriteLine($"mat:{this.Material}");

            sw.Close();
        }
    }
}
