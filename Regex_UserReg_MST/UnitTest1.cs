using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 3 
    {
        [TestMethod]
        public void UC3_Email_3_mandatory_parts1()
        {
            string input = "abc.xyz@bl.co.in";
            string pattern = "^[a-z][-a-z0-9._]+@([-a-z0-9{2,2}]+[.])+[a-z]{2,2}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        [TestMethod]
        public void UC3_Email_3_mandatory_parts2()
        {
            string input = "abc.xyz@bl.co";
            string pattern = "^[a-z][-a-z0-9._]+@([-a-z0-9{2,2}]+[.])+[a-z]{2,2}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }
    }
}
