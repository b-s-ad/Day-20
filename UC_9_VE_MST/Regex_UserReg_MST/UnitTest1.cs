using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class Valid_Email_1_9  // Regex UC 9
    {
        [TestMethod]
        public void VE1()
        {
            string input = "abc@yahoo.com";
            string pattern = "^[a-zA-z]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }


    }
}
