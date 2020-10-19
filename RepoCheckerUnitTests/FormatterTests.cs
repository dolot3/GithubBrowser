using System;
using Xunit;
using Moq;
using RepoChecker;
using System.Collections.Generic;
using System.Linq;

namespace RepoCheckerUnitTests
{
    public class FormatterTests
    {
        [Fact]
        public void GetFormattedValues_Test()
        {
            List<RepoData> expected;

            Mock<ICommitExtractor> mockExtractor = new Mock<ICommitExtractor>();
            mockExtractor.Setup(m => m.GetCommitsRaw()).Returns(getTestRawValues());

            parser theFormatter = new parser(mockExtractor.Object);

            expected = theFormatter.GetFormattedValues();

            Assert.Equal(3, expected.Count);
            Assert.Equal("dolot3", expected[0].Committer);
            Assert.Equal("Added interface", expected[1].Message);
            Assert.Equal("07/21/2020 14:39:00", expected[2].CommitDate);

        }

        

        private string getTestRawValues()
        {
            return @"[
  {
    ""sha"": ""294f88a6b4db801ed779794e079682c0d5f9b7a0"",
    ""node_id"": ""MDY6Q29tbWl0MjgxMjE0OTUwOjI5NGY4OGE2YjRkYjgwMWVkNzc5Nzk0ZTA3OTY4MmMwZDVmOWI3YTA="",
    ""commit"": {
                ""author"": {
                    ""name"": ""unknown"",
        ""email"": ""16364092+dolot3@users.noreply.github.com"",
        ""date"": ""2020-07-21T18:06:16Z""
                },
      ""committer"": {
                    ""name"": ""unknown"",
        ""email"": ""16364092+dolot3@users.noreply.github.com"",
        ""date"": ""2020-07-21T18:06:16Z""
      },
      ""message"": ""Added console app and finished class"",
      ""tree"": {
                    ""sha"": ""6d24fda0b12286e9fb71a1a78780862f214159a1"",
        ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/git/trees/6d24fda0b12286e9fb71a1a78780862f214159a1""
      },
      ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/git/commits/294f88a6b4db801ed779794e079682c0d5f9b7a0"",
      ""comment_count"": 0,
      ""verification"": {
                    ""verified"": false,
        ""reason"": ""unsigned"",
        ""signature"": null,
        ""payload"": null
      }
            },
    ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/294f88a6b4db801ed779794e079682c0d5f9b7a0"",
    ""html_url"": ""https://github.com/dolot3/GithubBrowser/commit/294f88a6b4db801ed779794e079682c0d5f9b7a0"",
    ""comments_url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/294f88a6b4db801ed779794e079682c0d5f9b7a0/comments"",
    ""author"": {
                ""login"": ""dolot3"",
      ""id"": 16364092,
      ""node_id"": ""MDQ6VXNlcjE2MzY0MDky"",
      ""avatar_url"": ""https://avatars3.githubusercontent.com/u/16364092?v=4"",
      ""gravatar_id"": """",
      ""url"": ""https://api.github.com/users/dolot3"",
      ""html_url"": ""https://github.com/dolot3"",
      ""followers_url"": ""https://api.github.com/users/dolot3/followers"",
      ""following_url"": ""https://api.github.com/users/dolot3/following{/other_user}"",
      ""gists_url"": ""https://api.github.com/users/dolot3/gists{/gist_id}"",
      ""starred_url"": ""https://api.github.com/users/dolot3/starred{/owner}{/repo}"",
      ""subscriptions_url"": ""https://api.github.com/users/dolot3/subscriptions"",
      ""organizations_url"": ""https://api.github.com/users/dolot3/orgs"",
      ""repos_url"": ""https://api.github.com/users/dolot3/repos"",
      ""events_url"": ""https://api.github.com/users/dolot3/events{/privacy}"",
      ""received_events_url"": ""https://api.github.com/users/dolot3/received_events"",
      ""type"": ""User"",
      ""site_admin"": false
    },
    ""committer"": {
                ""login"": ""dolot3"",
      ""id"": 16364092,
      ""node_id"": ""MDQ6VXNlcjE2MzY0MDky"",
      ""avatar_url"": ""https://avatars3.githubusercontent.com/u/16364092?v=4"",
      ""gravatar_id"": """",
      ""url"": ""https://api.github.com/users/dolot3"",
      ""html_url"": ""https://github.com/dolot3"",
      ""followers_url"": ""https://api.github.com/users/dolot3/followers"",
      ""following_url"": ""https://api.github.com/users/dolot3/following{/other_user}"",
      ""gists_url"": ""https://api.github.com/users/dolot3/gists{/gist_id}"",
      ""starred_url"": ""https://api.github.com/users/dolot3/starred{/owner}{/repo}"",
      ""subscriptions_url"": ""https://api.github.com/users/dolot3/subscriptions"",
      ""organizations_url"": ""https://api.github.com/users/dolot3/orgs"",
      ""repos_url"": ""https://api.github.com/users/dolot3/repos"",
      ""events_url"": ""https://api.github.com/users/dolot3/events{/privacy}"",
      ""received_events_url"": ""https://api.github.com/users/dolot3/received_events"",
      ""type"": ""User"",
      ""site_admin"": false
    },
    ""parents"": [
      {
                ""sha"": ""465daa5e4f7f32113b36a96d9d3500ce3607f7a2"",
        ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/465daa5e4f7f32113b36a96d9d3500ce3607f7a2"",
        ""html_url"": ""https://github.com/dolot3/GithubBrowser/commit/465daa5e4f7f32113b36a96d9d3500ce3607f7a2""
      }
    ]
  },
  {
    ""sha"": ""465daa5e4f7f32113b36a96d9d3500ce3607f7a2"",
    ""node_id"": ""MDY6Q29tbWl0MjgxMjE0OTUwOjQ2NWRhYTVlNGY3ZjMyMTEzYjM2YTk2ZDlkMzUwMGNlMzYwN2Y3YTI="",
    ""commit"": {
      ""author"": {
        ""name"": ""unknown"",
        ""email"": ""16364092+dolot3@users.noreply.github.com"",
        ""date"": ""2020-07-21T16:27:21Z""
      },
      ""committer"": {
        ""name"": ""unknown"",
        ""email"": ""16364092+dolot3@users.noreply.github.com"",
        ""date"": ""2020-07-21T16:27:21Z""
      },
      ""message"": ""Added interface"",
      ""tree"": {
        ""sha"": ""0fd568382e784ec1cb22e9fc51d2211ef217c4d1"",
        ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/git/trees/0fd568382e784ec1cb22e9fc51d2211ef217c4d1""
      },
      ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/git/commits/465daa5e4f7f32113b36a96d9d3500ce3607f7a2"",
      ""comment_count"": 0,
      ""verification"": {
        ""verified"": false,
        ""reason"": ""unsigned"",
        ""signature"": null,
        ""payload"": null
      }
    },
    ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/465daa5e4f7f32113b36a96d9d3500ce3607f7a2"",
    ""html_url"": ""https://github.com/dolot3/GithubBrowser/commit/465daa5e4f7f32113b36a96d9d3500ce3607f7a2"",
    ""comments_url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/465daa5e4f7f32113b36a96d9d3500ce3607f7a2/comments"",
    ""author"": {
      ""login"": ""dolot3"",
      ""id"": 16364092,
      ""node_id"": ""MDQ6VXNlcjE2MzY0MDky"",
      ""avatar_url"": ""https://avatars3.githubusercontent.com/u/16364092?v=4"",
      ""gravatar_id"": """",
      ""url"": ""https://api.github.com/users/dolot3"",
      ""html_url"": ""https://github.com/dolot3"",
      ""followers_url"": ""https://api.github.com/users/dolot3/followers"",
      ""following_url"": ""https://api.github.com/users/dolot3/following{/other_user}"",
      ""gists_url"": ""https://api.github.com/users/dolot3/gists{/gist_id}"",
      ""starred_url"": ""https://api.github.com/users/dolot3/starred{/owner}{/repo}"",
      ""subscriptions_url"": ""https://api.github.com/users/dolot3/subscriptions"",
      ""organizations_url"": ""https://api.github.com/users/dolot3/orgs"",
      ""repos_url"": ""https://api.github.com/users/dolot3/repos"",
      ""events_url"": ""https://api.github.com/users/dolot3/events{/privacy}"",
      ""received_events_url"": ""https://api.github.com/users/dolot3/received_events"",
      ""type"": ""User"",
      ""site_admin"": false
    },
    ""committer"": {
      ""login"": ""dolot3"",
      ""id"": 16364092,
      ""node_id"": ""MDQ6VXNlcjE2MzY0MDky"",
      ""avatar_url"": ""https://avatars3.githubusercontent.com/u/16364092?v=4"",
      ""gravatar_id"": """",
      ""url"": ""https://api.github.com/users/dolot3"",
      ""html_url"": ""https://github.com/dolot3"",
      ""followers_url"": ""https://api.github.com/users/dolot3/followers"",
      ""following_url"": ""https://api.github.com/users/dolot3/following{/other_user}"",
      ""gists_url"": ""https://api.github.com/users/dolot3/gists{/gist_id}"",
      ""starred_url"": ""https://api.github.com/users/dolot3/starred{/owner}{/repo}"",
      ""subscriptions_url"": ""https://api.github.com/users/dolot3/subscriptions"",
      ""organizations_url"": ""https://api.github.com/users/dolot3/orgs"",
      ""repos_url"": ""https://api.github.com/users/dolot3/repos"",
      ""events_url"": ""https://api.github.com/users/dolot3/events{/privacy}"",
      ""received_events_url"": ""https://api.github.com/users/dolot3/received_events"",
      ""type"": ""User"",
      ""site_admin"": false
    },
    ""parents"": [
      {
        ""sha"": ""1018279a58cdcd46148f89f6fb047bbad575f812"",
        ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/1018279a58cdcd46148f89f6fb047bbad575f812"",
        ""html_url"": ""https://github.com/dolot3/GithubBrowser/commit/1018279a58cdcd46148f89f6fb047bbad575f812""
      }
    ]
  },
  {
    ""sha"": ""1018279a58cdcd46148f89f6fb047bbad575f812"",
    ""node_id"": ""MDY6Q29tbWl0MjgxMjE0OTUwOjEwMTgyNzlhNThjZGNkNDYxNDhmODlmNmZiMDQ3YmJhZDU3NWY4MTI="",
    ""commit"": {
        ""author"": {
            ""name"": ""unknown"",
        ""email"": ""16364092+dolot3@users.noreply.github.com"",
        ""date"": ""2020-07-21T14:39:00Z""
        },
      ""committer"": {
            ""name"": ""unknown"",
        ""email"": ""16364092+dolot3@users.noreply.github.com"",
        ""date"": ""2020-07-21T14:39:00Z""
      },
      ""message"": ""Initial checkin"",
      ""tree"": {
            ""sha"": ""c372ee61069e58427de64be5079a8ea220d42896"",
        ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/git/trees/c372ee61069e58427de64be5079a8ea220d42896""
      },
      ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/git/commits/1018279a58cdcd46148f89f6fb047bbad575f812"",
      ""comment_count"": 0,
      ""verification"": {
            ""verified"": false,
        ""reason"": ""unsigned"",
        ""signature"": null,
        ""payload"": null
      }
    },
    ""url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/1018279a58cdcd46148f89f6fb047bbad575f812"",
    ""html_url"": ""https://github.com/dolot3/GithubBrowser/commit/1018279a58cdcd46148f89f6fb047bbad575f812"",
    ""comments_url"": ""https://api.github.com/repos/dolot3/GithubBrowser/commits/1018279a58cdcd46148f89f6fb047bbad575f812/comments"",
    ""author"": {
        ""login"": ""dolot3"",
      ""id"": 16364092,
      ""node_id"": ""MDQ6VXNlcjE2MzY0MDky"",
      ""avatar_url"": ""https://avatars3.githubusercontent.com/u/16364092?v=4"",
      ""gravatar_id"": """",
      ""url"": ""https://api.github.com/users/dolot3"",
      ""html_url"": ""https://github.com/dolot3"",
      ""followers_url"": ""https://api.github.com/users/dolot3/followers"",
      ""following_url"": ""https://api.github.com/users/dolot3/following{/other_user}"",
      ""gists_url"": ""https://api.github.com/users/dolot3/gists{/gist_id}"",
      ""starred_url"": ""https://api.github.com/users/dolot3/starred{/owner}{/repo}"",
      ""subscriptions_url"": ""https://api.github.com/users/dolot3/subscriptions"",
      ""organizations_url"": ""https://api.github.com/users/dolot3/orgs"",
      ""repos_url"": ""https://api.github.com/users/dolot3/repos"",
      ""events_url"": ""https://api.github.com/users/dolot3/events{/privacy}"",
      ""received_events_url"": ""https://api.github.com/users/dolot3/received_events"",
      ""type"": ""User"",
      ""site_admin"": false
    },
    ""committer"": {
        ""login"": ""dolot3"",
      ""id"": 16364092,
      ""node_id"": ""MDQ6VXNlcjE2MzY0MDky"",
      ""avatar_url"": ""https://avatars3.githubusercontent.com/u/16364092?v=4"",
      ""gravatar_id"": """",
      ""url"": ""https://api.github.com/users/dolot3"",
      ""html_url"": ""https://github.com/dolot3"",
      ""followers_url"": ""https://api.github.com/users/dolot3/followers"",
      ""following_url"": ""https://api.github.com/users/dolot3/following{/other_user}"",
      ""gists_url"": ""https://api.github.com/users/dolot3/gists{/gist_id}"",
      ""starred_url"": ""https://api.github.com/users/dolot3/starred{/owner}{/repo}"",
      ""subscriptions_url"": ""https://api.github.com/users/dolot3/subscriptions"",
      ""organizations_url"": ""https://api.github.com/users/dolot3/orgs"",
      ""repos_url"": ""https://api.github.com/users/dolot3/repos"",
      ""events_url"": ""https://api.github.com/users/dolot3/events{/privacy}"",
      ""received_events_url"": ""https://api.github.com/users/dolot3/received_events"",
      ""type"": ""User"",
      ""site_admin"": false
    },
    ""parents"": []
  }
]
";
        }
    }
}
