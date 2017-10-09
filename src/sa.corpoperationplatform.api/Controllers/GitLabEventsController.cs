using System.Net;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using SA.Cop.Core;
using SA.Cop.GitLab.Models;
using SA.CorpOperationPlatform.Api.Infrastructure;

namespace SA.CorpOperationPlatform.Api.Controllers
{
    [ApiV1Route("{project:string}")]
    public class GitLabEventsController : Controller
    {
        private readonly IIssueTracker _issueTracker;

        public GitLabEventsController([NotNull] IIssueTracker issueTracker)
        {
            _issueTracker = issueTracker ?? throw new System.ArgumentNullException(nameof(issueTracker));
        }

        [HttpPost]
        [Route("mergeRequest")]
        public Task<HttpStatusCode> ProcessMergeRequestChange(string project, MergeRequestEvent mergeRequest)
        {
            _issueTracker.TransitionTaskToReview("12");
            return Task.FromResult(HttpStatusCode.OK);
        }
    }
}