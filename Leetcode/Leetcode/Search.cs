using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class SearchItems
    {
        public static List<List<string>> GetList(List<string> items, string searchTerm)
        {
            var result = new List<List<string>>();

            for (int i = 0; i <= searchTerm.Length - 1; i++)
            {
                var searchSubString = searchTerm.Substring(0, i);
                var match = items.Where((item) => item.StartsWith(searchSubString))
                                 .OrderBy(x => x)
                                 .Take(3)
                                 .ToList();
                result.Add(match);

            }
            return result;
        }
    }
}
