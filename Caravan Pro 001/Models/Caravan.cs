using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Caravan : Aanhangwagen, IBewoonbaar
    {
        int aantalslaapkamers;
        double bewoonbaaroppervlakte;

        public int AantalSlaapKamers
        {
            get
            {
                return aantalslaapkamers;
            }
            private set
            {
                if (value == 1)
                {
                    Console.WriteLine("het aantalslaapkamers is niet curect zijn");
                }
                aantalslaapkamers = value;

            }
        }

        public double BewoonbaarOppervvlakte
        {
            get
            {
                return bewoonbaaroppervlakte;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" het bewoonbaar oppervlakte niet negatief kan zijn");
                }
                bewoonbaaroppervlakte = value;
            }
        }
        public Caravan(int aantalslaapkamer, double bewoonbaaroppervlakte, int aantalbanden, int gewigt, string eignaar, double prijs)
            : base(aantalbanden, gewigt, eignaar,prijs)
        {
            this.AantalSlaapKamers = aantalslaapkamer;
            this.BewoonbaarOppervvlakte = bewoonbaaroppervlakte;
        }

    }
}
