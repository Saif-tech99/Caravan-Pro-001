using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Aanhangwagen : Eigendom, ITrekbaar
    {
        int aantalbanden;
        int gewigt;
        public int AantalBandeen
        {
            get
            {
                return aantalbanden;
            }
            private set
            {
                if (value < 2)
                {
                    Console.WriteLine("rowng");
                }
                aantalbanden = value;

            }
        }

        public int Gewicht
        {
            get
            {
                return gewigt;
            }
            private set
            {
                if (value >= 0)
                {
                    gewigt = value;
                    //Console.WriteLine("er iets fout met jouw wagen");
                }
            }
        }
        public Aanhangwagen(int aantalbanden, int gewigt, string eignaar, double prijs)
            : base(eignaar, prijs)
        {
            this.AantalBandeen = aantalbanden;
            this.Gewicht = gewigt;
        }

        public override void BepaalPrijs(double nieuweprijs)
        {
            
        }

        public override void VerkoopAan(string nieuweeigenaar)
        {
            throw new NotImplementedException();
        }
    }
}
