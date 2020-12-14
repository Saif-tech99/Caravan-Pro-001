using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Intarfaces
{
   public interface IVoertuig
    {
        int MaximumSnelheid { get; }
        int Snelheid { get; }
        string Merk { get; }

        void Versnellen(int versneling);
        void Vertragen(int vertraging);
    }
}
