using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 7
    {
        [TestMethod]
        public void UC7Atleast_1_NUMERIC()
        {
            string input = "ABCD1abcd";
            string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        
    }
}
