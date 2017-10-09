namespace SA.Cop.Core
{
    public interface IIssueTracker
    {
        bool TransitionTaskToReview(string issue);
    }
}