using System;
using System.Collections.Generic;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class Success
    {
        [Fact]
        public void OnePhoneNumber()
        {
            // {arrange}
            var phoneNumbers = new List<string> { "0911" };

            // {act}
            var result = SymbolTriWrapper.GetResultFrom(phoneNumbers);

            // {assert}
            Assert.Equal(true, result);
        }

        [Fact]
        public void TwoPhoneNumber()
        {
            // {arrange}
            var phoneNumbers = new List<string> { "0911", "0912" };

            // {act}
            var result = SymbolTriWrapper.GetResultFrom(phoneNumbers);

            // {assert}
            Assert.Equal(true, result);
        }
    }
}
