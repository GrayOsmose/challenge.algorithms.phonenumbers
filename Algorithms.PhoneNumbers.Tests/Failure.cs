using System;
using System.Collections.Generic;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class Failure
    {
        [Fact]
        public void TwoPhoneNumber()
        {
            // {arrange}
            var phoneNumbers = new List<string> { "0911", "091"};

            // {act}
            var result = SymbolTriWrapper.GetResultFrom(phoneNumbers);

            // {assert}
            Assert.Equal(false, result);
        }
    }
}
