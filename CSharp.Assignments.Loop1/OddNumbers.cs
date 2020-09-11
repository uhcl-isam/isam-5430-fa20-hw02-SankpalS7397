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
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int currentNum = 1;
            while (currentNum <= n)
            {
                Console.WriteLine(currentNum);
                currentNum++;
            }
        }
    }
}

    

        
    

