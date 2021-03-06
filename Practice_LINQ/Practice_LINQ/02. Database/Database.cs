using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LINQ
{
    //--------------------------------------------------------------------
    // Class: Item Data
    // Desc : Distinct를 사용하기 위해 IEquatable를 상속받는다.
    //--------------------------------------------------------------------
    public class Item : System.IEquatable<Item>
    {
        public int code;
        public string name;

        public Item(int code, string name)
        {
            this.code = code;
            this.name = name;
        }

        public void Print()
        {
            Console.WriteLine("code : {0}, name : {1}", code, name);
        }

        //  [IEquatable<T> 인터페이스 추상 함수] 
        public bool Equals(Item other)
        {
            //Check whether the compared object is null.
            if (ReferenceEquals(other, null)) return false;
            //Check whether the compared object references the same data.
            if (ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal.
            return (code.Equals(other.code) && name.Equals(other.name));
        }

        //  If Equals() returns true for a pair of objects
        //  then GetHashCode() must return the same value for these objects.
        public override int GetHashCode()
        {
            //Get hash code for the Name field if it is not null.
            int hashProductName = (null == name) ? 0 : name.GetHashCode();
            //Get hash code for the Code field.
            int hashProductCode = code.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }
    }

    //--------------------------------------------------------------------
    // Class: User Data
    // Desc : 
    //--------------------------------------------------------------------
    public class User
    {
        public int userCode;
        public string userName;
        public void Print()
        {
            Console.WriteLine("code : {0}, name : {1}", userCode, userName);
        }
    }

    //--------------------------------------------------------------------
    // Class: School Data
    // Desc : 성적을 배열로 가진 클래스
    //--------------------------------------------------------------------
    public class School
    {
        public string name;
        public int[] scores;
    }

    //--------------------------------------------------------------------
    // Class: DB
    // Desc : partial을 통해 변수 선언을 하는 부분
    //--------------------------------------------------------------------
    public partial class DB
    {

        Item[] items = new Item[]
        {
            new Item(2, "당근"),
            new Item(1, "사과"),
            new Item(3, "바나나"),
            new Item(4, "오렌지"),
        };

        Item[] items2 = new Item[]
        {
            new Item(4, "오렌지"),
            new Item(1, "사과"),
            new Item(3, "바나나"),
            new Item(5, "포도"),
        };

        Item[] items3 = new Item[]
        {
            new Item(1, "사과"),
            new Item(2, "당근"),
            new Item(3, "바나나"),
            new Item(4, "오렌지"),
        };

        Item[] items4 = new Item[]
        {
            new Item(2, "당근"),
            new Item(2, "당근"),
            new Item(1, "사과"),
            new Item(3, "바나나"),
            new Item(3, "바나나"),
            new Item(4, "오렌지"),
        };

        Item[] items5 = new Item[]
        {
            new Item(2, "감자"),
            new Item(2, "당근"),
            new Item(1, "사과"),
            new Item(3, "멜론"),
            new Item(3, "바나나"),
            new Item(4, "오렌지"),
        };

        User[] users = new User[]
        {
            new User() { userCode = 2, userName = "A" },
            new User() { userCode = 1, userName = "B" },
            new User() { userCode = 3, userName = "C" },
            new User() { userCode = 5, userName = "D" },
        };

        User[] users2 = new User[]
        {
            new User() { userCode = 2, userName = "A"},
            new User() { userCode = 2, userName = "A+"},
            new User() { userCode = 1, userName = "B"},
            new User() { userCode = 3, userName = "C"},
            new User() { userCode = 3, userName = "C+"},
            new User() { userCode = 5, userName = "D"}
        };

        School[] schools =
        {
            new School(){ name = "A반", scores = new int[] { 70, 60, 30, 80} },
            new School(){ name = "B반", scores = new int[] { 20, 65, 35, 85} }
        };
    }



    //--------------------------------------------------------------------
    // Class: WriteFunctionName
    // Desc : 전역에서 사용할 수 있는 문자 알림 기능을 가진 함수
    //--------------------------------------------------------------------
    public static class WriteFunctionName
    {
        //  [전역 알림 함수]
        public static void DoAnnouncement(string str)
        {
            Console.WriteLine("────────────");
            Console.WriteLine("   " + str);
            Console.WriteLine("────────────");
        }
    }


    //--------------------------------------------------------------------
    // Class: ItemComparer
    // Desc : Contain 메서드를 사용하기 위해 IEqualityComparer<T>를 상속받아서정의한다. 
    //--------------------------------------------------------------------
    public class ItemComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item lhs, Item rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(null, rhs))
                return false; 

            return (lhs.code == rhs.code && lhs.name == rhs.name);
        }

        public int GetHashCode(Item item)
        {
            if (ReferenceEquals(item, null))
                return 0;

            int hashProductName = (null == item.name) ? 0 : item.name.GetHashCode();
            int hashProductCode = item.code.GetHashCode();

            return hashProductName ^ hashProductCode;
        }
    }
}
