using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class SimpleTextQueries
    {
        public static List<List<int>> TextQueries(List<string> sentences, List<string> queries)
        {
            var result = new List<List<int>>();
            for (int i = 0; i <= queries.Count - 1; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j <= sentences.Count - 1; j++)
                {
                    var wordsInQuery = queries[i].Split(' ');
                    var found = true;
                    foreach (var word in wordsInQuery)
                    {
                        if (!sentences[j].Contains(word))
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        result[i].Add(j);
                    }
                }
                if (result[i].Count == 0)
                {
                    result[i].Add(-1);
                }
            }

            return result;
        }

        public static List<List<int>> TextQueriesOptimized(List<string> sentences, List<string> queries)
        {
            var result = new List<List<int>>();
            var sentenceDict = new Dictionary<int, HashSet<string>>();
            for (int i = 0; i <= sentences.Count - 1; i++)
            {
                var hashSet = new HashSet<string>();
                var sentenceWords = sentences[i].Split(' ');
                foreach (var item in sentenceWords)
                {
                    hashSet.Add(item);
                }
                sentenceDict.Add(i, hashSet);
            }


            for (int i = 0; i <= queries.Count - 1; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j <= sentenceDict.Count - 1; j++)
                {
                    var found = true;
                    var wordsInQuery = queries[i].Split(' ');
                    foreach (var word in wordsInQuery)
                    {
                        if (!sentenceDict[j].Contains(word))
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        result[i].Add(j);
                    }
                }
                if (result[i].Count == 0)
                {
                    result[i].Add(-1);
                }
            }

            return result;
        }
    }
}
