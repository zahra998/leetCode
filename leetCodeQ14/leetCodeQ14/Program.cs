namespace leetCodeQ14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = "flower";
            String str2 = "flow";

           int[,] l = new int[str1.Length, str2.Length]; // String 1 length and string 2      length storing it in a 2-dimensional array
            int lcs = -1;
            string substr = string.Empty;
            int end = -1;

            for (int i = 0; i < str1.Length; i++) // Looping based on string1 length 
            {
                for (int j = 0; j < str2.Length; j++) // Looping based on string2 Length
                {
                    if (str1[i] == str2[j]) // if match found 
                    {
                        if (i == 0 || j == 0)  // i is first element or j is first elemnt then array [i,j] = 1
                        {
                            l[i, j] = 1;
                        }
                        else
                        {
                            l[i, j] = l[i - 1, j - 1] + 1; // fetch the upper value and increment by 1 
                        }

                        if (l[i, j] > lcs)
                        {
                            lcs = l[i, j]; // store lcs value - how many time lcs is found 
                            end = i; // index on longest continuous string
                        }

                    }
                    else // if match not found store zero initialze the array value by zero
                    {
                        l[i, j] = 0;
                    }
                }
            }
        }
    }
}