using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> programlamaDilleri = new MyDictionary<int, string>();
            programlamaDilleri.Add(1, "C#");
            programlamaDilleri.Add(2, "Java");
            programlamaDilleri.Add(3, "C++");
            programlamaDilleri.Add(4, "Python");


            programlamaDilleri.List();
            Console.WriteLine($"Listelenen Kayıt Sayısı : {programlamaDilleri.Length}");

        }
    }

    public class MyDictionary<Key, Value>
    {
        (Key, Value)[] myDictionarys;
        public MyDictionary()
        {
            myDictionarys = new (Key, Value)[0];
        }

        public void Add(Key key, Value value)
        {
            (Key, Value)[] tempDictionarys = myDictionarys;
            myDictionarys = new (Key, Value)[myDictionarys.Length + 1];
            for (int i = 0; i < tempDictionarys.Length; i++)
            {
                myDictionarys[i] = tempDictionarys[i];
            }
            myDictionarys[myDictionarys.Length - 1] = (key, value);
        }

        public int Length
        {
            get 
            {
                return myDictionarys.Length;            
            }
        }

        public void List()
        {
            for (int i = 0; i < myDictionarys.Length; i++)
            {
                Console.WriteLine(string.Format("Key : {0}, Value : {1}", myDictionarys[i].Item1, myDictionarys[i].Item2));
            }
        }
    }
}
