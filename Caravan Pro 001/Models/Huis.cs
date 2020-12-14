using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Huis : Eigendom, IBewoonbaar
    {
         int slaapkamers;
         double bewoonbaar;
        public virtual int AantalSlaapKamers
        {
            get
            {
                return slaapkamers;
            }
            protected set
            {
                if (value <= 0)
                {
                    Console.WriteLine("rowng entery");
                }
                slaapkamers = value;
            }
        }

        public virtual double BewoonbaarOppervvlakte 
        {
            get
            {
                return bewoonbaar;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("rowng entery");
                }
                bewoonbaar = value;
            }
        }
        public Huis(int slaapk, double bewoonbaar, string eignaar, double prijs)
            :base(eignaar,prijs)
        {
            this.AantalSlaapKamers = slaapk;
            this.BewoonbaarOppervvlakte = bewoonbaar;
        }

        public override void BepaalPrijs(double nieuweprijs)
        {
            throw new NotImplementedException();
        }

        public override void VerkoopAan(string nieuweeigenaar)
        {
            throw new NotImplementedException();
        }
    }
}
