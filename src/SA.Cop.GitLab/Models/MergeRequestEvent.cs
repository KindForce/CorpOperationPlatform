using Newtonsoft.Json;

namespace SA.Cop.GitLab.Models
{
    public class MergeRequestEvent
    {
        [JsonProperty("user")]
        public GitLabUser User { get; set; }

        [JsonProperty("object_attributes")]
        public MergeRequestAttributes ObjectAttributes { get; set; }

        [JsonProperty("assignee")]
        public GitLabUser Assignee { get; set; }
    }
}