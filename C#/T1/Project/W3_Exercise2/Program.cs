using System;

namespace StudentArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSize = 0;

            Console.Write("Enter number of students: ");

            nSize = inputNumber();

            string[] mStudents = new string[nSize];

            for (int i = 0; i < nSize; i++)
            {
                Console.Write("Enter student {0} name: ", i + 1);
                mStudents[i] = Console.ReadLine();
            }

            for (int i = 0; i < nSize; i++)
            {
                Console.WriteLine("Student {0} name is {1}", i + 1, mStudents[i]);
            }

            mStudents = reverseArray(mStudents);
            Console.WriteLine("Reverse array");
            for (int i = 0; i < nSize; i++)
            {
                Console.WriteLine("Student {0} name is {1}", i + 1, mStudents[i]);
            }

            Console.ReadLine();
        }

        static string [] reverseArray(string[] m)
        {
            string[] temp = new string[m.Length];
            int j = m.Length - 1;

            for (int i = 0; i < m.Length; i++)
            {
                temp[i] = m[j];
                j--;
            }

            return temp;
        }

        static int inputNumber()
        {
            int temp = -1;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out temp))
            {
                // Print out error
                Console.WriteLine("[Invalid Input] Not a number");

                Console.Write("Enter number again: ");
                input = Console.ReadLine();
            }

            return temp;
        }
    }
}
