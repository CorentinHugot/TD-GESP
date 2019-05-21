using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubLinkLib;

namespace PubLinkTest
{
    [TestClass]
    public class TestMotDePasse
    {
        [TestMethod]
        public void TestVerifier()
        {
            MotDePasse mdp = new MotDePasse("");
            string mot = "wiki5";
            string mot1 = " ";
            string mot2 = "wiki9edia";
            string mot3 = "wikipedia";
            string mot4 = "wikiped1";

            Assert.AreEqual(mdp.Verifier(mot),false);
            Assert.AreEqual(mdp.Verifier(mot1),false);
            Assert.AreEqual(mdp.Verifier(mot2),true);
            Assert.AreEqual(mdp.Verifier(mot3),false); 
            Assert.AreEqual(mdp.Verifier(mot4),true);
        }

        [TestMethod]
        public void TestCompleter()
        {
            MotDePasse mdp = new MotDePasse("wiki5");
            MotDePasse mdp1 = new MotDePasse(" ");
            MotDePasse mdp2 = new MotDePasse("wiki9edia");
            MotDePasse mdp3 = new MotDePasse("wikipedia");
            MotDePasse mdp4 = new MotDePasse("wikiped1");

            Assert.AreEqual(mdp.Verifier(mdp._mot), true);
            Assert.AreEqual(mdp1.Verifier(mdp1._mot), true);
            Assert.AreEqual(mdp2.Verifier(mdp2._mot), true);
            Assert.AreEqual(mdp3.Verifier(mdp3._mot), true);
            Assert.AreEqual(mdp4.Verifier(mdp4._mot), true);
        }
    }
}
