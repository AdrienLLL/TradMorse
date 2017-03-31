using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace testUnitMorseTraducteur
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void testTraduireLettre()
        {
            string lettre = TradMorseApp.Program.Translate("a");

            Assert.AreEqual(lettre, ".-");
        }

        [TestMethod]
        public void testTraduireMot()
        {
            string mot = TradMorseApp.Program.Translate("bonjour");

            Assert.AreEqual(mot, "-... --- -. .--- --- ..- .-.");
        }






    }
}