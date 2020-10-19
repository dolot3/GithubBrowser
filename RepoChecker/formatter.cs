using System;
using System.Collections.Generic;
using System.Text;

namespace RepoChecker
{
    //class for parsing the raw github repo data and extracting the pieces that are relevant.
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

            //get the data
            var rawData = extractor.GetCommitsRaw().ToString();

            //parse into json array.
            dynamic commits = Newtonsoft.Json.Linq.JArray.Parse(rawData.ToString());

            //Create a new RepoData element for each commit object returned.
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
