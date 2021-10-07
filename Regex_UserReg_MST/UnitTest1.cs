using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class UnitTest1  // Regex UC 4
    {
        [TestMethod]
        public void UC4_Pre_defined_Mobile_Format()
        {
            string input = "91 9919819801";
            string pattern = "^[9][1][ ][1-9][0-9]{9}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        
    }
}
