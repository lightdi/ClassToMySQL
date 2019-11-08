using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassToMySQL.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassToMySQL.Class.Tests
{
    [TestClass()]
    public class ConvertToTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            string[] args = { "-f", @"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs",
                                "-o", @"f:\GVE\ClassToMySQL\"};

            ConvertTo convertTo = new ConvertTo(args);
            convertTo.Convert();
            Assert.IsTrue(System.IO.File.Exists(@"f:\GVE\ClassToMySQL\MockFactory.sql"));

        }
    }
}