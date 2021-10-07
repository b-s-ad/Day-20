using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 5
    {
        [TestMethod]
        public void UC5_Min_8_Char()
        {
            string input = "AbCdEfGh";
            string pattern = @"^(?=.*[A-Za-z])(?=.*\w)[A-Za-z\w]{8}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        
    }
}
