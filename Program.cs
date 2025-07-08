namespace Assignment_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to find the sum of first 10 natural numbers.
            //Expected Output :
            //The first 10 natural number is :
            //1 2 3 4 5 6 7 8 9 10
            //The Sum is : 55.

            int sum = 0;
            Console.WriteLine("Name a Counting Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= choice; i++)
            {
               sum += i;
            }

            Console.WriteLine("The first " + choice + " natural numbers are : ");
            for (int i = 1; i <= choice ; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nThe Sum is : " + sum);
        }
    }
}
