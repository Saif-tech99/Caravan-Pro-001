using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Intarfaces
{
   public interface IEigendom
    {
        string Eigenaar { get; }
        double Prijs { get; }
        void BepaalPrijs(double nieuweprijs);
        void VerkoopAan(string nieuweeigenaar);
    }
}
