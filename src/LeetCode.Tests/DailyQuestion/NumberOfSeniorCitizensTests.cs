using LeetCode.DailyQuestion;

namespace LeetCode.Teste
{
    [TestClass]
    public class NumberOfSeniorCitizensTests
    {

        private NumberOfSeniorCitizens _numberOfSeniorCitizensTest;
     
        [TestInitialize]
        public void Setup()
        {
            _numberOfSeniorCitizensTest = new();
        }


        [TestMethod]
        public void TestMethod1()
        {
            string[] details = ["7868190130M7522", "5303914400F9211", "9273338290F4010"];
            int result = _numberOfSeniorCitizensTest.CountSeniors(details);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] details = ["1313579440F2036", "2921522980M5644"];
            int result = _numberOfSeniorCitizensTest.CountSeniors(details);
            Assert.AreEqual(0, result);
        }
    }
}