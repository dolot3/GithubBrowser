using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RepoChecker;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the extractor class and set the repo name.
            RepoChecker.ICommitExtractor extractor = new RepoChecker.CommitExtractor();
            extractor.RepoName = "dolot3/GitHubBrowser";

            //create the parser to parse the returned data.
            parser theParser = new parser(extractor);

            //get the list of repos
            List<RepoData> thelist = theParser.GetFormattedValues();

            //crude output.
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(thelist));
        }
    }
}
