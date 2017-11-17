using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    class Program
    {
        public static void randomArray(){
            Random rand = new Random();
            int[] randArray = new int[10];
            for(int i=0;i<10;i++){
                randArray[i] = rand.Next(5,25);
                Console.WriteLine(randArray[i]);
            }
            int min = randArray[0];
            int max = randArray[0];
            int sum = 0;

            foreach(var num in randArray ){
                if(num < min){
                    min = num;
                }
                if(num > max){
                    max = num;
                }
                sum += num;
                
            }
            Console.WriteLine("Min value is: " + min);
            Console.WriteLine("Max value is: " + max);
            Console.WriteLine("Sum is: " + sum);
        }
       
        public static string TossCoin(){
            //Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            int coin = rand.Next(0,2);
            string str_coin;
            if(coin == 0){
                str_coin = "Heads";
            }
            else{
                str_coin = "Tails";
            }
            //Console.WriteLine(str_coin);
            return str_coin;
        }

         public static double TossMultipleCoins(int num){
            int heads = 0;
            int tails = 0;
            double total = 0;
            while(num>0){
                string coin = TossCoin();
                num--;
                //Console.WriteLine(coin);
                if(coin == "Heads"){
                    //Console.WriteLine("its heads");
                    heads++;
                }
                else{
                    tails++;
                }
            }
            //Console.WriteLine($"Heads: {heads}");
            //Console.WriteLine($"Tails: {tails}");
            total = (double)heads/((double)heads+(double)tails);
            return total;
        }

        //Build a funciton Names that reutrns an array of strings
        static public string[] Names(){
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for(int i=0; i<names.Length; i++){
                int rand_position = rand.Next(0,5);
                //Console.WriteLine(i);
                //Console.WriteLine(rand_position);
                string temp;
                temp = names[i];
                names[i] = names[rand_position];
                names[rand_position] = temp;
            }
            foreach(var name in names){
                Console.WriteLine($"Shuffuled Array: {name}");
            }
            var longer_than_5_names = new List<string>();

            foreach(var name in names){
                if(name.Length>5){
                   longer_than_5_names.Add(name);
                }
            }
            //return longer_than_t_names;
            foreach(var name in longer_than_5_names){
                Console.WriteLine(name);
            }
            return names.ToArray();
        }

        static void Main(string[] args)
        {
            //randomArray();
            //TossCoin();
            //Console.WriteLine(TossCoin());
            //TossMultipleCoins(10000);
            Names();
           
        }
    }
}
