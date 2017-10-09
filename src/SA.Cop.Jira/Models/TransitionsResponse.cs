using System.Collections.Generic;
using Newtonsoft.Json;

namespace SA.Cop.Jira.Models
{
    public class TransitionsResponse
    {
        [JsonProperty("transitions")]
        public IEnumerable<JiraTransition> Transitions { get; set; }
    }

    public class JiraTransition
    {
        [JsonProperty("id")]
        public Transitions Transition { get; set; }
    }
}