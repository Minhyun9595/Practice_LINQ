using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [집계]
        public void Function_Math()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 집계");

            Print_Items(Get_Original(items), "[Original - items]");
            //  [Aggregate]  : 누적 계산
            {
                int total = items.Aggregate(0, (_total, next) => _total += next.code);

                Print_ColorString("[Aggregate]  : 누적 계산", ConsoleColor.Yellow);
                Console.WriteLine("total : {0}", total);
            }
            Console.WriteLine("");

            //  [Average]  : 평균
            {
                double avg = items.Average(x => x.code);

                Print_ColorString("[Average]  : 평균", ConsoleColor.Yellow);
                Console.WriteLine("avg : {0}", avg);
            }
            Console.WriteLine("");

            //  [Count]  : 개수
            {
                int count = items.Count();

                Print_ColorString("[Count]  : 개수", ConsoleColor.Yellow);
                Console.WriteLine("Count : {0}", count);
            }
            Console.WriteLine("");

            //  [LongCount]  : long 형식 개수
            {
                long longCount = items.LongCount();

                Print_ColorString("[LongCount]  : long 형식 개수", ConsoleColor.Yellow);
                Console.WriteLine("LongCount : {0}", longCount);
            }
            Console.WriteLine("");

            //  [Max]  : 최댓 값
            {
                int max = items.Max(x => x.code);

                Print_ColorString("[Max]  : 최댓 값", ConsoleColor.Yellow);
                Console.WriteLine("Max : {0}", max);
            }
            Console.WriteLine("");

            //  [Min]  : 최솟 값
            {
                int min = items.Min(x => x.code);

                Print_ColorString("[Min]  : 최솟 값", ConsoleColor.Yellow);
                Console.WriteLine("Min : {0}", min);
            }
            Console.WriteLine("");

            //  [Sum]  : 합
            {
                int sum = items.Sum(x => x.code);

                Print_ColorString("[Sum]  : 합", ConsoleColor.Yellow);
                Console.WriteLine("Sum : {0}", sum);
            }
        }
    }
}
