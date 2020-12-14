using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Intarfaces
{
    public interface ITrekker
    {
        ITrekbaar aanHangwagen { get; }
        int MaximalITtrekGewegt { get; }

        void KoppelAanhangwagen(ITrekbaar aanhangwagen);

    }
}
