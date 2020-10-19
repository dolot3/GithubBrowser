using System;
using System.Collections.Generic;
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

            parser theParser = new parser(extractor);

            List<RepoData> thelist = theParser.GetFormattedValues();

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(thelist));
        }
    }
}
