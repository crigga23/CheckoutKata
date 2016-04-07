using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class CheckoutSystemTests
    {
        [TestMethod]
        public void Given_1_SKU_A_Item_Is_Scanned_When_GetTotalPrice_Is_Called_Then_50_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 50;

            // act
            checkoutSystem.Scan(SKU.A);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_2_SKU_A_Item_Are_Scanned_When_GetTotalPrice_Is_Called_Then_100_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 100;

            // act
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_3_SKU_A_Items_Are_Scanned_When_GetTotalPrice_Is_Called_Then_130_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 130;

            // act
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_4_SKU_A_Items_Are_Scanned_When_GetTotalPrice_Is_Called_Then_180_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 180;

            // act
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }
        [TestMethod]
        public void Given_6_SKU_A_Items_Are_Scanned_When_GetTotalPrice_Is_Called_Then_260_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 260;

            // act
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.A);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_1_SKU_B_Item_Is_Scanned_When_GetTotalPrice_Is_Called_Then_30_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 30;

            // act
            checkoutSystem.Scan(SKU.B);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_2_SKU_B_Items_Are_Scanned_When_GetTotalPrice_Is_Called_Then_45_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 45;

            // act
            checkoutSystem.Scan(SKU.B);
            checkoutSystem.Scan(SKU.B);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_1_SKU_A_Item_1_And_1_SKU_B_Item_Are_Scanned_When_GetTotalPrice_Is_Called_Then_80_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 80;

            // act
            checkoutSystem.Scan(SKU.A);
            checkoutSystem.Scan(SKU.B);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_1_SKU_C_Item_Is_Scanned_When_GetTotalPrice_Is_Called_Then_20_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 20;

            // act
            checkoutSystem.Scan(SKU.C);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }

        [TestMethod]
        public void Given_1_SKU_D_Item_Is_Scanned_When_GetTotalPrice_Is_Called_Then_15_Is_Returned()
        {
            // arrange 
            CheckoutSystem checkoutSystem = new CheckoutSystem();
            const int expectedTotalPrice = 15;

            // act
            checkoutSystem.Scan(SKU.D);
            int expectedResult = checkoutSystem.GetTotalPrice();

            // assert
            Assert.AreEqual(expectedTotalPrice, expectedResult);
        }


    }
}
