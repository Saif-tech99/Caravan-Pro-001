using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Woonboot : Boot, IBewoonbaar
    {
        int aantalslapkamers;
        double bewoonbaarOv;
        public int AantalSlaapKamers
        {
            get
            {
                return aantalslapkamers;
            }
            private set
            {
                if (value <= 2 || value >= 0)
                {
                    aantalslapkamers = value;
                }
                if (value < 0 || value > 2)
                {
                    Console.WriteLine("rowng value");
                }
            }
        }

        public double BewoonbaarOppervvlakte
        {
            get
            {
                return bewoonbaarOv;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("rowng entery");
                }
                bewoonbaarOv = value;
            }
        }
        public Woonboot(int slaapkamers, double bewoonbaarvO, int maxs, int snelh, string bmerk, string eignaar, double prijs)
            : base(maxs, snelh, bmerk,eignaar,prijs)
        {
            this.AantalSlaapKamers = slaapkamers;
            this.BewoonbaarOppervvlakte = bewoonbaarvO;
        }
    }
}
