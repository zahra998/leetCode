using System.Collections.Generic;

namespace maegeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 1, 3, 5, 9, 11 };
            int[] second = { 2, 5, 6, 11, };


            int[] result = new int[first.Length + second.Length];
            int i = 0, j = 0, k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    result[k++] = first[i++];
                }
                else
                {
                    result[k++] = second[j++];
                }
            }

            if (i < first.Length)
            {
                for (int a = i; a < first.Length; a++)
                    result[k] = first[a];
            }

            if (j < second.Length)
            {
                for (int a = j; a < second.Length; a++)
                    result[k++] = second[a];
            }

            foreach (int a in result)
                Console.Write(a + " ");

            Console.WriteLine();
        }
    }
}