using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 2 
    {
        [TestMethod]
        public void UC2_LastName()
        {
            string input = "Win Rar";
            string pattern = "^[A-Z][a-z]{2}[ ]([A-Z][a-z]{2})$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }
    }
}
