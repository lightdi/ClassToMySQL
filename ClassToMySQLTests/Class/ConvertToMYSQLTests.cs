﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassToMySQL.Class;
using System;
using System.Collections.Generic;
using System.Text;


namespace ClassToMySQL.Class.Tests
{
    [TestClass()]
    public class ConvertToMYSQLTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            string sSQL = @"CREATE TABLE `mockfactory` ( `Id` BIGINT(20) NOT NULL AUTO_INCREMENT, `mInt` INT(11) NOT NULL DEFAULT '0', `mVarChar` VARCHAR(255) NOT NULL DEFAULT '', `mDouble` DOUBLE(15,6) NOT NULL DEFAULT '0.000000', `mLongId` BIGINT(20) NOT NULL DEFAULT '0', `mBlob` VARCHAR(255) NOT NULL DEFAULT '', `mDate` TIMESTAMP NOT NULL DEFAULT '2001-01-01 00:00:00', `mDateTime` TIMESTAMP NOT NULL DEFAULT '2001-01-01 00:00:00', `mTimeStamp` TIMESTAMP NOT NULL DEFAULT '2001-01-01 00:00:00', `mEnum` VARCHAR(255) NOT NULL DEFAULT '', PRIMARY KEY (`Id`), INDEX `mLongId` (`mLongId`)) COLLATE='utf8_general_ci' ENGINE=InnoDB;";

            ReadClass readClass = new ReadClass(@"f:\GVE\ClassToMySQL\ClassToMySQLTests\Class\MockFactory.cs");
            ConvertToMYSQL convet = new ConvertToMYSQL(readClass);
            string converted = convet.ToString();
            //System.Diagnostics.Debug.Print(sSQL);
            //System.Diagnostics.Debug.Print(converted);
            Assert.IsTrue(sSQL.Equals(converted, StringComparison.OrdinalIgnoreCase));

        }
    }
}