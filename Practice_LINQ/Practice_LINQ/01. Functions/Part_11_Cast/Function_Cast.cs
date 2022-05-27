using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Practice_LINQ
{
    public partial class DB
    {
        //  [형식 변환]
        public void Function_Cast()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 형식 변환");
            //  ## 

            Print_Items(Get_Original(items), "[Original - items]");

            //  [AsEnumerable]  : IEnumerable 형식으로 변환
            {
                IEnumerable<Item> _EnumerableItems = items.AsEnumerable();

                Print_ColorString("IEnumerable<Item> _EnumerableItems = items.AsEnumerable();", ConsoleColor.Green);
                Print_Items(_EnumerableItems, "[AsEnumerable]  : IEnumerable 형식으로 변환");
            }

            //  [AsQueryable]  : IQueryable 형식으로 변환
            //  IEnumerable은 인터페이스가 IEnumerable뿐이지만, IQueryable이 IEnumerable을 포함한다.
            //  LINQ를 SQL과 연동하는데 사용한다.
            {
                IQueryable<Item> _QueryableItems = items.AsQueryable();

                Print_ColorString("[AsQueryable]  : IQueryable 형식으로 변환", ConsoleColor.Yellow);
                Print_ColorString("LINQ를 SQL과 연동하는데 사용한다.", ConsoleColor.Yellow);
                Print_ColorString("IQueryable<Item> _QueryableItems = items.AsQueryable();", ConsoleColor.Green);
                foreach (var _item in _QueryableItems)
                    _item.Print();
            }
            Console.WriteLine("");

            //  [Cast]  : ArrayList에서 그 타입만 추출, 실패 시 해당 인덱스에 InvalidCastException 에러 발생

            {
                ArrayList itemArray = new ArrayList { 1, "2", 3, 4, 5 };
                IEnumerable<int> _castItem = itemArray.Cast<int>();

                Print_ColorString("[Cast]  : ArrayList에서 그 타입만 추출,", ConsoleColor.Yellow);
                Print_ColorString(" 실패 시 해당 인덱스에 InvalidCastException 에러 발생", ConsoleColor.Yellow);
                Print_ColorString("ArrayList itemArray = new ArrayList { 1, '2', 3, 4, 5 };", ConsoleColor.Green);

                try
                {
                    foreach (var _item in _castItem)
                    {
                        Console.WriteLine(_item);
                    }
                }
                catch
                {
                    Console.WriteLine("예외 발생");
                }
            }
            Console.WriteLine("");

            //  [OfType]  : ArrayList에서 그 타입만 추출, 실패는 건너뛰고 2와 4가 나온다.
            {
                ArrayList itemArray = new ArrayList { 1, "2", 3, "4", 5 };
                IEnumerable<string> _ofTypeItems = itemArray.OfType<string>();

                Print_ColorString("[OfType]  : ArrayList에서 그 타입만 추출, 실패는 건너뛰고 2와 4가 나온다.", ConsoleColor.Yellow);
                Print_ColorString("ArrayList itemArray = new ArrayList { 1, '2', 3, '4', 5 };", ConsoleColor.Green);
                foreach (string _item in _ofTypeItems)
                    Console.WriteLine(_item);
            }
            Console.WriteLine("");

            //  [ToArray]  : 배열로 변환한다.
            {
                List<string> strs = new List<string>() { "zz", "ss" };
                string[] _arrStrs = strs.ToArray();

                Print_ColorString("[ToArray]  : 배열로 변환한다.", ConsoleColor.Yellow);
                Print_ColorString("List<string> strs = new List<string>() { 'zz', 'ss' };", ConsoleColor.Green);
                foreach (string _item in _arrStrs)
                    Console.WriteLine(_item);
            }
            Console.WriteLine("");

            //  [ToList]  : 리스트로 변환한다.
            {
                List<Item> _itemList = items.ToList();

                Print_ColorString("[ToList]  : 리스트로 변환한다.", ConsoleColor.Yellow);
                Print_ColorString("List<Item> _itemList = items.ToList();", ConsoleColor.Green);
                foreach (Item _item in _itemList)
                    _item.Print();
            }
            Console.WriteLine("");

            //  [ToDictionary]  : 지정된 키로 딕셔너리를 만든다.
            {
                Dictionary<int, Item> itemDic = items.ToDictionary(x => x.code);

                Print_ColorString("[ToDictionary]  : 지정된 키로 딕셔너리를 만든다.", ConsoleColor.Yellow);
                Print_ColorString("Dictionary<int, Item> itemDic = items.ToDictionary(x => x.code);", ConsoleColor.Green);
                foreach (KeyValuePair<int, Item> _base in itemDic)
                {
                    Console.WriteLine("Key : {0}", _base.Key);
                    _base.Value.Print();
                }
            }
            Console.WriteLine("");

            //  [ToLookup]  : 키 값 형식을 자유롭게 만든다.
            {
                ILookup<int, string> lookup = items.ToLookup(x => x.code, y => y.name);

                Print_ColorString("[ToLookup]  : 키 값 형식을 자유롭게 만든다.", ConsoleColor.Yellow);
                Print_ColorString("ILookup<int, string> lookup = items.ToLookup(x => x.code, y => y.name);", ConsoleColor.Green);
                foreach (IGrouping<int, string> group in lookup)
                {
                    Console.WriteLine("Key : {0}", group.Key);
                    foreach (string g in group)
                        Console.WriteLine(g);
                }
            }
        }
    }
}
