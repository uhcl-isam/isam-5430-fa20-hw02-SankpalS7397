﻿using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Drivers are concerned with the mileage their automobiles get.
    /// One driver has kept track of several tankfuls of gasoline by 
    /// recording the miles driven and gallons used for each tankful. 
    /// Develop a C# app that will input the miles driven and gallons
    /// used (both as integers) for each tankful. The app should calculate
    /// and display the miles per gallon obtained for each tankful and 
    /// display the combined miles per gallon obtained for all tankfuls
    /// up to this point. All averaging calculations should produce
    /// floating-point results. Display the miles per gallons on one line
    /// and the total miles per gallons on another, both rounded to the
    /// nearest hundredth, immediately after each input. Use the Console
    /// class’s ReadLine method and sentinel-controlled iteration
    /// (e.g. when miles driven are negative, the loop ends) to
    /// obtain the data from the user.
    /// </summary>
    public class GasMileage
    {
        public static void Main()
        {
            {
                // prompt user for non-negative miles and obtain the input from user
                // codes go here.
                float totalMiles = 0;
                float totalGallons = 0;
                while (true)
                {
                    Console.WriteLine("Enter the miles driven: ");
                    int miles = int.Parse(Console.ReadLine());
                    if (miles < 0)
                    {
                        break;
                    }
                    totalMiles = totalMiles + miles;
                    Console.WriteLine("Enter the gallons used: ");
                    int gallons = int.Parse(Console.ReadLine());

                    totalGallons = totalGallons + gallons;
                    float mpg = (float)miles / gallons;
                    float totalMPG = totalMiles / totalGallons;
                    if (mpg < 0)
                    {
                        return;
                    }


                    Console.WriteLine("MPG this tankful: {0:F2}", mpg);
                    Console.WriteLine("Total MPG: {0:F2}", totalMPG);
                }
                Console.ReadLine();
            }
        }

    }
}


               

