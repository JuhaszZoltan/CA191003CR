using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    class Kutya : Allat
    {
        public int SzorHossz { get; set; }
        public void Ugat()
        {
            Console.WriteLine("vau-vau!");
        }
    }
}
