using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            int sum = 0;
            foreach(var obj in myList){
                Console.WriteLine(obj);
                if(obj is int){
                sum+= (int)obj;
                }
            }
            Console.WriteLine(sum);
   
        }
    }
}
