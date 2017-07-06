using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //when would you use a loop
            //why would you use a loop
            //nested loops
            //infinite loops
            //keywords break and continue

            //For Loop it can be used for counting and....
            //iterating through an array (or other collection type)
            //Looks like this
            //for(intializer; condition; updater)
            //{
            //do something
            //}

            //for(int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);//counts down from 15 to 1 
            //}
            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);//counts up from 50 to 100
            //}

            //string greeting = "My name is little Bill";
            //The .Split() method takes a string and turns it into an array of smaller..
            //strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);//prints out the words
            //}
            //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //Using a For loop, print the elements of the days array.

            //Start with the string "Once upon a time" and crate an array called...
            //storyWords using the Split Method, Reverse the order of the elements in..
            //the array and using a for loop, print each word.

            //Add the product (multiplication) of 1 through 10 using a for loop
            //Print product to screen.

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //    for(int i = 0; i<=2; i++)
            //    {
            //    Console.WriteLine(days[i]);
            //    }


            //string message = "Once upon a time";
            //string[] storyWords = message.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            int product = 1;
                for(int i = 1; i<=10; i++)
            {
                product = product * i;
            }
            Console.WriteLine(product);



            
            
            

        }
    }
}
