using System;
using System.Collections.Generic;
using System.Text;

namespace RepoChecker
{
    public class parser
    {
        private ICommitExtractor extractor;

        public parser(ICommitExtractor theExtractor)
        {
            extractor = theExtractor;
        }


        public List<RepoData> GetFormattedValues()
        {
            List<RepoData> theList = new List<RepoData>();
            var rawData = extractor.GetCommitsRaw().ToString();

            dynamic commits = Newtonsoft.Json.Linq.JArray.Parse(rawData.ToString());

            foreach(dynamic commit in commits)
            {
                RepoData theData = new RepoData();

                theData.Committer = commit.committer.login;
                theData.Message = commit.commit.message;
                theData.CommitDate = commit.commit.author.date;
                theList.Add(theData);
            }

            return theList;
        }
    }
}
