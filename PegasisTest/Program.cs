using System;
using System.Collections;

namespace PegasisTest
{
    class Program
    {
        class A
        {
            virtual public void f1()
            {
                
            }
        }
        
        class B: A
        {
            override public void f1()
            {
                base.f1();
            }
        }

        static public bool EqualCount(IEnumerable enumerable1,
            IEnumerable enumerable2, out int count)
        {
            bool flag = false;
            count = 0;
            IEnumerator it1 = enumerable1.GetEnumerator();
            IEnumerator it2 = enumerable2.GetEnumerator();
            bool r1 = it1.MoveNext();
            bool r2 = it2.MoveNext();
            if ((r1 == false) || (r2 == false))
            {
                return flag;
            }
            if (Object.ReferenceEquals(it1.GetType(), it2.GetType()) == false)
            {
                return flag;
            }
            ArrayList array1 = new ArrayList();
            array1.Add(it1.Current);
            ArrayList array2 = new ArrayList();
            array2.Add(it2.Current);
            while (it1.MoveNext() != false)
            {
                array1.Add(it1.Current);
            }
            while (it2.MoveNext() != false)
            {
                array2.Add(it1.Current);
            }
            foreach (var obj in array1)
            {
                if (array2.Contains(obj))
                {
                    flag = true;
                    count++;
                }
            }
            return flag;
        }

       
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}
