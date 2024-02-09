using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] names = new string[3] { "A", "B", "C" };
            for(int i=0;i<a.Length;i++) 
            {
                if(i%2==0)
                {

                Console.WriteLine("a[{1}]",a[i],i);
                }
            }
            foreach (int  element in a)
            {
                if (element % 2 != 0)
                {
                Console.WriteLine(element);
                }
            }
            
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
 
}
