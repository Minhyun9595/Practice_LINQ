using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    public partial class DB
    {
        //  [데이터 결합]
        public void Function_Combine()
        {
            WriteFunctionName.DoAnnouncement("LINQ 함수 - ## 데이터 결합");

            Print_Items(Get_Original<Item>(items), "[Original - items]");

            Print_Users(Get_Original<User>(users), "[Original - users]");

            //  [내부 Join]  : 존재하는 부분만 합하기, 외부Join은 LINQ식을 참고
            string str = "[내부 Join]  : 존재하는 부분만 합하기, 외부Join은 LINQ식을 참고";
            {
                var itemJoins = items.Join(users, item => item.code, user => user.userCode,
                    (item, user) => new
                    {
                        Code = item.code,
                        Username = user.userName,
                        ItemName = item.name
                    });

                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("items.Join(users)", ConsoleColor.Yellow);
                foreach (var itemJoin in itemJoins)
                {
                    Console.WriteLine($"Code : {itemJoin.Code}, ItemName : {itemJoin.ItemName}");
                    foreach (var _UserName in itemJoin.Username)
                        Console.WriteLine(_UserName);
                }
            }

            Print_Users(Get_Original<User>(users2), "[Original - users2]");

            //  [GroupJoin]  : group + join 그룹을 지으면서 합함
            str = "[GroupJoin]  : group + join 그룹을 지으면서 합함";
            {
                var itemGroupJoins = items.GroupJoin(users2, item => item.code, user2 => user2.userCode,
                    (item, users2Collection) => new {
                        Code = item.code,
                        ItemName = item.name,
                        UserNames = users2Collection.Select(user2 => user2.userName)
                    });

                Print_ColorString(str, ConsoleColor.Yellow);
                Print_ColorString("items.Join(users2)", ConsoleColor.Yellow);
                foreach (var itemGroupJoin in itemGroupJoins)
                {
                    Console.WriteLine($"Code : {itemGroupJoin.Code}, ItemName : {itemGroupJoin.ItemName}");
                    foreach (var _UserName in itemGroupJoin.UserNames)
                        Console.WriteLine(_UserName);
                }
            }
        }
    }
}
