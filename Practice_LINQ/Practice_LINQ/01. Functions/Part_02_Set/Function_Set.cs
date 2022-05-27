using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [집합]
        public void Function_Set()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 집합");

            Print_Items(Get_Original(items4), "[Original - items4]");

            //  [Distinct]  : 중복 제거, Item : System.IEquatable<Item> 인터페이스 구현
            _items = items4.Distinct();
            Print_Items(_items, "[Distinct]  : 중복 제거, Item : System.IEquatable<Item> 인터페이스 구현");

            Print_Items(Get_Original(items), "[Original - items]");
            Print_Items(Get_Original(items2), "[Original - items2]");

            //  [Except]  : 차집합 items - items2
            _items = items.Except(items2);
            Print_Items(_items, "[Except]  : 차집합 items - items2");

            //  [Intersect]  : 교집합 items ∩ items2, 두 집합에 모두 포함된 Data만 선택
            _items = items.Intersect(items2);
            Print_Items(_items, "[Intersect]  : 교집합 items ∩ items2, 두 집합에 모두 포함된 Data만 선택");

            //  [Union]  : 합집합 items ∪ items2
            _items = items.Union(items2);
            Print_Items(_items, "[Union]  : 합집합 items ∪ items2");
        }
    }
}
