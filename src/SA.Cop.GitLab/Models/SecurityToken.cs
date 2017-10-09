using Newtonsoft.Json;

namespace SA.Cop.GitLab.Models
{
    public class SecurityToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}