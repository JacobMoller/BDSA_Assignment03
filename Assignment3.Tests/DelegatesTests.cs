using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void ReverseHelloWorld()
        {
            Assert.Equal("dlroWolleH", converter("HelloWorld"));
        }

        [Fact]
        public void ProductOfDecimals()
        {
            Assert.Equal(new decimal(0.04), func(new decimal(0.2), new decimal(0.2)));
        }

        [Fact]
        public void StringEqualToInt_True()
        {
            Assert.True(stringIsEqual("0042", 42));
        }

        [Fact]
        public void StringEqualToInt_False()
        {
            Assert.False(stringIsEqual("0042", 123));
        }


        Func<string, string> converter = delegate (string content)
            {
                char[] charArray = content.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

        Func<decimal, decimal, decimal> func = delegate (decimal x, decimal y) { return x * y; };

        Func<string, int, bool> stringIsEqual = delegate (string s, int i)
            {
                s.Trim();
                int str = Int32.Parse(s);
                if (str == i)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
    }
}
