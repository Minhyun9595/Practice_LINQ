using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    //--------------------------------------------------------------------
    // Class: DB
    // Desc : partial을 통해 함수 구현을 하는 부분
    //--------------------------------------------------------------------
    public partial class DB
    {
        //  [테이블 선언]
        IEnumerable<Item> _items;

        //  [bool값 선언]
        bool bCheck = false;

        //  [Item 출력 함수]
        public void Print_Items(IEnumerable<Item> _items, string str)
        {
            if ((str.Contains("Original")))
            {
                Print_ColorString(str, ConsoleColor.Green);
            }
            else
            {
                Print_ColorString(str, ConsoleColor.Yellow);
            }

            if (null == _items || 0 == _items.Count())
            {
                Console.WriteLine("선택된 Item이 없습니다.");
            }
            else
            {
                foreach (Item _item in _items)
                    _item.Print();
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //  [User 출력 함수]
        public void Print_Users(IEnumerable<User> _users, string str)
        {
            if ((str.Contains("Original")))
            {
                Print_ColorString(str, ConsoleColor.Green);
            }
            else
            {
                Print_ColorString(str, ConsoleColor.Yellow);
            }

            if (null == _users || 0 == _users.Count())
            {
                Console.WriteLine("선택된 User가 없습니다.");
            }
            else
            {
                foreach (User _user in _users)
                    _user.Print();
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Print_Boolean(string str, bool bState)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{str} : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{bState.ToString()} \n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }


        //  [원본의 IEnumerable 반환]
        public IEnumerable<T> Get_Original<T>(T[] _item)
        {
            return from item in _item
                   select item;
        }

        //  [str을 color색으로 출력한 뒤 white로 색을 변경한다]
        public void Print_ColorString(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"─  {str}  ─".PadLeft(21 - (21 - str.Length >> 1)));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
