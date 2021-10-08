using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class valid_Email_1_13  // Regex UC 9
    {
        [TestMethod]
        public void IVE1()
        {
            string input = "abc@";
            string pattern = "^[a-zA-Z]+[@]$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }
        
        
    }
}
