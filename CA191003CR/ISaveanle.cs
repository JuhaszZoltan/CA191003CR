using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191003CR
{
    interface ISaveanle
    {
        int X { get; set; }
        int Y { get; set; }

        void Save();
    }
}
