using Newtonsoft.Json;

namespace SA.Cop.Jira.Models
{
    public class JiraIssuesResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}