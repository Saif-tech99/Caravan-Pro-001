using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Huis : IBewoonbaar
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
                if (slaapkamers <= 0)
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
                if (bewoonbaar <= 0)
                {
                    Console.WriteLine("rowng entery");
                }
                bewoonbaar = value;
            }
        }
        public Huis(int slaapk, double bewoonbaar)
        {
            this.AantalSlaapKamers = slaapk;
            this.BewoonbaarOppervvlakte = bewoonbaar;
        }
    }
}
