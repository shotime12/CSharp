using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create  a loop that prints all values from 1-255
            for(var i=1; i<=255; i++){
                Console.WriteLine(i);
            }
            int multipler = 50;
            string stars = new string ('*', multipler);
            Console.WriteLine(stars);
            //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for(var i=1; i<=100; i++){
                if(i%3==0 || i%5==0){
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(stars);
            //Modify the previous loop to print "Fizz" for multiples f 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiplesof both 3 and 5
            for(var i=0; i<=30; i++){
                 if(i%15==0){
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if(i%3==0){
                    Console.WriteLine("Fizz");
                    continue;
                }
                 if(i%5==0){
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(stars);
            //Last step without using modulus
            var count3 = 0;
            var count5 = 0;
            var count15 = 0;
            for(var i=1; i<=30; i++){
                count3++;
                count5++;
                count15++;
                if(count3==3 && count5==5){
                    count3=0;
                    count5=0;
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (count3==3){
                    count3 = 0;
                    Console.WriteLine("Fizz");
                    continue;
                }
                 if(count5==5){
                    Console.WriteLine("Buzz");
                    count5 = 0;
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(stars);
            //Generate 10 random values and output the respective word, in relation to step three, for the generated values
            Random rand = new Random();
            for(int i=0; i<10; i++){
                int x = rand.Next(1,100);
                if(x%15==0){
                    Console.WriteLine(x + " FizzBuzz");
                    continue;
                }
                 if(x%3==0){
                    
                    Console.WriteLine(x +" Fizz");
                    continue;
                }
                 if(x%5==0){
                    
                    Console.WriteLine(x+" Buzz");
                    continue;
                }
                Console.WriteLine(x);
            }            
        }
    }
}
