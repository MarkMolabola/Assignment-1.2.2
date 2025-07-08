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

            for (int i = 1; i <= 10; i++)
            {
               sum += i;
            }

            Console.WriteLine("The first 10 natural number is :");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n The Sum is : " + sum);
        }
    }
}
