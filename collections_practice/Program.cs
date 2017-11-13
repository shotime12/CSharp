using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num ={0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] values = {true, false, true, false, true, false, true, false, true, false};

            foreach(var value in values){
                Console.WriteLine(value);
            }

            int [,] multiplication_table = new int[10,10]
                {
                    {1, 2, 3, 4, 5, 6, 7, 8,9, 10},
                    {2, 4, 6, 8, 10, 12, 14, 16, 18, 20},
                    {3, 6, 9, 12, 15, 18, 21, 24, 27, 30},
                    {4, 8, 12, 16, 20, 24, 28, 32, 36, 40},
                    {5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
                    {6, 12, 18, 24, 30, 36, 42, 48, 54, 60},
                    {7, 14, 21, 28, 35, 42, 49, 56, 63, 70},
                    {8, 16, 24, 32, 40, 48, 56, 64, 72, 80},
                    {9, 18, 27, 36, 45, 54, 63, 72, 81, 90},
                    {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}
                };
            Console.WriteLine(multiplication_table[0,0]);
            

            //Create a List of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> ice_cream_flavors =  new List<string>();
            ice_cream_flavors.Add("Strawberry");
            ice_cream_flavors.Add("Vanilla");
            ice_cream_flavors.Add("Chocolate");
            ice_cream_flavors.Add("Cookies and Cream");
            ice_cream_flavors.Add("Rocky Road");
            Console.WriteLine("There are " + ice_cream_flavors.Count + " flavors in this list. ");
            Console.WriteLine(ice_cream_flavors[2]);
            ice_cream_flavors.RemoveAt(2);
            Console.WriteLine("There are " + ice_cream_flavors.Count + " flavors in this list. ");
            
            //Create a Dictionary that will store both string keys as well as string values
           
            Random rand = new Random();
            
            Dictionary<string,string> user = new Dictionary<string,string>();
            foreach(var name in names){
                user.Add(name, ice_cream_flavors[rand.Next(0,4)]);
            }
            /*foreach(var entry in user){
                entry.Value = "test";
                Console.WriteLine(entry.Value);
                
                //user[entry] = ice_cream_flavors[rand.Next(0,4)];
            }
            */
             //Console.WriteLine(rand.Next(0,4));
             //Console.WriteLine(rand.Next(0,4));

            foreach(KeyValuePair<string,string> entry in user){
                Console.WriteLine(entry.Key + " - " +  entry.Value);
            }        
        }
    }
}
