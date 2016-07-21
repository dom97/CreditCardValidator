using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardValidator;

namespace LuhnAlgorithmTests
{
    [TestClass]
    public class LuhnAlgorithmTests
    {
        [TestMethod]
        public void CorrectlyChecksValidCreditCard()
        {
            Assert.IsTrue(LuhnAlgorithm.IsValidCard(378282246310005));
        }

        [TestMethod]
        public void CorrectlyChecksInValidCreditCard()
        {
            Assert.IsFalse(LuhnAlgorithm.IsValidCard(378282246210005));
        }

    }
}
