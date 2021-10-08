using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class Valid_Email_1_9  // Regex UC 9 [1-9]
    {

        [TestMethod]
        public void VE9()
        {
            string input = "abc+100@gmail.com";
            string pattern = "^([a-zA-z+0-9])+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        [TestMethod]
        public void VE8()
        {
            string input = "abc@gmail.com.com";
            string pattern = "^[a-zA-z]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        [TestMethod]
        public void VE7()
        {
            string input = "abc@1.com";
            string pattern = "^[a-zA-z]+[@]+[0-9]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        [TestMethod]
        public void VE6()
        {
            string input = "abc.100@abc.com.au";
            string pattern = "^[a-zA-z.0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,2}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        [TestMethod]
        public void VE5()
        {
            string input = "abc-100@abc.net";
            string pattern = "^[a-zA-z-0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

        [TestMethod]
        public void VE4()
        {
            string input = "abc111@abc.com";
            string pattern = "^[a-zA-z-0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }


        [TestMethod]
        public void VE3()
        {
            string input = "abc.100@yahoo.com";
            string pattern = "^[a-zA-z.0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }



        [TestMethod]
        public void VE2()
        {
            string input = "abc-100@yahoo.com";
            string pattern = "^[a-zA-z-0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }



        [TestMethod]
        public void VE1()
        {
            string input = "abc@yahoo.com";
            string pattern = "^[a-zA-z]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }




    }
}
