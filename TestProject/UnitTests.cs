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
            for(int i = 0; i < 10000; i++)
            {
               cvijece.Add(new Cvijet(Vrsta.Ruža, "Rosa" + i, "Crvena", System.DateTime.Now.AddDays(-2), i + 1));
            }
            cvjećara.Cvijeće = cvijece;
            //breakpoint - prije poziva metode
            int x = 0;
            cvjećara.RadSaCvijećem(
                new Cvijet(Vrsta.Ruža, "Rosa5000", "Crvena", System.DateTime.Now.AddDays(-2), 100),
                0, 1);
            //breakpoint - poslije poziva metode
            int y = 0;

            Assert.IsTrue(true);
        }
    }
}
