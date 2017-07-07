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

            //int product = 1;
            //    for(int i = 1; i<=10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            //foreach loop - used to iterate over a collection(ex. list or array)
            //You can think of the structure of a foreach loop as the statement:
            //For each item in the collection, do something.


            //string[] firstMonths = { "Jan", "Feb", "Mar", "April", "May", "June" };
            ////always start with the keyword (foreach)
            //foreach(string month in firstMonths )//knows to take temp variable and assign to each element in the array.
            //{
            //    Console.WriteLine(month);
            //}
            //foreach oops allow the temp variable to "know" to assign
            //itself to each element ini the collection (like an array),one at a time
            //foreach loop will always go from beginning to end, no matter what
            //it counts the number of elements in the collection, and runs that many times.

            //create an array of musicians (bands or solo artists)
            //using a foreach loop, print each musicians name

            //string[] musicNames = { "Usher", "JayZ", "Common", "JCole","HTown","Savage"};
            //foreach(string name in musicNames)
            //{
            //    Console.WriteLine(name);
            //}

            //While Loops
            //is used when you want a chunk of code to run only if a condition is met first
            //While something is True, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "JEROME")
            //{
            //    Console.WriteLine("Dude, you are amazing");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while (playAgain.ToLower() == "yes")
            //{
            //    Console.WriteLine("Its a rematch");
            //    Console.WriteLine("Do you want to play again? Yes/No");
            //    playAgain = Console.ReadLine();
            //}

            //Do while loops
            //is similar to a while loop, however the do-while loop is used when....
            //you want a chunk of code to run at least once, but repeat only if the while condition is met.
            //the structure of a do-while loop looks like this:
            //do
            //{
            //do something
            //}
            //while(condition);
            //string playAgain;//declaring the variable
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //pretend the code for the game is here
            //    Console.WriteLine("Great Game");
            //    Console.WriteLine("Do you want to play again? Yes/No");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain.ToLower() == "yes");

            //Ask the user for the class(in school) that they would like to add to their Gpa calculation.
            //Ask the user for the letter grade for the class(no + or -)
            //Ask the user if they have another class they would like to add to their GPA
            //using a do-while loop, repeat the code if the user says yes

            //string classOne;
            //do
            //{
            //    Console.WriteLine("Would you like to add a class for your GPA calculation? yes/no");
            //    classOne = Console.ReadLine().ToLower();
            //    string classTwo;
            //    Console.WriteLine("What is the name of the class?");
            //    classTwo = Console.ReadLine();
            //    string grades;
            //    Console.WriteLine("What is the grade for that class?");
            //    grades = Console.ReadLine();
            //}
            //while(classOne == "yes");

            //Nested loops
            //a loop inside another loop
            //the inner loop is executed more than the outer loop
            //real life example - clock

            //create a nested loop structure that prints:
            //1234
            //1234

            //for(int rows = 1; rows<=2; rows++)//example
            //{
            //    for(int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a triangle
            //outer loop will go line by line
            //inner loop will go over elements in the line
            //results should look like:
            //1
            //12
            //123
            //1234......

            //for(int rows = 1; rows <= 4; rows++)
            //{
            //    for (int columns = 1; columns <= rows; columns++ )
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}


            //Homework

            //int[] luckyNumbers = { 7, 21, 82, 54, 90 };
            //foreach(int numbers in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is: " + (numbers));
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i * j + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Movies

















        }
    }
}
