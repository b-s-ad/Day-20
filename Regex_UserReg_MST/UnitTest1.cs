using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 6
    {
        [TestMethod]
        public void UC6Atleast_1_UpperCase()
        {
            string input = "abcdefgH";
            string pattern = "^[a-z]{7}[A-Z]$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        
    }
}
