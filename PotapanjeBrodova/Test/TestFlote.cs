using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace Test
{
    [TestClass]
    public class TestFlote
    {
        [TestMethod]
        public void Flota_DodajBrodPovećavaFlotuZaJedanBrod()
        {
            Flota flota = new Flota();
            Assert.AreEqual(0, flota.brojBrodova);
            flota.dodajBrod(new Polje[] { new Polje(1, 1), new Polje(1, 2) });
            Assert.AreEqual(1, flota.brojBrodova);
        }
    }
}
