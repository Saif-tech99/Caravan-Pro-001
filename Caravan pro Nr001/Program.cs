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
            Transportboot s = new Transportboot(3000, "AAA", 999, "QQQ", 444.55, 5000, 999);
            string ss = $"max speed : {s.MaximumSnelheid} model: {s.Merk} speed : {s.Snelheid} owner : {s.Eigenaar} " +
                $"prijs : {s.Prijs} maxkg : {s.MaximumLaadgewicht} kg :{s.HuidigeBelading}";
            Console.WriteLine($"{ss}");
            s.BepaalPrijs(333.55);
            s.VerkoopAan("saif");
            s.Laden(2200);
            s.Lossen(1000);
            s.Versnellen(200);
            s.Vertragen(100);
            Console.WriteLine(s.HuidigeBelading);
            Console.WriteLine(s.Snelheid);
            Boot boot = new Transportboot(3000, "AAA", 999, "QQQ", 444.55, 5000, 999);
        }
    }
}
