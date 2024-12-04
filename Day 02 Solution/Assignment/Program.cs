using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number);
            #endregion
            #region 2- Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //         string str = "abc"; // string contains non numeric characters
            //         int number;
            //         int result = Convert.ToInt32(str);

            //         /*
            //          * Unhandled exception. System.FormatException: The input string 'abc' was not in a correct format.
            //at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
            //at System.Convert.ToInt32(String value)
            //at Assignment.Program.Main(String[] args) in D:\Route\Route Assignment 11\Day 02 Solution\Assignment\Program.cs:line 15
            //          */
            //         // this exeption occures due to the string contains non numeric characters
            #endregion
            #region 3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 5.5f;
            //float num2 = 6.6f;
            //float result = num1 + num2;
            //Console.WriteLine(result);
            //// the result will be 12.1 
            //// the result will be a floating point number
            #endregion
            #region 4- Write C# program that Extract a substring from a given string.
            //string str = "Hello World";
            //string subStr = str.Substring(3 , 2); // the substring will be "lo"
            //Console.WriteLine(subStr);
            #endregion
            #region 5- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 5;
            //int y;
            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //// the value of x will be 6
            //// the value of y will be 5
            #endregion
            #region 6- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point P1 = new Point();
            //P1.X = 5;
            //P1.Y = 10;
            //Point P2 = new Point();
            //P2.X = 15;
            //P2.Y = 20;
            //Console.Out.WriteLine("P1.X = " + P1.X + " P1.Y = " + P1.Y);
            //Console.Out.WriteLine("P2.X = " + P2.X + " P2.Y = " + P2.Y);

            //P2 = P1;
            //P1.X = 50;
            //P1.Y = 100;
            //Console.Out.WriteLine("P1.X = " + P1.X + " P1.Y = " + P1.Y);
            //Console.Out.WriteLine("P2.X = " + P2.X + " P2.Y = " + P2.Y);

            //P2.X = 500;
            //P2.Y = 1000;
            //Console.Out.WriteLine("P1.X = " + P1.X + " P1.Y = " + P1.Y);
            //Console.Out.WriteLine("P2.X = " + P2.X + " P2.Y = " + P2.Y);

            // the output will be:
            // P1.X = 5 P1.Y = 10
            // P2.X = 15 P2.Y = 20
            // P1.X = 50 P1.Y = 100
            // P2.X = 50 P2.Y = 100
            // P1.X = 500 P1.Y = 1000
            // P2.X = 500 P2.Y = 1000
            #endregion
            #region 7- Write C# program that take two string variables and print them as one variable 
            //string s1 = "Hello";
            //string s2 = "World!";
            //Console.WriteLine($"{s1} {s2}");
            #endregion
            #region 8- Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //double principal = 1000;
            //double rate = 5;
            //double time = 2;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest);
            #endregion
            #region 9- Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)
            //double weight = 70;
            //double height = 1.75;
            //double BMI = weight / (height * height);
            //Console.WriteLine(BMI);
            #endregion
            #region 10- Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //int temperature = 20;
            //string result = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(result);
            #endregion
            #region 11- (Write a program that takes the date from the user and displays it in various formats using string interpolation.Ex:Today’s date : 20 , 11 , 2001 Today's date : 20 / 11 / 2001 Today's date : 20 – 11 – 2001)
            //Console.WriteLine("Enter the date: ");
            //DateTime date = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine($"Today's date : {date.Day} , {date.Month} , {date.Year}");
            //Console.WriteLine($"Today's date : {date.Day} / {date.Month} / {date.Year}");
            //Console.WriteLine($"Today's date : {date.Day} - {date.Month} - {date.Year}");
            #endregion
            #region Question 12
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            // output will be: The event is on 06/14/2024
            // answer will be : C
            #endregion
            #region Question 13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            // output will be 1 because of !false = true and true = 1
            // answer will be : f
            #endregion
            #region Question 14
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            // output will be 6 1
            // so the answer will be : d
            // why because divining int by int the result will be int and the remainder will be the remainder of the division
            #endregion
            #region Question 15
            int num = 1, z = 5;

            if (!(num <= 0))
                // 7 7
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            // the output will be 7 7

            // the answer will be : d
            // why because the condition will be true as (num <= 0) -> False and !(False) -> True
            // ++num will be 2 and z++ will be 5 so 2 + 5 = 7
            // now z = 6 so ++z = 7
            #endregion


        }
    }
}
