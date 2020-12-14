using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public abstract class Eigendom : IEigendom
    {
        private string _eigenaar;

        public string Eigenaar
        {
            get { return _eigenaar; }
            private set { _eigenaar = value; }
        }

        private double _prijs;

        public double Prijs
        {
            get { return _prijs; }
            private set
            {
                if (value >= 0)
                {
                    _prijs = value;
                }
            }
        }
        public abstract void BepaalPrijs(double nieuweprijs);
        public abstract void VerkoopAan(string nieuweeigenaar);

        public Eigendom(string eignaar, double prijs)
        {
            this.Prijs = prijs;
            this.Eigenaar = eignaar;
        }
    }
}
