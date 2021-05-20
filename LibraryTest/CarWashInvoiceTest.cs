/*
 * Name: Tracy Salak
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-02-12
 * Updated: 
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Salak.Tracy.Business;
using System.ComponentModel;

namespace LibraryTest
{
    [TestClass]
    public class CarWashInvoiceTest
    {
        [TestMethod]
        public void PackageCostGet_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            // Act
            decimal actual = customerCarWashInvoice.PackageCost;

            // Assert
            decimal expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PackageCostSet_NegativePackageCost_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = -20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            // Act
            decimal actual = customerCarWashInvoice.PackageCost;
        }

        [TestMethod]
        public void PackageCostSet_PositivePackageCost_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            customerCarWashInvoice.PackageCost = 50M;

            // Assert
            decimal expected = 50;
            decimal actual = (decimal)target.GetProperty("PackageCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PackageCostSet_ZeroPackageCost_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            customerCarWashInvoice.PackageCost = 0M;

            // Assert
            decimal expected = 0;
            decimal actual = (decimal)target.GetProperty("PackageCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FragranceCostGet_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            // Act
            decimal actual = customerCarWashInvoice.PackageCost;

            // Assert
            decimal expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FragranceCostSet_NegativePackageCost_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = -40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            // Act
            decimal actual = customerCarWashInvoice.PackageCost;
        }

        [TestMethod]
        public void FragranceCostSet_PositiveFragranceCost_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            customerCarWashInvoice.FragranceCost = 50M;

            // Assert
            decimal expected = 50;
            decimal actual = (decimal)target.GetProperty("FragranceCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FragranceCostSet_ZeroFragranceCost_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            customerCarWashInvoice.FragranceCost = 0M;

            // Assert
            decimal expected = 0;
            decimal actual = (decimal)target.GetProperty("FragranceCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PSTChargedGet_ReturnTotal()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxCharged");

            // Assert
            decimal expected = 20.0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PSTChargedGet_ZeroPSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxCharged");

            // Assert
            decimal expected = 0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GSTChargedGet_ReturnTotal()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxCharged");

            // Assert
            decimal expected = 48.0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GSTChargedGet_ZeroGSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxCharged");

            // Assert
            decimal expected = 0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTotalGet_ReturnTotal()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 40M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("SubTotal");

            // Assert
            decimal expected = 60.0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativePSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = -0.5M, goodsAndServicesTaxRate = 0.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GreaterThanOnePSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 1.5M, goodsAndServicesTaxRate = 0.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");
        }

        [TestMethod]
        public void Constructor1_ZeroPSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxRate");

            // Assert
            decimal expected = 0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_OnePSTRate_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            target.SetProperty("ProvincialSalesTaxRate", 1M);

            // Assert
            decimal expected = 1M;
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeGSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = -0.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("goodsAndServicesTaxRate");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GreaterThanOneGSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 1.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("goodsAndServicesTaxRate");
        }

        [TestMethod]
        public void Constructor1_ZeroGSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxRate");

            // Assert
            decimal expected = 0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_OneGSTRate_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            target.SetProperty("GoodsAndServicesTaxRate", 1M);

            // Assert
            decimal expected = 1M;
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativePackageCost_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = -20M, fragranceCost = 30M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("packageCost");        
        }

        [TestMethod]
        public void Constructor2_PositivePackageCost_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 30M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("packageCost");

            // Assert
            decimal expected = 20M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor2_PositivePackageCost_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 30M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            target.SetField("packageCost", 10M);

            // Assert
            decimal expected = 10M;
            decimal actual = (decimal)target.GetField("packageCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeFragranceCost_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = -30M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("fragranceCost");
        }

        [TestMethod]
        public void Constructor2_PositiveFragranceCost_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 30M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            decimal actual = (decimal)target.GetField("fragranceCost");

            // Assert
            decimal expected = 30M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor2_PositiveFragranceCost_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M, packageCost = 20M, fragranceCost = 30M;

            CarWashInvoice customerCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);

            PrivateObject target = new PrivateObject(customerCarWashInvoice);

            // Act
            target.SetField("fragranceCost", 10M);

            // Assert
            decimal expected = 10M;
            decimal actual = (decimal)target.GetField("fragranceCost");
            Assert.AreEqual(expected, actual);
        }
    }
}
