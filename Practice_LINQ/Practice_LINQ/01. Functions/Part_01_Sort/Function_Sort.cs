using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [정렬]
        public void Function_Sort()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 정렬");

            Print_Items(Get_Original(items), "[Original - items]");

            //  [OrderBy]  : 오름차순 정렬
            _items = items.OrderBy(x => x.code);
            Print_Items(_items, "[OrderBy]  : 오름차순 정렬");

            //  [OrderByDescending]  : 내림차순 정렬
            _items = items.OrderByDescending(x => x.code);
            Print_Items(_items, "[OrderByDescending]  : 내림차순 정렬");

            //  [ThenBy]  : 정렬된 것 뒤에 오름차순으로 2차 정렬
            _items = items5.OrderBy(x => x.code).ThenBy(x => x.name);
            Print_Items(_items, "[ThenBy]  : 정렬된 것 뒤에 오름차순으로 2차 정렬");

            //  [ThenByDescending]  : 정렬된 것 뒤에 내림차순으로 2차 정렬
            _items = items5.OrderBy(x => x.code).ThenByDescending(x => x.name);
            Print_Items(_items, "[ThenByDescending]  : 정렬된 것 뒤에 내림차순으로 2차 정렬");

            //  [Reverse]  : 순서 뒤집기
            _items = items.Reverse();
            Print_Items(_items, "[Reverse]  : 순서 뒤집기");
        }
    }
}
