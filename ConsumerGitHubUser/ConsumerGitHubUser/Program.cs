using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://api.github.com/users/mojombo";

        using (HttpClient client = new HttpClient())
        {
            // HEADERS OBRIGATÓRIOS
            client.DefaultRequestHeaders.Add("User-Agent", "request");
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                GitHubUser user = JsonSerializer.Deserialize<GitHubUser>(json);

                Console.WriteLine("Nome: " + user.Name);
                Console.WriteLine("Empresa: " + user.Company);
                Console.WriteLine("Localização: " + user.Location);
                Console.WriteLine("Login: " + user.Login);
            }
            else
            {
                Console.WriteLine("Erro ao consumir API: " + response.StatusCode);
            }
        }
    }
}