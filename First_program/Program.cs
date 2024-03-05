using System;

namespace hello
{
    class progrem
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number : ");
            String n = Console.ReadLine();
            int f = 1;
            for (int i = 1; i <= int.Parse(n); i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
            Console.ReadLine(); 

        }
    }
}