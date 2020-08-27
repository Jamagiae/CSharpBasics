using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyString();

            Console.ReadLine();
        }

        static void MyString()
        {
            Console.Write("What year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string mystring1 = "this is my first string ";
            string theTruth = "the last thing a ninja would do is admit to being a ninja ";
            string theLie = "I an not a ninja. ";
            Console.WriteLine("This is my string. " + mystring1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
               Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
               Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");

        }
    }
}
