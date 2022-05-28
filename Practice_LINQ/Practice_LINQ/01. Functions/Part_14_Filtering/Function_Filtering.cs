using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [필터링]
        public void Function_Filtering()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 필터링");
            //  ## 

            Print_Items(Get_Original(items), "[Original - items]");

            //  [Where]  : 조건이 true인 값을 선택
            _items = items.Where(x => (1 < x.code));
            Print_Items(_items, "[Where]  : 조건이 true인 값을 선택");
        }
    }
}
