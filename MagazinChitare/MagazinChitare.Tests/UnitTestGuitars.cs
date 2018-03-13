using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MagazinChitare.Tests
{
    [TestClass]
    public class UnitTestGuitars
    {
        [TestMethod]
        public void TestGetGuitarMetodReturnsGuitar()
        {
            Guitar chitara = new Guitar("CHI0001", 1999.99, new GuitarSpec(Builder.MelodiaSA, "Model1", Type.PeAburi, Wood.Brad, Wood.Stejar));

            Inventory inv = new Inventory();
            Guitar chitaraTest = inv.GetGuitar("CHI0001");

            Assert.AreEqual(chitara.SerialNumber, chitaraTest.SerialNumber);
            Assert.AreEqual(chitara.Price, chitaraTest.Price);
            Assert.AreEqual(chitara.Spec.BackWood, chitaraTest.Spec.BackWood);
            Assert.AreEqual(chitara.Spec.TopWood, chitaraTest.Spec.TopWood);
            Assert.AreEqual(chitara.Spec.Builder, chitaraTest.Spec.Builder);
            Assert.AreEqual(chitara.Spec.Model, chitaraTest.Spec.Model);
            Assert.AreEqual(chitara.Spec.Type, chitaraTest.Spec.Type);
        }
        [TestMethod]
        public void TestGetGuitarMetodNotFound()
        {
            Inventory inv = new Inventory();
            Guitar chitaraTest = inv.GetGuitar("NuExista");

            Assert.IsNull(chitaraTest);
        }
        [TestMethod]
        public void TestSearchrMetodSpecNotFound()
        {
            GuitarSpec spec = new GuitarSpec(Builder.Romchitara, "Modelul asta nu exista", Type.Electrica, Wood.Stejar, Wood.Stejar);
            Inventory inv = new Inventory();
            List<Guitar> chitare = inv.Search(spec);

            Assert.AreEqual(chitare.Count, 0);
        }
        [TestMethod]
        public void TestSearchrMetodSpecFoundTwice()
        {
            GuitarSpec spec = new GuitarSpec(Builder.Chitaro, "", Type.Electrica, Wood.Stejar, Wood.Stejar);
            Inventory inv = new Inventory();
            List<Guitar> chitare = inv.Search(spec);

            Assert.AreEqual(chitare.Count, 2);
        }
    }
}
