﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Kasteel : Huis
    {
        int slaapkamers;
        public override int AantalSlaapKamers
        {
            get
            {
                return slaapkamers;
            }
            protected set
            {
                if (value < 3)
                {
                    Console.WriteLine("rowng entery");
                }
                slaapkamers = value;
            }
        }
        public override double BewoonbaarOppervvlakte => base.BewoonbaarOppervvlakte;

        public Kasteel(int slaapk, double bewoonbaar, string eignaar, double prijs)
            : base(slaapk, bewoonbaar,eignaar, prijs)
        {
            this.AantalSlaapKamers = slaapk;
        }
    }
}
