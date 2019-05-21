using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubLinkLib;

namespace PubLinkTest
{
    [TestClass]
    public class TestCollection
    {
        [TestMethod]
        public void TestAjouterGet()
        {
            Collection collection = new Collection();
            Lien lien = new Lien("Wikipedia", "wikipedia.org");
            collection.Ajouter(lien);
            Assert.AreEqual(collection.Get(0), lien);
        }

        [TestMethod]
        public void TestCompte()
        {
            Collection collection = new Collection();
            Assert.AreEqual(collection.Compte, 0);
        }

        [TestMethod]
        public void TestEnlever()
        {
            Collection collection = new Collection();
            Lien lien = new Lien("Wikipedia", "wikipedia.org");
            collection.Ajouter(lien);
            lien = new Lien("Youtube", "youtube.fr");
            collection.Ajouter(lien);
            Assert.AreEqual(collection.Compte, 2);
            Assert.AreEqual(collection.Get(1), lien);
            collection.Enlever(0);
            Assert.AreEqual(collection.Compte, 1);
            Assert.AreEqual(collection.Get(0), lien);

        }
    }

}
