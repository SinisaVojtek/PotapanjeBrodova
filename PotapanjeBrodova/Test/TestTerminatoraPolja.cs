using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestTerminatoraPolja
    {
        [TestClass]
        public class TestTerminatorPolja
        {
            private Mreža mreža;
            private TerminatorPolja terminator;

            [TestInitialize()]
            public void pripremiMrežuTerminatora()
            {
                mreža = new Mreža(10, 10);
                terminator = new TerminatorPolja(mreža);
            }


            [TestMethod]
            public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUSredinibMreže()
            {
                IEnumerable<Polje> polja = new Polje[] { new Polje(3, 3), new Polje(3, 3) };
                terminator.UkloniPolja(polja);
                Assert.AreEqual(88, mreža.DajSlobodnaPolja().Count());
                //dodaj provjeru da su izbačena polja od brodova (3,3) i (3,4)
            }

            [TestMethod]
            public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUzGornjiLijeviRubMreže()
            {

            }
            [TestMethod]
            public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUzGornjiDesniMreže()
            {

            }
            [TestMethod]
            public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUzDonjiRubMreže()
            {

            }
            [TestMethod]
            public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUzDonjiLijeviRubMreže()
            {

            }
            [TestMethod]
            public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUzDonjiDesniMreže()
            {

            }
        }
    }
}
