using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassToMySQL.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassToMySQL.Class.Tests
{
    [TestClass()]
    public class ReadClassTests
    {
        [TestMethod()]
        public void OpenClassTest()
        {

            ReadClass readClass = new ReadClass(@"c:\base\Gtoken.cs");
            Assert.Fail();
        }
    }
}