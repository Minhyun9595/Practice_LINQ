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

            //  [Aggregate]  : 누적 계산
            {
                int total = items.Aggregate(0, (_total, next) => _total += next.code);
                Console.WriteLine("total : {0}", total);
            }

            //  [Average]  : 평균
            {
                double avg = items.Average(x => x.code);
            }

            //  [Count]  : 개수
            {
                int count = items.Count();
            }

            //  [LongCount]  : long 형식 개수
            {
                long longCount = items.LongCount();
            }

            //  [Max]  : 최댓 값
            {
                int max = items.Max(x => x.code);
            }

            //  [Min]  : 최솟 값
            {
                int min = items.Min(x => x.code);
            }

            //  [Sum]  : 합
            {
                int sum = items.Sum(x => x.code);
            }
        }
    }
}
