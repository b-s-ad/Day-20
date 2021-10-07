using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 1 
    {
        [TestMethod]
        public void UC1()
        {
            string input = "Abc";
            string pattern = @"^([A-Z][\w]{2})*$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }
    }
}
