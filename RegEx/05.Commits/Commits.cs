namespace _05.Commits
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Commits
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"https:\/\/github.com\/([0-9A-Za-z-]+)\/([a-zA-Z-_]+)\/commit\/([a-fA-F0-9]+),([^\n]+?,)([0-9]+),([0-9]+)";
            var regex = new Regex(pattern);
            var dictionary = new SortedDictionary<string, SortedDictionary<string, List<string>>>();

            while (!input.Equals("git push"))
            {
                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    var user = match.Groups[1].Value;
                    var repo = match.Groups[2].Value;
                    var hash = match.Groups[3].Value;
                    var message = match.Groups[4].Value;
                    message = message.Substring(0,message.Length - 1);
                    var additions = int.Parse(match.Groups[5].Value);
                    var deletions = int.Parse(match.Groups[6].Value);

                    AddToDictionary(dictionary, user, repo, hash, message, additions, deletions);
                }

                input = Console.ReadLine();
            }

            foreach (var userRepo in dictionary)
            {
                Console.WriteLine(userRepo.Key+":");
                foreach (var repoCommits in userRepo.Value)
                {
                    var totalAdditions = 0;
                    var totalDeletions = 0;

                    Console.WriteLine("  "+repoCommits.Key+":");
                    foreach (var commit in repoCommits.Value)
                    {
                        Console.WriteLine("    "+commit);

                        var addAndDel = commit.Substring(commit.IndexOf('(')+1);
                        var addition = addAndDel.Substring(0, addAndDel.IndexOf(' ')).Trim();
                        totalAdditions += int.Parse(addition);

                        var deletion = addAndDel.Substring(addAndDel.IndexOf(',')+1);
                        deletion = deletion.Substring(0, deletion.IndexOf('d') - 1).Trim();
                        totalDeletions += int.Parse(deletion);
                    }

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");

                }
            }
        }

        private static void AddToDictionary(SortedDictionary<string, SortedDictionary<string, List<string>>> dictionary,
            string user, string repo, string hash, string message, int additions, int deletions)
        {
            if (!dictionary.ContainsKey(user))
            {
                dictionary[user] = new SortedDictionary<string, List<string>>();
            }
            if (!dictionary[user].ContainsKey(repo))
            {
                dictionary[user][repo] = new List<string>();
            }

            dictionary[user][repo].Add($"commit {hash}: {message} ({additions} additions, {deletions} deletions)");
        }
    }
}
