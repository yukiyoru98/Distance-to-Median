using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the integer sequence(enter blank to end):");

            string input;
            List<int> arr = new List<int>();

            while (true)
            {
                input = Console.ReadLine();
                if (input == " ")
                {
                    break;
                }

                arr.Add(int.Parse(input));
            }

            //Insertion Sort
            for (int i = 1; i < arr.Count; i++)
            {
                int key = arr[i];
                int cmp_idx = i - 1;
                while (cmp_idx >= 0 && arr[cmp_idx] > key)
                {
                    arr[cmp_idx + 1] = arr[cmp_idx];
                    cmp_idx--;
                }
                arr[cmp_idx + 1] = key;
            }

            int median = arr[arr.Count / 2];
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (Math.Abs(arr[i] - median) < Math.Abs(arr[j] - median))
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                    else if ((Math.Abs(arr[i] - median) == Math.Abs(arr[j] - median)) && (arr[i] < arr[j]))
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            Console.WriteLine("Result:");
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
