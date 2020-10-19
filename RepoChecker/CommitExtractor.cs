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

            //in the real world you may want to soften this up a little further - at minimum place it in a config file.
            var stringTask = client.GetStringAsync($"https://api.github.com/repos/{RepoName}/commits");

            //perform the task and get the results
            jsonData = stringTask.Result;

            //parse it into a json array and return the string
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
