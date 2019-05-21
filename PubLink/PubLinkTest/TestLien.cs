using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubLinkLib;

namespace PubLinkTest
{
    [TestClass]
    public class TestLien
    {
        [TestMethod]
        public void TestCreerLien()
        {
            string Titre = "Wikipedia";
            string URL = "wikipedia.org";

            Lien lien = new Lien("Wikipedia", "wikipedia.org");

            Assert.AreEqual(Titre, lien._titre);
            Assert.AreEqual(URL, lien._url);
            Assert.AreEqual(Titre + " "+ URL, lien.ToString());
        }

        [TestMethod]
        public void TestCreerLienSansProtocole()
        {
            Lien lien = new Lien("Wikipedia", "wikipedia.org");
            Assert.AreEqual("http", lien._url.Substring(0,4));
        }
    }
}
