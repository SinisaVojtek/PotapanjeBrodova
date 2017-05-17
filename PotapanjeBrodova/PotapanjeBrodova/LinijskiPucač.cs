using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {

        public LinijskiPucač(Mreža mreža, IEnumerable<Polje> pogođeno, int duljinaBroda)
        {
            this.mreža = mreža;
            this.pogođenaPolja = pogođeno;
            this.duljinaBroda = duljinaBroda; ;
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Polje Gađaj()
        {
            var kandidati = DajKandidate();
            return kandidati[izbornik.Next(kandidati.Count())];
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        private List<Polje> DajKandidate()
        {
            if (pogođenaPolja.First().Redak == pogođenaPolja.Last().Redak)
                return DajHorizontalnaPolja();

            return DajVertikalnaPolja();
        }

        List<Polje> DajHorizontalnaPolja()
        {
            List<Polje> polja = new List<Polje>();
            Polje prvo = pogođenaPolja.First();
            Polje zadnje = pogođenaPolja.Last();
            var LijevaPolja = mreža.DajNizSlobodnihPolja(prvo,Smjer.Lijevo);
            if (LijevaPolja.Count() > 0)
                polja.Add(LijevaPolja.First());
            var DesnaPolja = mreža.DajNizSlobodnihPolja(prvo, Smjer.Desno);
            if (DesnaPolja.Count() > 0)
                polja.Add(DesnaPolja.First());
            return polja;
        }

        List<Polje> DajVertikalnaPolja()
        {
            List<Polje> polja = new List<Polje>();
            return polja;
        }


        Mreža mreža;
        IEnumerable<Polje> pogođenaPolja;
        int duljinaBroda;
        private Random izbornik=new Random();
    }
}
