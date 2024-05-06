using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



class Result
{

    /*
     * Complete the 'findBeforeMatrix' function below.
     *
     * The function is expected to return a 2D_INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY after as parameter.
     */

    public static List<List<int>> findBeforeMatrix(List<List<int>> after)
    {
        List<List<int>> before = new List<List<int>>(after.Count);
        for (int i = 0; i < after.Count; i++)
        {
            var list = new List<int>();
            for (int j = 0; j < after[i].Count; j++)
            {
                var up = i <= 0 ? 0 : after[i - 1][j];
                var left = j <= 0 ? 0 : after[i][j - 1];
                var up_left = i <= 0 || j <= 0 ? 0 : after[i - 1][j - 1];
                list.Add(after[i][j] - left - up + up_left);
            }
            before.Add(list);
        }
        return before;
    }

}

class Solution1
{
    public static void Main1111(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int afterRows = Convert.ToInt32(Console.ReadLine().Trim());
        int afterColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> after = new List<List<int>>();

        for (int i = 0; i < afterRows; i++)
        {
            after.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(afterTemp => Convert.ToInt32(afterTemp)).ToList());
        }

        List<List<int>> result = Result.findBeforeMatrix(after);

        textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

        textWriter.Flush();
        textWriter.Close();
    }
}


//SET NOCOUNT ON;


///*
//Enter your query here.
//Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
//*/

//select S.ID, S.Name
//from STUDENT S
//where S.ID IN (select top 3 ID
//                from student
//                order by SCORE desc)
//order by S.SCORE Desc, S.ID ASC;
//go