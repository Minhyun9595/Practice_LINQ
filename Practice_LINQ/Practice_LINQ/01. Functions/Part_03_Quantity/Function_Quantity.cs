using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [수량 연산]
        public void Function_Quantity()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 수량 연산");

            Print_Items(Get_Original(items), "[Original - items]");

            //  [All]  : 모두 조건을 만족시켜야 true 반환
            bCheck = items.All(x => (0 < x.code));
            Print_Boolean("모든 원소가 0보다 큰가?", bCheck);

            //  [Any]  : 하나라도 true라면 true 반환
            bCheck = items.Any(x => (3 < x.code));
            Print_Boolean("하나라도 3보다 큰가?", bCheck);

            //  [Contains]  : 포함 여부, ItemComparer : IEqualityComparer<T> 클래스 구현
            bCheck = items.Contains(new Item(3, "바나나"), new ItemComparer());
            Print_Boolean("Item(3, 바나나) 라는 아이템이 포함되어 있는가?", bCheck);
        }
    }
}
