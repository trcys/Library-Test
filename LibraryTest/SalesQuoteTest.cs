/*
 * Name: Tracy Salak
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-02-11
 * Updated: 2021-02-12
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Salak.Tracy.Business;
using System.ComponentModel;

namespace LibraryTest
{
    [TestClass]
    public class SalesQuoteTest
    {
        [TestMethod]
        public void VehicleSalePricePropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.VehicleSalePrice;

            // Assert
            decimal expected = 50000M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VehicleSalePricePropertySet_NegativeVehicleSalePrice_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = -50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.VehicleSalePrice;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VehicleSalePricePropertySet_ZeroVehicleSalePrice_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 0, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.VehicleSalePrice;
        }

        [TestMethod]
        public void VehicleSalePricePropertySet_UpdatesState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            customerQuote.VehicleSalePrice = 30000M;

            // Assert
            decimal expected = 30000M;
            decimal actual = (decimal)target.GetProperty("VehicleSalePrice");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TradeInAmountPropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.TradeInAmount;

            // Assert
            decimal expected = 10000M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TradeInAmountPropertySet_NegativeTradeInAmount_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = -10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.TradeInAmount;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TradeInAmountPropertySet_ZeroTradeInAmount_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 0M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.TradeInAmount;
        }

        [TestMethod]
        public void TradeInAmountPropertySet_UpdatesState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            customerQuote.TradeInAmount = 20000M;

            // Assert
            decimal expected = 20000M;
            decimal actual = (decimal)target.GetProperty("TradeInAmount");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesChosenPropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            Accessories actual = customerQuote.AccessoriesChosen;

            // Assert
            Accessories expected = Accessories.All;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void AccessoriesChosenPropertySet_InvalidAccessories_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void AccessoriesChosenPropertySet_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            customerQuote.AccessoriesChosen = Accessories.LeatherInterior;

            // Assert
            Accessories expected = Accessories.LeatherInterior;
            Accessories actual = (Accessories)target.GetProperty("AccessoriesChosen");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExteriorFinishChosenPropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            ExteriorFinish actual = customerQuote.ExteriorFinishChosen;

            // Assert
            ExteriorFinish expected = ExteriorFinish.Custom;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void ExteriorFinishChosenPropertySet_InvalidExteriorFinish_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)99;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void ExteriorFinishChosenPropertySet_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            customerQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            // Assert
            ExteriorFinish expected = ExteriorFinish.Pearlized;
            ExteriorFinish actual = (ExteriorFinish)target.GetProperty("ExteriorFinishChosen");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_StereoSystem_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 505.05M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_LeatherInterior_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 1010.10M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_ComputerNav_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 1515.15M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_LeatherInteriorAndCompNav_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherAndNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 1515.15M + 1010.10M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_LeatherInteriorAndStereo_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.StereoAndLeather;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 505.05M + 1010.10M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_StereoAndCompNav_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.StereoAndNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 505.05M + 1515.15M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_None_ReturnZero()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 0.00M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesCostPropertyGet_All_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;

            // Assert
            decimal expected = 505.05M + 1010.10M + 1515.15M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void AccessoriesCostPropertyGet_InvalidAccessoriesCost_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.AccessoriesCost;
        }

        [TestMethod]
        public void FinishCostPropertyGet_Custom_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.FinishCost;

            // Assert
            decimal expected = 606.06M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FinishCostPropertyGet_Pearlized_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.FinishCost;

            // Assert
            decimal expected = 404.04M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FinishCostPropertyGet_Standard_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.FinishCost;

            // Assert
            decimal expected = 202.02M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FinishCostPropertyGet_None_ReturnTotal()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.FinishCost;

            // Assert
            decimal expected = 0.00M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void FinishCostPropertyGet_InvalidFinishCost_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)99;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            // Act
            decimal actual = customerQuote.FinishCost;
        }

        [TestMethod]
        public void SubTotalPropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetProperty("SubTotal");

            // Assert
            decimal expected = 53636.36M;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTotalPropertyGet_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            customerQuote.VehicleSalePrice = 40000;
            customerQuote.TradeInAmount = 20000;
            customerQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            customerQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            // Act
            decimal actual = (decimal)target.GetProperty("SubTotal");

            // Assert
            decimal expected = 42929.29M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTaxPropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetProperty("SalesTax");

            // Assert
            decimal expected = 26818.18M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTaxPropertyGet_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            customerQuote.VehicleSalePrice = 40000;
            customerQuote.TradeInAmount = 20000;
            customerQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            customerQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            // Act
            decimal actual = (decimal)target.GetProperty("SalesTax");

            // Assert
            decimal expected = 21464.64M;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TotalPropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetProperty("Total");

            // Assert
            decimal expected = 80454.54M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TotalPropertyGet_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            customerQuote.VehicleSalePrice = 40000;
            customerQuote.TradeInAmount = 20000;
            customerQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            customerQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            // Act
            decimal actual = (decimal)target.GetProperty("Total");

            // Assert
            decimal expected = 64393.93M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountDuePropertyGet_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetProperty("AmountDue");

            // Assert
            decimal expected = 70454.54M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountDuePropertyGet_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            customerQuote.VehicleSalePrice = 40000;
            customerQuote.TradeInAmount = 20000;
            customerQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            customerQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            // Act
            decimal actual = (decimal)target.GetProperty("AmountDue");

            // Assert
            decimal expected = 44393.93M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeVehicleSalePrice_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = -50000M, tradeInAmount = 10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor1_ValidVehicleSalePrice_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            target.SetField("vehicleSalePrice", 20000M);

            // Assert
            decimal expected = 20000M;
            decimal actual = (decimal)target.GetField("vehicleSalePrice");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeTradeInAmount_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = -10000M, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor1_ValidTradeInAmount_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            target.SetField("tradeInAmount", 20000M);

            // Assert
            decimal expected = 20000M;
            decimal actual = (decimal)target.GetField("tradeInAmount");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeSalesTaxRate_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = -10M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor1_ValidSalesTaxRate_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;
            
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            target.SetField("salesTaxRate", 0.7M);

            // Assert
            decimal expected = 0.7M;
            decimal actual = (decimal)target.GetField("salesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GreaterThanOneSalesTaxRate_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor1_ValidAccessoriesChosen_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            target.SetField("accessoriesChosen", Accessories.LeatherAndNavigation);

            // Assert
            Accessories expected = Accessories.LeatherAndNavigation;
            Accessories actual = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor1_InvalidAccessories_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor1_ValidExteriorFinishChosen_UpdateState()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            target.SetField("exteriorFinishChosen", ExteriorFinish.Pearlized);

            // Assert
            ExteriorFinish expected = ExteriorFinish.Pearlized;
            ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor1_InvalidExteriorFinish_Exception()
        {
            // Arrange
            decimal vehicleSalePrice = 50000, tradeInAmount = 10000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)20;

            // Act
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor1_VehicleSalePrice_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetField("vehicleSalePrice");

            // Assert
            decimal expected = 60000M;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_TradeInAmount_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetField("tradeInAmount");

            // Assert
            decimal expected = 20000M;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_SalesTaxRate_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            decimal actual = (decimal)target.GetField("salesTaxRate");

            // Assert
            decimal expected = 0.5M;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_AccessoriesChosen_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);
            // Act
            Accessories actual = (Accessories)target.GetField("accessoriesChosen");

            // Assert
            Accessories expected = Accessories.All;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_FinishChosen_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");

            // Assert
            ExteriorFinish expected = ExteriorFinish.Custom;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor2_NoAccessoriesChosen_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            PrivateObject target = new PrivateObject(customerQuote);

            // Act
            Accessories actual = (Accessories)target.GetField("accessoriesChosen");

            // Assert
            Accessories expected = Accessories.None;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor2_NoFinishChosen_ReturnState()
        {
            // Arrange
            decimal vehicleSalePrice = 60000, tradeInAmount = 20000, salesTaxRate = 0.5M;
            SalesQuote customerQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            PrivateObject target = new PrivateObject(customerQuote);
            
            // Act
            ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");

            // Assert
            ExteriorFinish expected = ExteriorFinish.None;
            Assert.AreEqual(expected, actual);
        }

    }
}
