using System.Text.Json.Serialization;

public class GitHubUser
{
    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("company")]
    public string Company { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }
}