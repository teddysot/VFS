using System;

namespace W4_Exercise1
{
    enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static int largestInt(int[] a)
        {
            int largest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
            }

            return largest;
        }

        static int smallestInt(int[] a)
        {
            int smallest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] < smallest)
                {
                    smallest = a[i];
                }
            }

            return smallest;
        }

        static int powerInt(int a, int b)
        {
            int result = a;
            for(int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        static int compareInt(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            else if(b > a)
            {
                return b;
            }
            else
            {
                return a;
            }  
        }
        static void Main(string[] args)
        {
            int[] aNum = new int[5] { 3, 2, 3, 4, 6 };

            Console.WriteLine("Largest Number of an array is {0}", largestInt(aNum));
            Console.WriteLine("Smallest Number of an array is {0}", smallestInt(aNum));
            Console.WriteLine("Power Number of {0} and {1} is {2}", smallestInt(aNum), largestInt(aNum), powerInt(smallestInt(aNum), largestInt(aNum)));

            Console.ReadLine();
        }
    }
}
