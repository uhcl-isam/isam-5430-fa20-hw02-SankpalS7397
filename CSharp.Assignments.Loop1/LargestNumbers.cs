using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    public class LargestNumbers
    {
        public static void Main()
        {
            int counter = 1;
            int number = 0;
            int largest = 0;
            int largest2 = 0;
            // get first number and assign it to variable largest

            while (counter <= 10)
            {
                //3 10 2 5 8

                Console.Write($"Enter a {counter} number: ");
                number = Convert.ToInt32(Console.ReadLine()); //8
                if (counter == 1)
                {
                    largest = number; //largest = 3
                    largest2 = number;
                }
                else
                {
                    if (number < largest && number > largest2)
                    {
                        largest2 = number; //largest2 = 8
                    }
                    else if (largest == number)
                    {
                        largest2 = number;
                    }
                    else if (number > largest)
                    {
                        largest2 = largest; // 
                        largest = number; // largest = 10
                    }
                    else if (counter == 2 && number < largest && number < largest2)
                    {
                        largest2 = number;
                    }
                }
                counter++;
            }
            Console.Write($"{largest} {largest2}");
        }
    }
    }

