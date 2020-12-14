using Caravan_Pro_001.Models;
using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_pro_Nr001
{
    class Program
    {
        static void Main(string[] args)
        {
            Caravan caravan = new Caravan(3, 3, 4, 3000);
            Console.WriteLine("banden " + caravan.AantalBandeen);
            //Console.WriteLine("slap" + caravan.AantalSlaapKamers);
            //Console.WriteLine("bewon" + caravan.BewoonbaarOppervvlakte);
            //Console.WriteLine("gewigt" + caravan.Gewicht);
        }
    }
}
