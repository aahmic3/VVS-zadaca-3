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
    }
}
