using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cvjecara;
using System;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestTuning()
        {
            Cvjećara cvjećara = new Cvjećara();
            List<Cvijet> cvijece = new List<Cvijet>();
            DateTime t = System.DateTime.Now.AddDays(-2);
            for (int i = 0; i < 10000000; i++)
            {
                cvijece.Add(new Cvijet(Vrsta.Ruža, "Rosa" + i, "Crvena", t, i + 1));
            }
            cvjećara.Cvijeće = cvijece;
            //breakpoint - prije poziva metode
            int x = 0;
            cvjećara.RadSaCvijećemTuning2(
                new Cvijet(Vrsta.Ruža, "Rosa5000000", "Crvena", System.DateTime.Now.AddDays(-2), 100),
                0, 1);
            //breakpoint - poslije poziva metode
            int y = 0;
        }

        #region Testovi potpuni obuhvat odluka
        /* Dženeta Ahmić (18482)
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijecaIzuzetak1()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Ruža, "RosaNeka", "Crvena", DateTime.Now.AddDays(-2), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijecaIzuzetak2()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Neven, "Neki", "Žuta", DateTime.Now.AddDays(-2), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }
        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijecaUspjesno()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Neven, "Calendula", "Žuta", DateTime.Now.AddDays(-2), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.AreEqual(cvjećara.Cvijeće.Count, 1);
        }
       */
        #endregion

        #region Testovi potpunog obuhvata uslova
        /*
        //Radila Azra Ahmić(18390)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijećBezCvijeća()
        {
            Cvjećara cvjećara = new Cvjećara();
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijećaRužaBrisanje()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Ruža, "RosaCanina", "Crvena", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijećaRužaIspravna()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Ruža, "Rosa", "Crvena", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }
        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijećaLjiljan()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Ljiljan, "Lilium", "Crvena", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 1);
        }
        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijećaMargareta()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Margareta, "Leucanthemum", "Bijela", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 1);
        }
        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijećaNeven()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Neven, "Calendula", "Žuta", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 1);
        }
        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijećaOrhideja()
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Orhideja, "Orchidacea", "Bijela", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 1);
        }*/
        #endregion

        #region Testovi potpuni obuhvat tijela petlje

        //radila: Nedina Muratović
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijećBezCvjetova()//da se ne izvrsi tijelo petlje
        {
            Cvjećara cvjećara = new Cvjećara();
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }

        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijećaNeven()//da se tijelo petlje izvrši jednom
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Neven, "Lilium", "Žuta", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 1);
        }

        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijećaRužaNeven()//tijelo petlje se izvršava 2 puta
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Neven, "Calendula", "Žuta", DateTime.Now.AddDays(-1), 2);
            Cvijet cvijet2 = new Cvijet(Vrsta.Ruža, "Rossa", "Žuta", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.RadSaCvijećem(cvijet2, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 1);
        }

        [TestMethod]
        public void TestProvjeriLatinskaImenaCvijeća()//tijelo petlje se izvršava m (m<n) puta
        {
            Cvjećara cvjećara = new Cvjećara();
            Cvijet cvijet = new Cvijet(Vrsta.Neven, "Calendula", "Žuta", DateTime.Now.AddDays(-1), 2);
            Cvijet cvijet2 = new Cvijet(Vrsta.Ruža, "Rosa", "Žuta", DateTime.Now.AddDays(-1), 2);
            Cvijet cvijet3 = new Cvijet(Vrsta.Orhideja, "Orchidacea", "Žuta", DateTime.Now.AddDays(-1), 2);
            cvjećara.RadSaCvijećem(cvijet, 0, 1);
            cvjećara.RadSaCvijećem(cvijet2, 0, 1);
            cvjećara.RadSaCvijećem(cvijet3, 0, 1);
            cvjećara.ProvjeriLatinskaImenaCvijeća();
            Assert.IsTrue(cvjećara.Cvijeće.Count == 2);
        }




        #endregion
    }

}
   