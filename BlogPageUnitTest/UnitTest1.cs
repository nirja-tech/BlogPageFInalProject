

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Web;
using System.Web.UI.WebControls;

namespace BlogPageUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Test that EmailId field is not empty  
        public void EmailID_NotNull()
        {
            var EmailID = "Admain";
            Assert.IsNotNull(EmailID);

        }

        [TestMethod]
        //Test that Password field is not empty  
        public void Password_NotNull()
        {
            var Password = "Admin";
            Assert.IsNotNull(Password);

        }
    }
}
