using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTest
    {
        [TestMethod()]
        public void PrisTestFlatWhite()
        {
            //Arrange
            var flatwhite = new FlatWhite();

            //Act
            int pris = flatwhite.Pris();

            //assert
            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void StyrkeTestFlatWhite()
        {
            //Arrange
            var flatWhite = new FlatWhite();
            //Act
            string styrke = flatWhite.Styrke();
            //Assert
            Assert.AreEqual("Mild", styrke);
        }

        [TestMethod]
        public void MlMælkFlatWhiteTest()
        {
            //Arrange
            var flatwhite = new FlatWhite();
            //Act
            int mlmælk = flatwhite.MlMælk();
            //Assert
            Assert.AreEqual(160, mlmælk);
        }
    }
}
