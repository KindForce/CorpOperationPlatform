using Microsoft.AspNetCore.Mvc;

namespace SA.CorpOperationPlatform.Api.Infrastructure
{
    public class ApiV1RouteAttribute : RouteAttribute
    {
        private const string VersionPrefix = "api/v1/";

        public ApiV1RouteAttribute(string template) : base(VersionPrefix + template)
        {
        }
    }
}