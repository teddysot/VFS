using System;

namespace CollatZ_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CollatZ Conjecture");
            //Console.Write("Input Number: ");

            //int x = int.Parse(Console.ReadLine());

            int n = 1000000;
            int x = 0;
            int sequence = 0;

            int count = 0;
            int count2 = 0;
            while(n != 1)
            {
                x = n;
                while(x != 1)
                {
                    count++;
                    if(x % 2 == 0)
                    {
                        x = x / 2;
                    }

                    if (x == 1)
                    {
                        break;
                    }

                    if(x % 2 == 1)
                    {
                        x = (3 * x) + 1;
                    }
                }

                if(count > count2)
                {
                    count2 = count;
                    x = n;
                    sequence = x;
                }
                n--;
            }

            Console.WriteLine("Count: {0}", sequence);
            Console.WriteLine("Count: {0}", count2);

            Console.ReadLine();
        }
    }
}
