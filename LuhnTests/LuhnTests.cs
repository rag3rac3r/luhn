using System;
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
        // Empty string

        [Test(Description = "Test Reverse")]
        [Category("Utils")]
        public void TestReverser()
        {
            StringAssert.IsMatch(Luhn.Luhn.Reverse("abcdef"), "fedcba", "Reverse string");
        }

        [Test(Description = "Test Cleaner")]
        [Category("Utils")]
        public void TestCleaner()
        {
            StringAssert.IsMatch(Luhn.Luhn.Clean("a1b2c3d4"), "1234", "Clean string");
        }

        #region LuhnVal

        [Test(Description = "Test if LuhnVal throws exception on empty parameter")]
        [Category("Validator")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LuhnValEmptyParameter()
        {
            Luhn.Luhn.LuhnVal("");
        }

        [Test(Description="Valid VISA card")]
        [Category("Validator")]
        public void IsValidVISA()
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal("4111 1111 1111 1111"), "Valid VISA card number");
        }

        [Test(Description = "Invalid VISA card number")]
        [Category("Validator")]
        public void IsInvalidVISA()
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal("4111 1111 1111 1112"), "Invalid VISA card number");
        }

        [Test(Description = "Test validation of Org Numbers (valid)")]
        [Category("Validator")]
        [TestCase("202100-5521", "Valid org number for Försäkringskassan")]
        [TestCase("556196-1599", "Valid org number for SJ")]
        [TestCase("556458-0040", "Valid org number for TeliaSonera Network Sales")]
        public void IsValidOrgNumber(string number, string msg)
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal(number), msg);
        }

        [Test(Description = "Test validation of Org numbers (invalid)")]
        [Category("Validator")]
        [TestCase("202100-5522", "Invalid org number for Försäkringskassan")]
        [TestCase("556196-1598", "Invalid org number for SJ")]
        [TestCase("556458-0041", "Invalid org number for TeliaSonera Network Sales")]
        public void IsInvalidOrgNumber(string number, string msg)
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal(number), msg);
        }

        [Test(Description = "Test validatoin of Bankgiro numbers (valid)")]
        [Category("Validator")]
        [TestCase("181-0993", "Valid bankgiro number for Försäkringskassa")]
        [TestCase("785-8426", "Valid bankgiro number for SJ")]
        public void IsValidBGNumber(string number, string msg)
        {
            Assert.IsTrue(Luhn.Luhn.LuhnVal(number), msg);
        }

        [Test(Description = "Test validation of bankgiro numbers (invalid)")]
        [Category("Validator")]
        [TestCase("181-0994", "Invalid bankgiro number for Försäkringskassan")]
        [TestCase("785-8427", "Invalid bankgiro number for SJ")]
        public void IsInvalidBGNumber(string number, string msg)
        {
            Assert.IsFalse(Luhn.Luhn.LuhnVal(number), msg);
        }

        #endregion

        #region LuhnGen
        
        [Test(Description = "Test empty string to LuhnGen")]
        [Category("Generator")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestLuhngenEmpty()
        {
            Luhn.Luhn.LuhnGen("");
        }

        [Test(Description="Generate VISA card checksum")]
        [Category("Generator")]
        public void TestGenVISAChecksum()
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen("4111 1111 1111 111"), "1", "VISA card number");
        }

        [Test(Description = "Generate Org number checksum")]
        [Category("Generator")]
        [TestCase("202100-552", "1", "Org number for Försäkringskassan")]
        [TestCase("556196-159", "9", "Org number for SJ")]
        [TestCase("556458-004", "0", "Org number for TeliaSonera Network Sales")]
        public void GenerateOrgNumberChecksum(string number, string checksum, string msg)
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen(number), checksum, msg);
        }

        [Test(Description = "Generate BG number checksum")]
        [Category("Generator")]
        [TestCase("181-099", "3", "Bankgiro number for Försäkringskassan")]
        [TestCase("785-842", "6", "Bankgiro number for SJ")]
        public void GenerateBGNumberChecksum(string number, string checksum, string msg)
        {
            StringAssert.IsMatch(Luhn.Luhn.LuhnGen(number), checksum, msg);
        }

        #endregion
    }
}
