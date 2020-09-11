using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0. The app will print out n*n integers with the following pattern; for n=3, the app will print out 0, 0, 1,    0, 2, 1,    3, 2, 1 on separate lines (spaces added to show the 3 groups).
        /// </summary>
        public static void Main()
        {
            // Write your codes here
            int number = 0;
            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());


            int SaveNum = number;
            int OuterLoop = 1;

            while (OuterLoop <= number)
            {
                int InnerLoop = 1;
                int CopyOuterLoop = OuterLoop;

                while (InnerLoop <= number)
                {

                    if (InnerLoop >= SaveNum)
                    {
                        Console.Write($"{CopyOuterLoop}, ");
                        CopyOuterLoop--;
                    }
                    else
                    {
                        Console.Write($"0, ");
                    }
                    InnerLoop++;

                }
                Console.WriteLine();
                OuterLoop++;
                SaveNum--;
            }
        }
    }
}
    

