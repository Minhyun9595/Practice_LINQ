using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [연결]
        public void Function_Connect()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 연결");

            //  [Concat]  : 두 개를 하나로 연결 (더하기)
            {
                IEnumerable<string> strs = items.Select(x => x.name).Concat(items2.Select(x => x.name));

                foreach (string str in strs)
                    Console.WriteLine(str);
            }
        }
    }
}
