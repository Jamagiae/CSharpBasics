using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTypes();
        }

        static void MyString() {

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

        }

        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob the builder";
            bool awesome = true;
            char grade = 'f'; // Chars are singles character. requires single quotes, 'A'
            float altitude = 90.265141f; // float requires 'f' at the end
            double bankBalance = -400000000;
            decimal pi = 3.14159265M; // decimal requires an M at the end

            ///Output
            ///
            Console.WriteLine($"int = {myAge}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {awesome}.");
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"float = {altitude}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"decimal = {pi}.");
         
        }
    }
}
