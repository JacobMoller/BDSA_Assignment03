using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void ReturnIfUriIsSecure_True()
        {
            var uri = new Uri("https://google.com");
            Assert.True(uri.IsSecure());
        }
        [Fact]
        public void ReturnIfUriIsSecure_False()
        {
            var uri = new Uri("http://google.com");
            Assert.False(uri.IsSecure());
        }

        [Fact]
        public void CheckWholeWordsWithoutNumbers_ReturnsSeven()
        {
            var text = @"the quick brown
            f0x jumps ov3r the lazy dog";
            Assert.Equal(7, text.WordCount());
        }
    }
}
