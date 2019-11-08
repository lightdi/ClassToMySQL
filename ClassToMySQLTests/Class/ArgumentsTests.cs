using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassToMySQL.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassToMySQL.Class.Tests
{
    [TestClass()]
    public class ArgumentsTests
    {
        [TestMethod()]
        public void ArgumentsTest()
        {

            string[] args = { "-f", @"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs",
                                "-o", @"f:\GVE\ClassToMySQL\"};

            Arguments arguments = new Arguments(args);

            Assert.IsTrue(arguments.FromFolder == false);
            Assert.IsTrue(arguments.Source.Equals(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.ToServer == false);
            Assert.IsTrue(arguments.Target.Equals(@"f:\GVE\ClassToMySQL\", StringComparison.OrdinalIgnoreCase));

        }
        [TestMethod()]
        public void ArgumentsTestFolder()
        {

            string[] args = { "-F", @"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\","-s",
                                "-o", @"f:\GVE\ClassToMySQL\"};

            Arguments arguments = new Arguments(args);

            Assert.IsTrue(arguments.FromFolder == true);
            Assert.IsTrue(arguments.SubFolders == true);
            Assert.IsTrue(arguments.Source.Equals(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.ToServer == false);
            Assert.IsTrue(arguments.Target.Equals(@"f:\GVE\ClassToMySQL\", StringComparison.OrdinalIgnoreCase));

        }
        [TestMethod()]
        public void ArgumentsTestServer()
        {

            string[] args = { "-f", @"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs",
                                "-S", @"Localhost",
                                "-u", @"root",
                                "-p", @"password",
                                "-P", @"3307"
            };

            Arguments arguments = new Arguments(args);

            Assert.IsTrue(arguments.FromFolder == false);
            Assert.IsTrue(arguments.Source.Equals(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.ToServer == true);
            Assert.IsTrue(arguments.Server.Equals(@"Localhost", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.User.Equals(@"root", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.Password.Equals(@"password", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(arguments.Port.Equals(@"3307", StringComparison.OrdinalIgnoreCase));

        }

    }
}
