using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Motorhome : Auto, IBewoonbaar
    {
         int aanslaapkamer;
       private double bewoonbaaroppervlakte;
        public int AantalSlaapKamers
        {
            get
            {
                return aanslaapkamer;
            }
            private set
            {
                if (value == 1)
                {
                    aanslaapkamer = value;
                }
                else
                {
                    Console.WriteLine("slaapkamer mot 1 zijn");
                }
            }
        }

        public double BewoonbaarOppervvlakte
        {
            get
            {
                return bewoonbaaroppervlakte;
            }
            private set
            {
                try
                {
                    if (value >= 0)
                    {
                        bewoonbaaroppervlakte = value;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("het bewoonbar oppervlakte mag niet kleiner zijn dan 0 ");
                }
                finally
                {
                    Console.WriteLine("closed");
                }
            }
        }
        public Motorhome(int slaapkamer, double bewoonbaaroppervlakte, int maxs, int maxg, int snelh, string automerk, ITrekbaar aanhangwagen, string eignaar, double prijs)
            :base(maxs, maxg, snelh, automerk, aanhangwagen, eignaar, prijs)
        {
            this.AantalSlaapKamers = slaapkamer;
            this.BewoonbaarOppervvlakte = bewoonbaaroppervlakte;
        }
    }
}

