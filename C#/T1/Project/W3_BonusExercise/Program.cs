using System;

namespace StudentArray3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int nSize = inputNumberOfStudent();

            string[] mStudents = new string[nSize];

            mStudents = inputArray(mStudents);

            printArray(mStudents);

            mStudents = reverseArray(mStudents);

            printArray(mStudents);

            mStudents = reverseSelfArray(mStudents);

            printArray(mStudents);

            Console.ReadLine();
        }

        static string[] inputArray(string[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("Enter student {0} name: ", i + 1);
                m[i] = Console.ReadLine();
            }

            return m;
        }

        static void printArray(string[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine("Student {0} name is {1}", i + 1, m[i]);
            }
        }

        static string[] reverseArray(string[] m)
        {
            Console.WriteLine("Reverse array using temp array");

            string[] temp = new string[m.Length];
            int j = m.Length - 1;

            for (int i = 0; i < m.Length; i++)
            {
                temp[i] = m[j];
                j--;
            }

            return temp;
        }

        static string[] reverseSelfArray(string[] m)
        {
            Console.WriteLine("Reverse array by self array");

            // Swapping idea
            for (int i = 0; i < m.Length / 2; i++)
            {
                string temp = m[i];
                m[i] = m[m.Length - i - 1];
                m[m.Length - i - 1] = temp;
            }

            return m;
        }

        static int inputNumberOfStudent()
        {
            Console.Write("Enter number of students: ");

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
