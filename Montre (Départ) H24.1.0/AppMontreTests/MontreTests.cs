using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationMontre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationMontre.Tests
{
    [TestClass()]
    public class MontreTests
    {
        #region Tests constructeur initial
        /// <summary>
        /// Tester l'accesseur GET avec les propriétés initiales
        /// </summary>
        [TestMethod]
        public void ProprietesGetCasInitRetourInitTest()
        {
            // Arranger (Arrange)
            Montre objMontre = new Montre();
            int valeurTest = 0;
            // Agir (Act)
            // Auditer (Assert)
            Assert.AreEqual(valeurTest, objMontre.Heures);
            Assert.AreEqual(valeurTest, objMontre.Minutes);
            Assert.AreEqual(valeurTest, objMontre.Secondes);
        }

        #endregion
    }
}