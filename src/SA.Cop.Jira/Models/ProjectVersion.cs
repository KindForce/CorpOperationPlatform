using Newtonsoft.Json;

namespace SA.Cop.Jira.Models
{
    public class ProjectVersion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("released")]
        public bool Released { get; set; }

        [JsonProperty("projectId")]
        public long ProjectId { get; set; }
    }
}