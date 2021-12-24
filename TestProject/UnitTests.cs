using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cvjecara;
using System;
namespace TestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestTuning()
        {
            Cvjeæara cvjeæara = new Cvjeæara();
            for(int i = 0; i < 10000; i++)
            {
                cvjeæara.RadSaCvijeæem(
                    new Cvijet(Vrsta.Ruža, "Rosa"+ i, "Crvena",System.DateTime.Now.AddDays(-2),i+1),
                    0, i+1);
            }
            //breakpoint - prije poziva metode
            int x = 0;
            cvjeæara.RadSaCvijeæem(
                new Cvijet(Vrsta.Ruža, "Rosa5000", "Crvena", System.DateTime.Now.AddDays(-2), 100),
                0, 1);
            //breakpoint - poslije poziva metode
            int y = 0;
        }
    }
}
