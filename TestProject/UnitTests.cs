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
            Cvje�ara cvje�ara = new Cvje�ara();
            List<Cvijet> cvijece = new List<Cvijet>();
            for(int i = 0; i < 10000; i++)
            {
               cvijece.Add(new Cvijet(Vrsta.Ru�a, "Rosa" + i, "Crvena", System.DateTime.Now.AddDays(-2), i + 1));
            }
            cvje�ara.Cvije�e = cvijece;
            //breakpoint - prije poziva metode
            int x = 0;
            cvje�ara.RadSaCvije�em(
                new Cvijet(Vrsta.Ru�a, "Rosa5000", "Crvena", System.DateTime.Now.AddDays(-2), 100),
                0, 1);
            //breakpoint - poslije poziva metode
            int y = 0;
        }
    }
}
