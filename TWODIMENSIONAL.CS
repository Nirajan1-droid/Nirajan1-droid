using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++) //SIZE OF THE OUTER ARRAY
            {
                for (int j = 0; j < 3; j++) //SIZE OF THE INNER ARRAY
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
 
}
