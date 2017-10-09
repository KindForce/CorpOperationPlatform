using System;
using FluentAssertions;
using SA.CorpOperationPlatform.Api.Infrastructure;
using Xunit;

namespace SA.Cop.Api.UnitTests
{
    public class AttributeTests
    {
        [Fact]
        public void apiv1_should_return_template_with_prefix()
        {
            var template = "TestController";
            var expectedTemplate = "api/v1/TestController";

            var attribute = new ApiV1RouteAttribute(template);

            attribute.Template.ShouldBeEquivalentTo(expectedTemplate);
        }
    }
}