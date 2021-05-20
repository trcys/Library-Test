/*
 * Name: Tracy Salak
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-02-11
 * Updated: 
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Salak.Tracy.Business;

namespace LibraryTest
{
    [TestClass]
    public class FinancialTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativeRate_Exception()
        {
            // Arrange
            decimal rate = -1, presentValue = 2000;
            int numberOfPaymentPeriods = 2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_GreaterThanOneRate_Exception()
        {
            // Arrange
            decimal rate = 5, presentValue = 2000;
            int numberOfPaymentPeriods = 2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativePaymentPeriods_Exception()
        {
            // Arrange
            decimal rate = 0.10M, presentValue = 2000;
            int numberOfPaymentPeriods = -2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_ZeroPaymentPeriods_Exception()
        {
            // Arrange
            decimal rate = 0.10M, presentValue = 2000;
            int numberOfPaymentPeriods = 0;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativePresentValue_Exception()
        {
            // Arrange
            decimal rate = 0.10M, presentValue = -2000;
            int numberOfPaymentPeriods = 2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_ZeroPresentValue_Exception()
        {
            // Arrange
            decimal rate = 0.10M, presentValue = 0;
            int numberOfPaymentPeriods = 2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        public void GetPayment_ZeroRate_Initialize()
        {
            // Arrange
            decimal rate = 0, presentValue = 2000;
            int numberOfPaymentPeriods = 2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

            // Assert
            decimal expected = 1000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPayment_ReturnState()
        {
            // Arrange
            decimal rate = 0.10M, presentValue = 2000;
            int numberOfPaymentPeriods = 2;

            // Act
            decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

            // Assert
            decimal expected = 1152.38M;

            Assert.AreEqual(expected, actual);
        }

    }
}
