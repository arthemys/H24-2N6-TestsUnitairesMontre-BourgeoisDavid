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
        /// <summary>
        /// Tester l'accesseur SET avec des valeurs au dessus des valeurs maximales
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ProprietesSetCasMaxRetourExceptionTest()
        {
            // Arranger (Arrange)
            Montre objMontre = new Montre();
            // Agir (Act)
            objMontre.Heures = 24;
            objMontre.Minutes = 60;
            objMontre.Secondes = 60;
            // Auditer (Assert)
        }
        #endregion
        #region Tests constructeur avec paramètres
        /// <summary>
        /// Tester le constructeur avec des paramètres valides
        /// </summary>
        [TestMethod]
        public void ConstrAvecParamCasValideRetourValideTest()
        {
            // Arranger (Arrange)
            int heures = 2;
            int minutes = 23;
            int secondes = 54;
            Montre objMontre = new Montre(heures,minutes,secondes);
            // Agir (Act)

            // Auditer (Assert)
            Assert.AreEqual(heures, objMontre.Heures);
            Assert.AreEqual(minutes, objMontre.Minutes);
            Assert.AreEqual(secondes, objMontre.Secondes);
        }
        /// <summary>
        /// Tester le constructeur avec des paramètres sous les valeurs minimales
        /// </summary>
        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void ConstrAvecParamCasMinMoinsUnRetourExceptionTest()
        {
            // Arranger (Arrange)
            Montre objMontre = new Montre(-1, -2, -3);
            // Agir (Act)

            // Auditer (Assert)

        }
        /// <summary>
        /// Tester le constructeur avec des paramètres au dessus des valeurs maximales
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstrAvecParamCasMaxPlusUnRetourExceptionTest()
        {
            // Arranger (Arrange)
            Montre objMontre = new Montre(24, 60, 61);
            // Agir (Act)

            // Auditer (Assert)

        }
        #endregion
        #region Tests méthode AvancerUneSeconde
        /// <summary>
        /// Tester la méthode AvancerUneSeconde avec les paramètres initiaux
        /// </summary>
        [TestMethod]
        public void AvancerUneSecondeCasValideRetourValidePlusUnTest()
        {
            // Arranger (Arrange)

            Montre objMontre = new Montre();
            // Agir (Act)
            objMontre.AvancerUneSeconde();
            // Auditer (Assert)
            Assert.AreEqual(0, objMontre.Heures);
            Assert.AreEqual(0, objMontre.Minutes);
            Assert.AreEqual(1, objMontre.Secondes);
        }        
        /// <summary>
        /// Tester la méthode AvancerUneSeconde avec la limite maximale des secondes
        /// </summary>
        [TestMethod]
        public void AvancerUneSecondeCasMaxSecondesRetourValidePlusUnTest()
        {
            // Arranger (Arrange)
            int heures = 2;
            int minutes = 39;
            int secondes = 59;
            Montre objMontre = new Montre(heures,minutes,secondes);
            // Agir (Act)
            objMontre.AvancerUneSeconde();
            // Auditer (Assert)
            Assert.AreEqual(heures, objMontre.Heures);
            Assert.AreEqual(minutes+1, objMontre.Minutes);
            Assert.AreEqual(0, objMontre.Secondes);
        }
        /// <summary>
        /// Tester la méthode AvancerUneSeconde avec la limite maximale des minutes et secondes
        /// </summary>
        [TestMethod]
        public void AvancerUneSecondeCasMaxMinutesRetourValidePlusUnTest()
        {
            // Arranger (Arrange)
            int heures = 2;
            int minutes = 59;
            int secondes = 59;
            Montre objMontre = new Montre(heures, minutes, secondes);
            // Agir (Act)
            objMontre.AvancerUneSeconde();
            // Auditer (Assert)
            Assert.AreEqual(heures+1, objMontre.Heures);
            Assert.AreEqual(0, objMontre.Minutes);
            Assert.AreEqual(0, objMontre.Secondes);
        }

        #endregion
    }
}