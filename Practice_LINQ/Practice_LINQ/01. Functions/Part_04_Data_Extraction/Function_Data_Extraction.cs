using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [데이터 추출]
        public void Function_Extraction()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 데이터 추출");

            string str = "[Select]  : 값을 추출해 IEnumerable 형식을 만든다.";
            Print_ColorString(str, ConsoleColor.Yellow);
            //  [Select]  : 값을 추출해 IEnumerable 형식을 만든다.
            {
                IEnumerable<int> codes = items.Select(x => x.code);

                foreach (var code in codes)
                    Console.WriteLine($"code : {code.ToString()}");

                var _customItems = items.Select(x => new { Name = x.name, Code = x.code });

                foreach (var custom in _customItems)
                    Console.WriteLine($"code : {custom.Code.ToString()}, name : {custom.Name}");

                Console.WriteLine("\n");
            }


            //  [SelectMany]  : 둘의 모든 조합을 만든다.
            //  {(10, cat), (10, dog), (10, monkey), (20, cat), (20, dog), (20, monkey)}
            str = "[SelectMany]  : 둘의 모든 조합을 만든다.";
            Print_ColorString(str, ConsoleColor.Yellow);
            {
                int[] number = new int[2] { 10, 20 };
                string[] animals = new string[3] { "cat", "dog", "monkey" };

                var maix = number.SelectMany(num => animals, (n, a) => new { n, a });

                foreach (var custom in maix)
                    Console.WriteLine($"number : {custom.n}, animal : {custom.a}");
            }
        }
    }
}
