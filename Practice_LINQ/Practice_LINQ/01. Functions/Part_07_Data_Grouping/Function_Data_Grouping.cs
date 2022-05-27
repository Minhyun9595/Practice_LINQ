using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [데이터 그룹화]
        public void Function_Grouping()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 데이터 그룹화");

            Print_Items(Get_Original(items4), "[Original - items4]");

            //  [GroupBy]  : 그룹으로 묶기
            string str = "[GroupBy]  : 그룹으로 묶기";
            {
                var itemGroups = items4.GroupBy(item => (2 < item.code), item => item,
                    (key, item) => new { Key = key, Item = item });


                Print_ColorString(str, ConsoleColor.Yellow);
                foreach (var itemGroup in itemGroups)
                {
                    Print_ColorString($"2보다 큰가? : {itemGroup.Key}", ConsoleColor.Green);
                    foreach (var item in itemGroup.Item)
                        item.Print();
                }
            }

            Console.WriteLine("");
            //  [ToLookUp]  : 키를 자동으로 생성해주는 그룹
            str = "[ToLookUp]  : 키를 자동으로 생성해주는 그룹";
            {
                var itemGroups = items4.ToLookup(item => (2 < item.code), item => item);


                Print_ColorString(str, ConsoleColor.Yellow);
                foreach (var itemGroup in itemGroups)
                {
                    Print_ColorString($"2보다 큰가? : {itemGroup.Key}", ConsoleColor.Green);
                    foreach (var item in itemGroup)
                        item.Print();
                }
            }
        }
    }
}
