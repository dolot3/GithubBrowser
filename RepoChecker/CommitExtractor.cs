using System;

namespace RepoChecker
{
    public class CommitExtractor : ICommitExtractor
    {
        public string RepoName { get; set; }

        public string GetCommitsRaw()
        {
            throw new NotImplementedException();
        }
    }

}
