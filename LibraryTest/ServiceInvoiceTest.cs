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
    public class ServiceInvoiceTest
    {
        [TestMethod]
        public void LabourCostGet_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            PrivateObject target = new PrivateObject(serviceInvoice);
            target.SetProperty("LabourCost", 25M);

            // Assert
            decimal expected = 25M;
            decimal actual = (decimal)target.GetProperty("LabourCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartsCostGet_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            PrivateObject target = new PrivateObject(serviceInvoice);
            target.SetProperty("PartsCost", 30M);

            // Assert
            decimal expected = 30M;
            decimal actual = (decimal)target.GetProperty("PartsCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaterialCostGet_ReturnState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            PrivateObject target = new PrivateObject(serviceInvoice);
            target.SetProperty("MaterialCost", 40M);

            // Assert
            decimal expected = 40M;
            decimal actual = (decimal)target.GetProperty("MaterialCost");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PSTChargedGet_ReturnTotal()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            target.SetProperty("MaterialCost", 40M);
            target.SetProperty("PartsCost", 30M);
            target.SetProperty("LabourCost", 25M);

            // Act
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxCharged");

            // Assert
            decimal expected = 35.0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GSTChargedGet_ZeroPSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            target.SetProperty("MaterialCost", 40M);
            target.SetProperty("PartsCost", 30M);
            target.SetProperty("LabourCost", 25M);

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
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            target.SetProperty("MaterialCost", 40M);
            target.SetProperty("PartsCost", 30M);
            target.SetProperty("LabourCost", 25M);

            // Act
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxCharged");

            // Assert
            decimal expected = 76.0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GSTChargedGet_ZeroGSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            target.SetProperty("MaterialCost", 40M);
            target.SetProperty("PartsCost", 30M);
            target.SetProperty("LabourCost", 25M);

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
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            target.SetProperty("MaterialCost", 40M);
            target.SetProperty("PartsCost", 30M);
            target.SetProperty("LabourCost", 25M);

            // Act
            decimal actual = (decimal)target.GetProperty("SubTotal");

            // Assert
            decimal expected = 95M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoiceConstructor_NegativePSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = -0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoiceConstructor_GreaterThanOnePSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 1.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");
        }

        [TestMethod]
        public void ServiceInvoiceConstructor_ZeroPSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxRate");

            // Assert
            decimal expected = 0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ServiceInvoiceConstructor_OnePSTRate_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            target.SetProperty("ProvincialSalesTaxRate", 1M);

            // Assert
            decimal expected = 1M;
            decimal actual = (decimal)target.GetProperty("ProvincialSalesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoiceConstructor_NegativeGSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = -0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal actual = (decimal)target.GetField("goodsAndServicesTaxRate");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoiceConstructor_GreaterThanOneGSTRate_Exception()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 1.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal actual = (decimal)target.GetField("goodsAndServicesTaxRate");
        }

        [TestMethod]
        public void ServiceInvoiceConstructor_ZeroGSTRate_ReturnZero()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0M, goodsAndServicesTaxRate = 0M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxRate");

            // Assert
            decimal expected = 0M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ServiceInvoiceConstructor_OneGSTRate_UpdateState()
        {
            // Arrange
            decimal provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            target.SetProperty("GoodsAndServicesTaxRate", 1M);

            // Assert
            decimal expected = 1M;
            decimal actual = (decimal)target.GetProperty("GoodsAndServicesTaxRate");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void AddCost_InvalidCostType_Exception()
        {
            // Arrange
            CostType type = (CostType)99;
            decimal amount = 40M, provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            serviceInvoice.AddCost(type, amount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCost_NegativeAmount_Exception()
        {
            // Arrange
            CostType type = CostType.Labour;
            decimal amount = -40M, provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            serviceInvoice.AddCost(type, amount);
        }

        [TestMethod]
        public void AddCost_SwitchLabourCost_ReturnTotal()
        {
            // Arrange
            CostType type = CostType.Labour;
            decimal amount = 40M, provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            decimal startAmount = serviceInvoice.LabourCost;
            serviceInvoice.AddCost(type, amount);

            // Assert
            decimal expected = startAmount + amount;
            Assert.AreEqual(expected, serviceInvoice.LabourCost);
        }

        [TestMethod]
        public void AddCost_SwitchPartCost_ReturnTotal()
        {
            // Arrange
            CostType type = CostType.Part;
            decimal amount = 40M, provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            // Act
            decimal startAmount = serviceInvoice.PartsCost;
            serviceInvoice.AddCost(type, amount);

            // Assert
            decimal expected = startAmount + amount;
            Assert.AreEqual(expected, serviceInvoice.PartsCost);
        }

        [TestMethod]
        public void AddCost_SwitchMaterialCost_ReturnTotal()
        {
            // Arrange
            CostType type = CostType.Material;
            decimal amount = 40M, provincialSalesTaxRate = 0.5M, goodsAndServicesTaxRate = 0.8M;

            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            PrivateObject target = new PrivateObject(serviceInvoice);

            // Act
            decimal startAmount = serviceInvoice.MaterialCost;
            serviceInvoice.AddCost(type, amount);

            // Assert
            decimal expected = startAmount + amount;
            Assert.AreEqual(expected, serviceInvoice.MaterialCost);
        }

    }
}
