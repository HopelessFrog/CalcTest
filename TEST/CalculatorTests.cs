using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEST.CalcPageClasses;

namespace TEST
{
    [CodedUITest]
    public class CalculatorTests
    {
        private const string ADD_RESULT = "22";
        private const string SUBTRACT_RESULT = "0";
        private const string MULTIPLY_RESULT = "121";
        private const string DIVIDE_RESULT = "1";
        private const int FIRST_NUM = 11;
        private const int SECOND_NUM = 11;

        public CalculatorTests()
        {}

        [TestMethod]
        public void TestAdd()
        {
            var page = new CalcPage();
            page.Clear();
            Assert.AreEqual(ADD_RESULT, page.Add(FIRST_NUM, SECOND_NUM));
        }

        [TestMethod]
        public void TestSubtract()
        {
            var page = new CalcPage();
            page.Clear();
            Assert.AreEqual(SUBTRACT_RESULT, page.Subtract(FIRST_NUM, SECOND_NUM));
        }

        [TestMethod]
        public void TestMultiply()
        {
            var page = new CalcPage();
            page.Clear();
            Assert.AreEqual(MULTIPLY_RESULT, page.Multiply(FIRST_NUM, SECOND_NUM));
        }

        [TestMethod]
        public void TestDevide()
        {
            var page = new CalcPage();
            page.Clear();
            Assert.AreEqual(DIVIDE_RESULT, page.Divide(FIRST_NUM, SECOND_NUM));
        }
    }
}
