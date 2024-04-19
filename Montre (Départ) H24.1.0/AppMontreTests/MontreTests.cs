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
        /// <summary>
        /// Tester l'accesseur SET avec des valeurs valides
        /// </summary>
        [TestMethod]
        public void ProprietesSetCasValideRetourValideTest()
        {
            // Arranger (Arrange)
            Montre objMontre = new Montre();
            // Agir (Act)
            int heuresTest = 5;
            int minutesTest = 21;
            int secontestTest = 12;
            objMontre.Heures = heuresTest;
            objMontre.Minutes = minutesTest;
            objMontre.Secondes = secontestTest;
            // Auditer (Assert)
            Assert.AreEqual(heuresTest, objMontre.Heures);
            Assert.AreEqual(minutesTest, objMontre.Minutes);
            Assert.AreEqual(secontestTest, objMontre.Secondes);
        }
        /// <summary>
        /// Tester l'accesseur SET avec des valeurs sous les valeurs minimales
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ProprietesSetCasMinRetourExceptionTest()
        {
            // Arranger (Arrange)
            Montre objMontre = new Montre();
            // Agir (Act)
            objMontre.Heures = objMontre.Heures-1;
            objMontre.Minutes = objMontre.Minutes-1;
            objMontre.Secondes = objMontre.Secondes-1;
            // Auditer (Assert)
        }
        
        #endregion
    }
}