using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Boot : IVoertuig
    {
        int maxs;
        int snelh;
        string bmerk;

        public int MaximumSnelheid
        {
            get
            {
                return maxs;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("MaximumSnelheid kan niet negatief zijn");
                }
                maxs = value;
            }
        }

        public int Snelheid
        {
            get
            {
                return snelh;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("de boot is kapot");
                }
                else if (value > maxs)
                {
                    Console.WriteLine("de huideg snelheid kan niet groter dan het maximum snelheid");
                }
                snelh = value;
            }
        }

        public string Merk
        {
            get
            {
                return bmerk;
            }
            private set
            {
                bmerk = value;
            }
        }

        public void Versnellen(int versneling)
        {
            if (snelh < maxs || snelh == 0)
            {
                versneling++;
                snelh = versneling;
            }
            Console.WriteLine(snelh);
        }

        public void Vertragen(int vertraging)
        {
            if (snelh == maxs)
            {
                vertraging--;
                snelh = vertraging;
            }
            Console.WriteLine(snelh);
        }
        public Boot(int maxs, int snelh, string bmerk)
        {
            this.Merk = bmerk;
            this.MaximumSnelheid = maxs;
            this.Snelheid = snelh;
        }
    }
}
