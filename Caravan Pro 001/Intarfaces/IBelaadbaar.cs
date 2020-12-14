using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Intarfaces
{
    interface IBelaadbaar
    {
        int HuidigeBelading { get; }
        int MaximumLaadgewicht { get; }

        void Laden(int gewicht);
        void Lossen(int gewicht);
    }
}
