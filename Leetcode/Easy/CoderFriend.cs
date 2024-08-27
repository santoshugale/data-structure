using System.Collections.Generic;

namespace Leetcode.Easy
{
    public class CoderFriend
    {
        public static Dictionary<char, int> score = new()
        {
            {'E',1 },
            {'M',3 },
            {'H',5 },
        };

        public static string Winner(string erica, string bob)
        {
            var ericascore = 0;
            foreach (char c in erica)
            {
                ericascore += score[c];
            }

            var bobscore = 0;
            foreach (char b in bob)
            {
                bobscore += score[b];
            }

            if (ericascore > bobscore) return "Erica";
            else if (bobscore > ericascore) return "Bob";
            return "Ty";
        }
    }
}
