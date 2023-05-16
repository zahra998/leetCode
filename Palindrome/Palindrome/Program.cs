namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 2003;
            string str;
            //str = num.ToString();

            Console.WriteLine("Enter number : ");
            str = Console.ReadLine();

            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            //Console.WriteLine($"Actual String is : {str} \n");
            //Console.WriteLine($"Reversed String is : {reversedStr} ");

            if (str == reversedStr)
            {
                Console.WriteLine(str + " is Palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not Palindrome");
            }
        }
    }
}