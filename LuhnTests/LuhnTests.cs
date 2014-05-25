using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

/****
 * Tests are done against the following numbers:
 * - Non existing VISA card
 * - Organization number for Swedish Försäkringskassa
 * - Organization number for Swedish SJ
 * - Organization number for TeliaSonera Network Sales Aktiebolag
 * - Bankgiro number for Swedish Försäkringskassan
 * - Bangiro number for Swedish SJ
 */
namespace LuhnTests
{
    [TestFixture]
    public class LuhnTests
    {
        public LuhnTests()
        {
        }

        #region LuhnVal, Valid

        [Test(Description="Valid VISA card")]
        [Category("Valid")]
        public void TestIsValidVISA()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("4111 1111 1111 1111"), "Valid VISA card number");
        }

        [Test(Description="Valid org number Försäkringskassan")]
        [Category("Valid")]
        public void TestIsValidFKOrg()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("202100-5521"), "Valid org number for Försäkringskassan");
        }

        [Test(Description="Valid bankgiro number Försäkringskassan")]
        [Category("Valid")]
        public void TestIsValidFKBG()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("181-0993"), "Valid bankgiro number for Försäkringskassa");
        }

        [Test(Description="Valid org number SJ")]
        [Category("Valid")]
        public void TestIsValidSJOrg()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("556196-1599"), "Valid org number for SJ");
        }

        [Test(Description = "Valid bankgiro numberSJ")]
        [Category("Valid")]
        public void TestIsValidSJBG()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("785-8426"), "Valid bankgiro number for SJ");
        }

        [Test(Description = "Valid org number TeliaSonera Network Sales")]
        [Category("Valid")]
        public void TestIsValidTeliaSonera()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("556458-0040"), "Valid org number for TeliaSonera Network Sales");
        }

        #endregion

        #region LuhnVal, Invalid
        [Test(Description="Invalid VISA card number")]
        [Category("Invalid")]
        public void TestIsInvalidVISA()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("4111 1111 1111 1112"), "Invalid VISA card number");
        }

        [Test(Description="Invalid org number Försäkringskassan")]
        [Category("Invalid")]
        public void TestIsInvalidFKOrg()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("202100-5522"), "Invalid org number for Försäkringskassan");
        }

        [Test(Description="Invalid bankgiro number Försäkringskassan")]
        [Category("Invalid")]
        public void TestIsInvalidFKBG()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("181-0994"), "Invalid bankgiro number for Försäkringskassa");
        }

        [Test(Description="Invalid org number SJ")]
        [Category("Invalid")]
        public void TestIsInvalidSJOrg()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("556196-1598"), "Invalid org number for SJ");
        }

        [Test(Description="Invalid bankgiro number SJ")]
        [Category("Invalid")]
        public void TestIsInvalidSJBG()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("785-8427"), "Invalid bankgiro number for SJ");
        }

        [Test(Description = "Invalid org number for TeliaSonera Network Sales")]
        [Category("Invalid")]
        public void TestIsInvalidTeliaSonera()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("556458-0041"), "Invalid org number for TeliaSonera Network Sales");
        }
        #endregion

        #region LuhnGen
        [Test(Description="Generate VISA checksum")]
        [Category("Generate Checksum")]
        public void TestGenVISAChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("4111 1111 1111 111"), "1", "VISA card number");
        }
        
        [Test(Description="Generate FK Org number checksum")]
        [Category("Generate Checksum")]
        public void TestGenFKOrgChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("202100-552"), "1", "Org number for Försäkringskassa");
        }

        [Test(Description="Generate FK bankgiro number checksum")]
        [Category("Generate Checksum")]
        public void TestGenFKBGChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("181-099"), "3", "Bankgiro number for Försäkringskassan");
        }

        [Test(Description="Generate SJ org number checksum")]
        [Category("Generate Checksum")]
        public void TestGenSJOrgChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("556196-159"), "9", "Org number for SJ");
        }

        [Test(Description="Generate SJ bankgiro number checksum")]
        [Category("Generate Checksum")]
        public void TestGenSJBGChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("785-842"), "6", "Bankgiro number for SJ");
        }

        [Test(Description = "Generate TeliaSonera Network Sales checksum")]
        [Category("Generate Checksum")]
        public void TestGenTeliaSoneraChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("556458-004"), "0", "Org number for TeliaSonera Network Sales");
        }
        #endregion
    }
}
