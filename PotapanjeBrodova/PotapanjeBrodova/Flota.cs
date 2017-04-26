using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Flota: IGađani
    {
        public void dodajBrod(IEnumerable<Polje> polja)
        {
            brodovi.Add(new PotapanjeBrodova.Brod(polja));
        }

        public RezultatGađanja Gađaj(Polje polje)
        {
            throw new NotImplementedException();
        }

        public int brojBrodova
        {
            get { return brodovi.Count; }
        }

        private List<Brod> brodovi = new List<Brod>();
    }
}
