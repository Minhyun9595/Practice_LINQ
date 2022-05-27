using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practice_LINQ
{
    public partial class DB
    {//  [orderby]
        public void Start_orderby()
        {
            WriteFunctionName.DoAnnouncement("orderby 테스트");

            IEnumerable<Item> _items = from item in items
                                       orderby item.code ascending      // 오름차순
                                                                        // orderby item.code descending  // 내림차순
                                       select item;

            foreach (var _item in _items)
                _item.Print();
        }

        //  [group]
        public void Start_Group()
        {
            WriteFunctionName.DoAnnouncement("group 테스트");

            var _itemGroups = from item in items
                              group item by (2 < item.code) into g
                              select new { GroupKey = g.Key, GroupItem = g };

            foreach (var _itemGroup in _itemGroups)
            {
                Console.WriteLine("2보다 큰가? : {0}", _itemGroup.GroupKey);
                foreach (var item in _itemGroup.GroupItem)
                {
                    item.Print();
                }
            }
        }

        //  [2중 from과 익명 형식]
        public void Start_School()
        {
            WriteFunctionName.DoAnnouncement("2중 from과 익명 형식 테스트");

            var _schools = from classes in schools
                           from scores in classes.scores
                           where (70 > scores)
                           select new { name = classes.name, lowScore = scores };

            foreach (var _school in _schools)
                Console.WriteLine(_school);
        }

        //  [내부 join 활용]
        public void Start_InnerJoin()
        {
            WriteFunctionName.DoAnnouncement("내부 조인 테스트");

            var itemJoins = from user in users
                            join item in items on user.userCode equals item.code
                            select new { Code = item.code, UserName = user.userName, ItemName = item.name };

            foreach (var _itemJoin in itemJoins)
            {
                Console.WriteLine("아이템 출력 >> Code : {0}, UserName : {1}, ItemName : {2}", _itemJoin.Code, _itemJoin.UserName, _itemJoin.ItemName);
            }
        }

        //  [외부 join 활용]
        public void Start_OutterJoin()
        {
            WriteFunctionName.DoAnnouncement("외부 조인 테스트");

            var itemJoins = from item in items
                            join user in users on item.code equals user.userCode into excepts
                            from user in excepts.DefaultIfEmpty(new User() { userName = "None" })
                            select new { Code = item.code, UserName = user.userName, ItemName = item.name };

            foreach (var _itemJoin in itemJoins)
            {
                Console.WriteLine("아이템 출력 >> Code : {0, 3}, UserName : {1, -5}, ItemName : {2, -10}",
                    _itemJoin.Code,
                    _itemJoin.UserName,
                    _itemJoin.ItemName);
            }
        }
    }
}
