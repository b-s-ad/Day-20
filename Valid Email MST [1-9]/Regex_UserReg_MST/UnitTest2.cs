using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Regex_UserReg_MST
{
    [TestClass]
    public class Invalid_Email_1_13  // Regex UC 9
    {
        [TestMethod]
        public void IVE1()
        {
            string input = "abc@";
            string pattern = "^[a-zA-Z]+[@]$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }
        
        [TestMethod]
        public void IVE2()
        {
            string input = "abc@abc.com.my";
            string pattern = @"([\w]+)@([\w]+)\.([\w][\w][\w])\.([\w][\w])$";


            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
        }

            [TestMethod]
            public void IVE3()
            {
                string input = "abc123@gmail.ac";
                string pattern = @"([\w]+)@([\w]+)\.([\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE4()
            {
                string input = "abc123@mail.com";
                string pattern = @"([\w]+)@([\w]+)\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE5()
            {
                string input = "abc123@xyz.com.com";
                string pattern = @"([\w]+)@([\w]+)\.([\w][\w][\w])\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

           [TestMethod]
            public void IVE6()
            {
                string input = "abc@abc.com";
                string pattern = @"(\b^[\w]+@[\w]+)\.([\w][\w][\w]\b)$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

             [TestMethod]
            public void IVE7()
            {
                string input = "a-b_c_1-2-A@gmail.com";
                string pattern = @"(^[\w-_]+@[\w]+)\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE8()
            {
                string input = "abcA1b2C@mail123ABC.com";
                string pattern = @"(^[\w]+@[a-zA-Z0-9]+)\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE9()
            {
                string input = "abc.2002@gmail.com";
                string pattern = @"(^[\w]+.{1}[\d]+@[\w]+)\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE10()
            {
                string input = "abc@gmail.com";
                string pattern = @"(^[\w]+@[\w]+)\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE11()
            {
                string input = "abcABC@gmail.com";
                string pattern = @"(^[\w]+@[\w]+)\.([\w][\w][\w])$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

            [TestMethod]
            public void IVE12()
            {
                string input = "abc@gmail.com.au";
                string pattern = @"(^[\w]+@[\w]+)\.([\w][\w][\w])\.[a-zA-Za-zA-Z]{2,2}$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }

          [TestMethod]
            public void IVE13()
            {
                string input = "abc@gmail.com.aa";
                string pattern = @"(^[\w]+@[\w]+)\.([\w][\w][\w])\.[a-zA-Za-zA-Z]{2,2}$";


                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(input, pattern));
            }
    
    }
}
