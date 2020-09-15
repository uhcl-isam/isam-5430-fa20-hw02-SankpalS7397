using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            int startNum = 0;
            Console.Error.WriteLine("Enter the starting number");
            startNum = Convert.ToInt32(Console.ReadLine());
            // Codes to enter start
            int endNum = 0;
            Console.Error.WriteLine("Enter the ending number");
            endNum = Convert.ToInt32(Console.ReadLine());
            // Codes to enter end.
            //int number = 0;
            while (startNum <= endNum)
            {
                if (startNum % 2 != 0)
                {
                    Console.WriteLine(startNum);
                    startNum += 2;
                }
                else
                {
                    startNum++;
                }
            }
        }
    }
}
        
    


    

        
    

