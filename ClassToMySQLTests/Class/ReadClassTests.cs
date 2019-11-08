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
            string result = "{\"MockFactory\":{\"Id\":{\"Type\":\"BIGINT(20)\",\"NotNull\":\"True\",\"Default\":\"0\"},\"mInt\":{\"Type\":\"INT(11)\",\"NotNull\":\"True\",\"Default\":\"0\"},\"mVarChar\":{\"Type\":\"VARCHAR(255)\",\"NotNull\":\"True\",\"Default\":\"\"},\"mDouble\":{\"Type\":\"DOUBLE(15,6)\",\"NotNull\":\"True\",\"Default\":\"0.000000\"},\"mLongId\":{\"Type\":\"BIGINT(20)\",\"NotNull\":\"True\",\"Default\":\"0\"},\"mBlob\":{\"Type\":\"VARCHAR(255)\",\"NotNull\":\"True\",\"Default\":\"\"},\"mDate\":{\"Type\":\"TIMESTAMP\",\"NotNull\":\"True\",\"Default\":\"2001-01-01 00:00:00\"},\"mDateTime\":{\"Type\":\"TIMESTAMP\",\"NotNull\":\"True\",\"Default\":\"2001-01-01 00:00:00\"},\"mTimeStamp\":{\"Type\":\"TIMESTAMP\",\"NotNull\":\"True\",\"Default\":\"2001-01-01 00:00:00\"},\"mEnum\":{\"Type\":\"VARCHAR(255)\",\"NotNull\":\"True\",\"Default\":\"\"}}}";
            
            Assert.IsTrue (result.Equals( readClass.ToString(),StringComparison.InvariantCultureIgnoreCase));
        }
    }
}