using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassToMySQL.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ClassToMySQL.Class.Tests
{
    [TestClass()]
    public class ReadClassTests
    {
        [TestMethod()]
        public void OpenClassTest()
        {

            ReadClass readClass = new ReadClass(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs");
            Assert.IsTrue(readClass != null);
        }

        [TestMethod()]
        public void ToStringTest()
        {

            ReadClass readClass = new ReadClass(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs");
            Debug.Print(readClass.ToString());
            string result = "{\"MockFactory\":{\"Id\":{\"Type\":\"long\",\"NotNull\":\"False\",\"Default\":\"\"},\"mInt\":{\"Type\":\"int\",\"NotNull\":\"False\",\"Default\":\"\"},\"mVarChar\":{\"Type\":\"string\",\"NotNull\":\"False\",\"Default\":\"\"},\"mDouble\":{\"Type\":\"double\",\"NotNull\":\"False\",\"Default\":\"\"},\"mBlob\":{\"Type\":\"string\",\"NotNull\":\"False\",\"Default\":\"\"},\"mDate\":{\"Type\":\"DateTime\",\"NotNull\":\"False\",\"Default\":\"\"},\"mDateTime\":{\"Type\":\"DateTime\",\"NotNull\":\"False\",\"Default\":\"\"},\"mTimeStamp\":{\"Type\":\"DateTime\",\"NotNull\":\"False\",\"Default\":\"\"},\"mEnum\":{\"Type\":\"MyEnum\",\"NotNull\":\"False\",\"Default\":\"\"}}}";
            
            Assert.IsTrue (result.Equals( readClass.ToString(),StringComparison.InvariantCultureIgnoreCase));
        }
    }
}