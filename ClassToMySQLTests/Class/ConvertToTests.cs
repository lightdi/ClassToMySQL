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

        [TestMethod()]
        public void ConvertTest1()
        {

            string[] args = { "-f", @"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs",
                                "-S", @"mysql.gueppardo.net",
                                "-u", @"gueppardo02",
                                "-p", @"gpd1664",
                                "-P", @"3306",
                                "-D", @"gueppardo02"
            };

            Arguments arguments = new Arguments(args);

            Assert.IsTrue(arguments.FromFolder == false);
            Assert.IsTrue(arguments.Source.Equals(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.ToServer == true);
            Assert.IsTrue(arguments.Server.Equals(@"mysql.gueppardo.net", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.User.Equals(@"gueppardo02", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.Password.Equals(@"gpd1664", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.Port.Equals(@"3306", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.Database.Equals(@"gueppardo02", StringComparison.OrdinalIgnoreCase));
            ConvertTo convertTo = new ConvertTo(args);
            convertTo.Convert();
            //Assert.IsTrue(System.IO.File.Exists(@"f:\GVE\ClassToMySQL\MockFactory.sql"));
        }
    }
}