using Caravan_Pro_001.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Pro_001.Models
{
    public class Auto : Eigendom, IVoertuig, ITrekker
    {
         int maxg;
         int maxs;
         int snelh;
         string merk;
         ITrekbaar aanhangwagen;

        public int MaximumSnelheid
        {
            get
            {
                return maxs;
            }
            private set
            {
                if (maxs < snelh || maxs < 0)
                {
                    Console.WriteLine("maximum snelhed kan nit lager zijn dan snelheid");
                }
                maxs = value;
            }
        }
        public int Snelheid
        {
            get
            {
                return snelh;
            }
            private set
            {
                if (snelh > maxs)
                {
                    Console.WriteLine("snelheid kan nit lager zijn dan maximum snelhed");
                }
                else if (snelh < 0)
                {
                    Console.WriteLine("de auto kan nit achteruit rijden");
                }
                snelh = value;
            }
        }
        public string Merk
        {
            get
            {
                return merk;
            }
            private set
            {
                merk = value;
            }
        }
        public ITrekbaar aanHangwagen
        {
            get
            {
                return aanhangwagen;
            }
            private set
            {
                if (snelh > 0 || snelh < 0 || aanhangwagen.Gewicht > MaximalITtrekGewegt)
                {
                    throw new Exception("u kan geen aanhang wagen kooplen voor enandere reden");
                }
                aanhangwagen = value;
            }
        }
        public int MaximalITtrekGewegt
        {
            get
            {
                return maxg;
            }
            private set
            {
                maxg = value;
            }
        }
        public void KoppelAanhangwagen(ITrekbaar aanhangwagen)
        {
            try
            {
                if (aanhangwagen.Gewicht > maxg)
                {
                    Console.WriteLine("het aanhangwagen is te swar om de auto te slepen");
                }
                else if (snelh != 0)
                {
                    Console.WriteLine("u kan geen aanhangwagen koplen als je niet stelstat bent");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("auto kan niet starten");
            }
            Console.WriteLine(snelh);
        }
        public void Versnellen(int versneling)
        {
            if (snelh < maxs || snelh == 0)
            {
                versneling++;
                snelh = versneling;
            }
        }
        public void Vertragen(int vertraging)
        {
            if (snelh == maxs)
            {
                vertraging--;
                snelh = vertraging;
            }
            Console.WriteLine(snelh);
        }
        public Auto(int maxs, int maxg, int snelh, string automerk, ITrekbaar aanhangwagen,string eignaar, double prijs)
            :base(eignaar,prijs)
        {
            this.Merk = merk;
            this.MaximumSnelheid = maxs;
            this.MaximalITtrekGewegt = maxg;
            this.Snelheid = snelh;
            this.aanHangwagen = aanhangwagen;
            this.Merk = automerk;
        }

        public override void BepaalPrijs(double nieuweprijs)
        {

        }

        public override void VerkoopAan(string nieuweeigenaar)
        {
            throw new NotImplementedException();
        }
    }
}
