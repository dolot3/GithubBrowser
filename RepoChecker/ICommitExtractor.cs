using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RepoChecker
{
    public interface ICommitExtractor
    {

        string RepoName { get; set; }

        Task<dynamic> GetCommitsRaw();

    }
}
