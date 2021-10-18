using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic type
            //MyList<string,object> strList = new MyList<string,object>();
            //strList.Add("Kamal");
            //strList.Add("Gunel");
            //strList.Add("Altun");
            //MyList<int,IComparable> intList = new MyList<int, IComparable>();
            //intList.Add(5);
            //intList.Add(15);
            //intList.Add(25);
            //MyList<Person,object> people = new MyList<Person,object>();
            //people.Add(new Person());
            //people.Add(new Person());
            //people.Add(new Person());
            #endregion

            #region Collection
            #region ArrayList
            //ArrayList list = new ArrayList();
            //list.Add(5);
            //list.Add("test");
            //list.Add(true);
            #endregion
            #region List
            //List<int> iList = new List<int>();
            //iList.Add(5);
            //iList.Add(15);
            //iList.Add(25);
            //Console.WriteLine(iList.Contains(5));
            #endregion
            #region LinkedList
            //LinkedList<int> iLinkedList = new LinkedList<int>();
            #endregion
            #region Dictionary
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran", "+994512373434");
            //phones.Add("Kamal", "+994558421455");
            //phones.Add("Gunel", "+994559567868");
            ////Console.WriteLine(phones["Kamal"]);
            //foreach (var item in phones.Keys)
            //{
            //    Console.WriteLine($"{item} - {phones[item]}");
            //}
            #endregion
            #endregion
        }
    }

    #region Generic
    class MyList<T,U>
       // where T:struct
       //where T:class
       //where T:new()
       //where T:IComparable
       //where T:Person
        where T:U
    {
        private T[] arr;
        public MyList()
        {
            arr = new T[0];
        }

        public void Add(T str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Person
    {

    }
    #endregion
}
