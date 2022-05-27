using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [동등 여부 평가]
        public void Function_Equality()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 동등 여부 평가");


            Print_Items(Get_Original(items), "[Original - items]");

            Print_Items(Get_Original(items3), "[Original - items3]");

            //  [SequenceEqual]  : 두 집합이 일치하는지 판단하고 bool로 반환해준다.
            //  IEquatable을 추가 해야한다.
            //  IEqualityComparer<T>를 구현해주어야 한다.
            {
                bCheck = items.SequenceEqual(items3);
                Print_ColorString($"SequenceEqual : {bCheck.ToString()}", ConsoleColor.Yellow);
            }
        }
    }
}
