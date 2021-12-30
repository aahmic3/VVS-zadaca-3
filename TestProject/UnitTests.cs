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
        
        // 1-2-3-8-9-10
        //Dženeta Ahmić (18482)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProvjeriLatinskaImenaCvijećaBezCvijeca()
        {
            Cvjećara cvjećara = new Cvjećara();
            cvjećara.ProvjeriLatinskaImenaCvijeća();
        }
       
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
    }

}
   