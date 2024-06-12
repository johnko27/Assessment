using Itoa;
using System;
using Xunit;

namespace ItoaTests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidPositiveDecimal()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(12,10);
            Assert.True(actual.Equals("12"));
        }
        [Fact]
        public void ValidNegativeDecimal()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(-24,10);
            Assert.True(actual.Equals("-24"));
        }
        [Fact]
        public void ValidLargeDecimal()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(Int32.MaxValue,10);
            Assert.True(actual.Equals("2147483647"));
        }
        [Fact]
        public void ValidSmallDecimal()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(Int32.MinValue,10);
            Assert.True(actual.Equals("-2147483648"));
        }
        [Fact]
        public void ValidPositiveOctal()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(199,8);
            Assert.True(actual.Equals("307"));
        }
        [Fact]
        public void ValidPositiveHex()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(2815,16);
            Assert.True(actual.Equals("aff"));
        }
        [Fact]
        public void TestValidZero()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(0,10);
            Assert.True(actual.Equals("0"));
        }
        [Fact]
        public void TestInValidBase()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(0,11);
            Assert.True(actual.Equals("Invlaid Base"));
        }
        [Fact]
        public void ValidNegativeOctal()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(-24,8);
            Assert.True(actual.Equals("Invlaid Negative"));
        }
        [Fact]
        public void ValidNegativeHex()
        {
            ItoaClass itoaClass = new ItoaClass();
            string actual = itoaClass.itoa(-24,16);
            Assert.True(actual.Equals("Invlaid Negative"));
        }
    }
}
