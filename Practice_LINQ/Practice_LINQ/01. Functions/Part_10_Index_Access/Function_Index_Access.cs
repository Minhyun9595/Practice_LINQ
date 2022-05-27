using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [요소 접근]
        public void Function_Index_Access()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 요소 접근");

            Print_Items(Get_Original(items), "[Original - items]");

            string str;
            //  [ElementAt]  : 해당 인덱스를 가져옴
            //  범위를 벗어나면 OutOfRangeException이 호출된다.
            str = "[ElementAt]  : 해당 인덱스를 가져옴";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Item _item;
                try
                {
                    _item = items.ElementAt(3);
                    
                    _item.Print();

                    // _item = items.ElementAt(5);  /* (OutOfRangeException) */
                }
                catch
                {
                    Console.WriteLine("범위 벗어남");
                }
            }
            Console.WriteLine("");

            //  [ElementAtOrDefault]  : 인덱스를 가져올 수 없으면 null 대입
            str = "[ElementAtOrDefault]  : 인덱스를 가져올 수 없으면 null 대입";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("Item _item = items.ElementAtOrDefault(5);", ConsoleColor.Green);

                try
                {
                    Item _item = items.ElementAtOrDefault(5);
                    if(null != _item)
                    {
                        _item.Print();
                    }
                    else
                    {
                        Console.WriteLine("null == _item");
                    }
                    
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("ArgumentNullException 예외 발생");
                }
            }
            Console.WriteLine("");

            //  [First]  : 첫 번째를 가져옴, 조건에 맞는 첫 번째를 가져옴
            str = "[First]  : 첫 번째를 가져옴, 조건에 맞는 첫 번째를 가져옴";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("Item _item = items.First(x => (2 < x.code));", ConsoleColor.Green);
                // Item _item = items.First();
                Item _item = items.First(x => (2 < x.code));
                _item?.Print();
            }
            Console.WriteLine("");

            //  [FirstOrDefault]  : 첫 번째를 가져옴, 조건에 맞는 첫 번째를 가져옴, 인덱스를 가져올 수 없으면 null 대입
            str = "[FirstOrDefault]  : 첫 번째를 가져옴, 조건에 맞는 첫 번째를 가져옴";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString(", 인덱스를 가져올 수 없으면 null 대입", ConsoleColor.Green);
                Item _item = items.FirstOrDefault();
                // _item = items.FirstOrDefault(x => (2 < x.code));
                _item?.Print();
            }
            Console.WriteLine("");

            //  [Last]  : 마지막을 가져옴, 조건에 맞는 마지막을 가져옴
            str = "[Last]  : 마지막을 가져옴, 조건에 맞는 마지막을 가져옴";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("Item _item = items.Last();", ConsoleColor.Green);
                Item _item = items.Last();
                // _item = items.Last(x => (2 < x.code));
                _item?.Print();
            }
            Console.WriteLine("");

            //  [LastOrDefault]  : 마지막을 가져옴, 조건에 맞는 마지막을 가져옴, 인덱스를 가져올 수 없으면 null 대입
            str = "[LastOrDefault]  : 마지막을 가져옴, 조건에 맞는 마지막을 가져옴";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString(", 인덱스를 가져올 수 없으면 null 대입", ConsoleColor.Yellow);
                Print_ColorString("Item _item = items.LastOrDefault();", ConsoleColor.Green);
                Item _item = items.LastOrDefault();
                // _item = items.LastOrDefault(x => (2 < x.code));
                _item?.Print();
            }
            Console.WriteLine("");

            //  [Single]  : 단 하나만 조건을 만족시켜야 에러가 뜨지 않는다.
            //  두 개 이상이 조건을 만족하면 InvalidOperationException 에러가 발생한다.
            str = "[Single]  : 단 하나만 조건을 만족시켜야 에러가 뜨지 않는다.";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("Item _item = items.Single(x => (3 < x.code));", ConsoleColor.Green);
                Item _item = items.Single(x => (3 < x.code));
                _item?.Print();
            }
            Console.WriteLine("");

            //  [SingleOrDefault]  : 단 하나만 조건을 만족시켜야 에러가 뜨지 않는다.
            //  두 개 이상이 조건을 만족하면 InvalidOperationException 에러가 발생한다.
            //  인덱스를 가져올 수 없으면 null 대입 
            str = "[SingleOrDefault]  : 단 하나만 조건을 만족시켜야 에러가 뜨지 않는다.";
            {
                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("두 개 이상이 조건을 만족하면 InvalidOperationException 에러가 발생한다.", ConsoleColor.Yellow);
                Print_ColorString("인덱스를 가져올 수 없으면 null 대입 ", ConsoleColor.Yellow);
                Print_ColorString("Item _item = items.Single(x => (5 < x.code));", ConsoleColor.Green);
                try
                {
                    Item _item = items.Single(x => (5 < x.code));
                    _item?.Print();
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("InvalidOperationException");
                }
            }
        }
    }
}
