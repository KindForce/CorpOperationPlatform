using FluentAssertions;
using SA.Cop.Extensions;
using Xunit;

namespace SA.Cop.Api.UnitTests
{
    public class ExtensionsTests
    {
        [Fact]
        public void convert_string_to_base64()
        {
            var inputString = "test_string";
            var expectedResult = "dGVzdF9zdHJpbmc=";

            var result = inputString.ToBase64();

            result.ShouldBeEquivalentTo(expectedResult);
        }
    }
}