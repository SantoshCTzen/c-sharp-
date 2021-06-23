using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;
using UnitTest.Validator;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace MSTest
{
    [TestFixture]
    
    public class UnitTest1
    {
         [Test]
        public void usenameEmpty()
        {
            
            string email = "santosh";
            string expected = "santosh";
            Assert.AreEqual(email, expected);
        }


       [Test]
       public void Usernamecheck()
        {
            List<string> list1 = new List<string>();
            list1.Add("santosh");
            list1.Add("Teknu");
             List<string> list2 = new List<string>();
            list2.Add("mangesh");
            list2.Add("kumar");

            CollectionAssert.AllItemsAreInstancesOfType(list1, typeof(string), "different users can login");
        }

        [Test]
        [TestCase("Santosh@gmail.com", false)]
        [TestCase("paresh@gmail.com", true)]
        [TestCase("Vivek@gmail.com", false)]
        public  void isInvalidEmail(string email, bool expected)
        {
            InputValidator user = new InputValidator();
            bool result = user.checkemail(email);
         
            Assert.AreEqual(expected, result);
        }

    }
}
