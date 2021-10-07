using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 1 
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Abc2";
            string pattern = "^([A-Z][a-zA-Z0-9]*)$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }
    }
}
