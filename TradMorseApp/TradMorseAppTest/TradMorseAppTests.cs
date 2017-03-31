using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradMorseApp;


namespace testUnitMorseTraducteur
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void testTraduireLettre()
        {
            string lettre = Program.Translate("a");

            Assert.AreEqual(lettre, ".- ");
        }

        [TestMethod]
        public void testTraduireMot()
        {
            string mot = Program.Translate("bonjour");

            Assert.AreEqual(mot, "-... --- -. .--- --- ..- .-. ");
        }
    }
}