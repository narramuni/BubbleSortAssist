using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {
            string[] students = new string[5];

            students[0] = "SaiPavan";
            students[1] = "Pavan";
            students[2] = "Arif";
            students[3] = "Varun";
            students[4] = "Guru";


            bool flag = true;
            string temp;
            int numLength = students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }


            foreach (string s in students)
            {
                Console.WriteLine(s);
                Console.ReadLine(); 
            }


            //BubbleSort(student);

            //Console.WriteLine("Sorted List of Students:");
            //foreach (var stud in student)
            //{
            //    Console.WriteLine($"Name: {student}");
            //}

            //static void BubbleSort(string[] arr)
            //{
            //    int n = arr.Length;
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            // Compare student names
            //            if (string.Compare(arr[j], arr[j + 1]) > 0)
            //            {
            //                // Swap the students if they are out of order
            //                string temp = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = temp;
            //            }
            //        }


            //    }


            //    }

        }
    }
}
