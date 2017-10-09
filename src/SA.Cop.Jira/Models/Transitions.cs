namespace SA.Cop.Jira.Models
{
    public enum Transitions : int
    {
        Close = 2,
        StartProgress = 4,
        Resolve = 5,
        StopProgress = 301,
        Review = 711,
        ReturnToProgress = 721
    }
}