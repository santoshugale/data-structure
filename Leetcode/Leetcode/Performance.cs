using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Leetcode
{
    public class Performance
    {
        public static void Test()
        {
            List<AObject> list = new List<AObject>();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(new AObject
                {
                    IntProp = i,
                    IntProp1 = i + 1,
                    IntProp2 = i + 2,
                    StringProp1 = i.ToString(),
                    StringProp2 = (i + 2).ToString()
                });
            }
            Stopwatch stopwatch = new Stopwatch();
            int dummy = 0;
            foreach (var item in list)
            {
                dummy += item.IntProp;
            }
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            int dummy1 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                AObject item = list[i];
                dummy1 += item.IntProp;
            }
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.Elapsed);
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
        }
    }
    public class AObject
    {
        public int IntProp { get; set; }
        public int IntProp1 { get; set; }
        public int IntProp2 { get; set; }
        public string StringProp1 { get; set; }
        public string StringProp2 { get; set; }
    }
}
