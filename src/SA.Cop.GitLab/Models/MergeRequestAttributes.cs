using Newtonsoft.Json;

namespace SA.Cop.GitLab.Models
{

    public class MergeRequestAttributes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author_id")]
        public int AuthorId { get; set; }

        [JsonProperty("assignee")]
        public GitLabUser Assignee { get; set; }

        [JsonProperty("action")]
        public ActionType Action { get; set; }
    }
}