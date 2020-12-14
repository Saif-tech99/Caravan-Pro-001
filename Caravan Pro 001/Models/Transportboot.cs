using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Transportboot : Boot, IBelaadbaar
    {
        private bool IsSunk;
        private int maxg;
        private int _huidigeBelading;

        public int HuidigeBelading
        {
            get { return _huidigeBelading; }
            private set { _huidigeBelading = value; }
        }


        public int MaximumLaadgewicht
        {
            get
            {
                return maxg;
            }
            set
            {
                maxg = value;
            }
        }

        public void Laden(int gewicht)
        {
            HuidigeBelading += gewicht;
            if (HuidigeBelading > MaximumLaadgewicht)
            {
                IsSunk = true;
                Snelheid = 0;
                throw new InvalidOperationException("huidingbelaading is grooter dan de maximum gewicht");
            }
        }

        public void Lossen(int gewicht)
        {
            HuidigeBelading += gewicht;
            if (HuidigeBelading < MaximumLaadgewicht)
            {
                IsSunk = false;
                Snelheid++;
            }
        }

        public Transportboot(int maxs, string bmerk, int snelh, string eignaar, double prijs,int maxg, int hg)
            : base(maxs, snelh, bmerk, eignaar, prijs)
        {
            this.MaximumLaadgewicht = maxg;
            this.HuidigeBelading = hg;
        }
    }
}
