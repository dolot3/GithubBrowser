using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RepoChecker
{
    interface ICommitExtractor
    {

        string RepoName { get; set; }

        string GetCommitsRaw();

    }
}
