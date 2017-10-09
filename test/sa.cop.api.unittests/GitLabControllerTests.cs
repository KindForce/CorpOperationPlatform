using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SA.Cop.Core;
using SA.Cop.GitLab.Models;
using SA.CorpOperationPlatform.Api.Controllers;
using Xunit;

namespace SA.Cop.Api.UnitTests
{
    public class GitLabControllerTests
    {
        [Fact]
        public async Task mergeRequest_processing_should_return_200_code()
        {
            var issueTrackerMock = new Mock<IIssueTracker>();
            issueTrackerMock.Setup(it => it.TransitionTaskToReview(It.IsAny<string>())).Verifiable();

            var controller = new GitLabEventsController(issueTrackerMock.Object);

            var result = await controller.ProcessMergeRequestChange("TestProject", new MergeRequestEvent());

            issueTrackerMock.Verify(tracker => tracker.TransitionTaskToReview(It.IsAny<string>()), Times.Once, "Transition hasn't executed");
            result.ShouldBeEquivalentTo(HttpStatusCode.OK);
        }
    }
}