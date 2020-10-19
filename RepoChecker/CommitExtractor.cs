using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RepoChecker
{
    public class CommitExtractor : ICommitExtractor
    {
        public string RepoName { get; set; }

        public string GetCommitsRaw()
        {
            HttpClient client = GetHttpClient();
            string jsonData;

            var stringTask = client.GetStringAsync($"https://api.github.com/repos/{RepoName}/commits");

            jsonData = stringTask.Result;

            return JArray.Parse(jsonData).ToString();
        }

        private HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "test user agent");    //There's probably something better than this for the user-agent.

            return client;
        }



    }

}
