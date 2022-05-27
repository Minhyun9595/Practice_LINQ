using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [데이터 분할]
        public void Function_Segmentation()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 데이터 분할");

            Print_Items(Get_Original(items), "[Original - items]");

            //  [Skip]  : 건너뛰고 인덱스부터 시작
            _items = items.Skip(2);
            Print_Items(_items, "[Skip (2)]  : 건너뛰고 인덱스부터 시작");

            //  [SkipWhile]  : 순서대로 정렬됐을 때, true일 동안 스킵
            //  {1, 2, 3, 4}에서 3보다 작을 동안 스킵 3,4만 선택된다.
            _items = items.OrderBy(x => x.code).SkipWhile(x => (3 > x.code));
            Print_Items(_items, "[SkipWhile (3 > x.code)]  : 순서대로 정렬됐을 때, true일 동안 스킵");

            //  [Take]  : 앞에서부터 개수만큼 가져오기
            _items = items.Take(2);
            Print_Items(_items, "[Take (2)]  : 앞에서부터 개수만큼 가져오기");

            //  [TakeWhile]  : 순서대로 정렬됐을 때, true일 동안 가져오기
            //  {1, 2, 3, 4}에서 3보다 작을 동안 가져오기 1, 2만 선택된다.
            _items = items.OrderBy(x => x.code).TakeWhile(x => (3 > x.code));
            Print_Items(_items, "[TakeWhile (3 > x.code)]  : 순서대로 정렬됐을 때, true일 동안 가져오기");

        }
    }
}
