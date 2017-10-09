using Newtonsoft.Json;

namespace SA.Cop.GitLab.Models
{
    public class GitLabUser
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}