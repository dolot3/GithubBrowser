using System;
using System.Threading.Tasks;
using RepoChecker;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RepoChecker.ICommitExtractor extractor = new RepoChecker.CommitExtractor();

            extractor.RepoName = "dolot3/GitHubBrowser";

            var value = await extractor.GetCommitsRaw();

            Console.WriteLine(value.ToString());
        }
    }
}
