using function1;

namespace CreditCardTests
{
    [TestClass]
    public class CreditCardTestsBaseCases
    {
        [TestMethod]
        public void TestValidCreditCardNumber()
        {
            Assert.IsTrue(CreditCardVerifier.IsCardNumberValid("378282246310005"));
        }

        [TestMethod]
        public void TestInvalidCreditCardNumber()
        {
            Assert.IsFalse(CreditCardVerifier.IsCardNumberValid("1111111111111111"));
        }
    }
}