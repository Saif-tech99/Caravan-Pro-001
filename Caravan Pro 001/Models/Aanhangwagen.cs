using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Aanhangwagen : ITrekbaar
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
                if (aantalbanden >=2)
                {
                    aantalbanden = value;
                }
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
                if (gewigt >= 0)
                {
                    gewigt = value;
                    //Console.WriteLine("er iets fout met jouw wagen");
                }
            }
        }
        public Aanhangwagen(int aantalbanden, int gewigt)
        {
            this.AantalBandeen = aantalbanden;
            this.Gewicht = gewigt;
        }
    }
}
