using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [생성]
        public void Function_Create()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 생성");

            //  [DefaultIfEmpty]  : 빈 컬렉션은 기본 하나를 생성
            //  Null Reference를 방지해서 외부 Join에서도 사용한다.
            string str = "[DefaultIfEmpty]  : 빈 컬렉션은 기본 하나를 생성";
            {
                List<Item> itemEmpty = new List<Item>();
                Item defaultItem = new Item(-1, "NONE");

                Print_ColorString(str, ConsoleColor.Yellow);
                foreach (Item item in itemEmpty.DefaultIfEmpty(defaultItem))
                    item.Print();
            }
            Console.WriteLine("");

            //  [Empty]  : 빈 IEnumerable을 생성
            str = "[Empty]  : 빈 IEnumerable을 생성";
            {
                IEnumerable<Item> emptyItem = Enumerable.Empty<Item>();

                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("IEnumerable<Item> emptyItem = Enumerable.Empty<Item>()", ConsoleColor.Yellow);
                foreach (Item item in emptyItem)
                    item.Print();

            }
            Console.WriteLine("");

            //  [Range]  : 정수 범위의 숫자들을 생성, 시작 숫자부터 개수까지
            //  (3, 10) 3부터 12까지 나온다.
            str = "[Range]  : 정수 범위의 숫자들을 생성, 시작 숫자부터 개수까지";
            {
                IEnumerable<int> ranges = Enumerable.Range(3, 10).Select(x => x * x);

                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("IEnumerable<int> ranges = Enumerable.Range(3, 10).Select(x => x * x)", ConsoleColor.Yellow);
                foreach (int range in ranges)
                    Console.WriteLine(range);
            }
            Console.WriteLine("");

            //  [Repeat]  : 반복하여 생성
            str = "[Repeat]  : 반복하여 생성";
            {
                IEnumerable<string> repeats = Enumerable.Repeat("Hello", 10);

                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("Enumerable.Repeat(Hello, 10)", ConsoleColor.Yellow);
                foreach (string repeat in repeats)
                    Console.WriteLine(repeat);
            }
        }
    }
}
