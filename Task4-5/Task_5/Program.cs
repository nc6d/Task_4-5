using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Path1 = @"C:\Users\nc_6d\source\repos\task4&5\Task4-5\x.txt";
            //string Path2 = @"C:\Users\nc_6d\source\repos\task4&5\Task4-5\y.txt";

            //using StreamReader sr1 = new StreamReader(Path1, Encoding.UTF8);
            //using StreamReader sr2 = new StreamReader(Path2, Encoding.UTF8);

            int[] arr_x = { 43, 56, 15, 65, 34 };
            int[] arr_y = { 5, 6, 7, 8, 9 };
            List<int> arr_z = new List<int>();

            for (int i = 0; i < arr_x.Length; i++)
            {
                if (arr_x[i] % 5 == 0)
                {
                    arr_x[i] -= 8;
                    arr_z.Add(arr_x[i]);
                    
                }
                Console.WriteLine(arr_z);
            }
            

            







        }

    }
}
