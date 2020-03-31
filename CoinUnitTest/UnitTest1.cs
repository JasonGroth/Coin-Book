using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin_Book;

namespace CoinUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoesNotPennyContainSilver()
        {
            // Arrange
            string type = "Penny";
            string name = "";
            string mint = "P";
            int year = 1917;
            bool expected = false;
            CommonCoin theCoin = new CommonCoin(type, mint, year, name);

            // ACT
            ICoinLogic coinLogic = new BusinessLogicCoins();

            // ASSERT
            bool actual = coinLogic.DoesCoinHaveSilver(theCoin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesNotDimeContainSilver()
        {
            // Arrange
            string type = "Dime";
            string name = "";
            string mint = "P";
            int year = 2005;
            bool expected = false;
            CommonCoin theCoin = new CommonCoin(type, mint, year, name);

            // ACT
            ICoinLogic coinLogic = new BusinessLogicCoins();

            // ASSERT
            bool actual = coinLogic.DoesCoinHaveSilver(theCoin); ;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesDimeContainSilver()
        {
            // Arrange
            string type = "Dime";
            string name = "";
            string mint = "P";
            int year = 1915;
            bool expected = true;
            CommonCoin theCoin = new CommonCoin(type, mint, year, name);

            // ACT
            ICoinLogic coinLogic = new BusinessLogicCoins();

            // ASSERT
            bool actual = coinLogic.DoesCoinHaveSilver(theCoin); ;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesQuarterContainSilver()
        {
            // Arrange
            string type = "Dime";
            string name = "";
            string mint = "P";
            int year = 1995;
            bool expected = false;
            CommonCoin theCoin = new CommonCoin(type, mint, year, name);

            // ACT
            ICoinLogic coinLogic = new BusinessLogicCoins();

            // ASSERT
            bool actual = coinLogic.DoesCoinHaveSilver(theCoin); ;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesQuarterContainSilver2()
        {
            // Arrange
            string type = "Quarter";
            string name = "";
            string mint = "D";
            int year = 1965;
            bool expected = false;
            CommonCoin theCoin = new CommonCoin(type, mint, year, name);

            // ACT
            ICoinLogic coinLogic = new BusinessLogicCoins();

            // ASSERT
            bool actual = coinLogic.DoesCoinHaveSilver(theCoin); ;
            Assert.AreEqual(expected, actual);
        }
    }
}
