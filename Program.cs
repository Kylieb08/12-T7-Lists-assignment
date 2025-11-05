using System.Reflection.Emit;

namespace _12_T7_Lists_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Integers();
        }

        public static void Integers()
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();

            int userInput;

            bool done = false;

            for (int i = 0; i < 26; i++)
                numbers.Add(generator.Next(21));

            Console.WriteLine("Here is your list of numbers:");
            for (int i = 0; i < numbers.Count; i++)
                Console.Write($"{numbers[i]}, ");

            Console.WriteLine();
            Console.WriteLine();
            while (!done)
            {
                Console.WriteLine("What would you like to do with the list? (enter the number)");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("1.  Sort the list");
                Console.WriteLine("2.  Make a new list");
                Console.WriteLine("3.  Remove all instances of a number from the list");
                Console.WriteLine("4.  Add a value");
                Console.WriteLine("5.  Count all instances of a value");
                Console.WriteLine("6.  Print the largest value");
                Console.WriteLine("7.  Print the smallest value");
                Console.WriteLine("8.  Print the sum and average of the list");
                Console.WriteLine("9.  Determine the most frequently occuring value");
                Console.WriteLine("10. View the list");
                Console.WriteLine("11. Quit");

                while (!Int32.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 11);
                {
                    Console.WriteLine("Invalid Input. Please Try Again");
                }

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("this is case 1");
                        break;

                    case 2:
                        Console.WriteLine("this is case 2");
                        break;

                    case 3:
                        Console.WriteLine("this is case 3");
                        break;

                    case 4:
                        Console.WriteLine("this is case 4");
                        break;

                    case 5:
                        Console.WriteLine("this is case 5");
                        break;

                    case 6:
                        Console.WriteLine("this is case 6");
                        break;

                    case 7:
                        Console.WriteLine("this is case 7");
                        break;

                    case 8:
                        Console.WriteLine("this is case 8");
                        break;

                    case 9:
                        Console.WriteLine("this is case 9");
                        break;

                    case 10:
                        Console.Clear();
                        Console.WriteLine("Here is your list of numbers:");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write($"{numbers[i]}, ");
                        Console.WriteLine();
                        break;

                    case 11:
                        done = true;
                        Console.WriteLine("Goodbye");
                        break;

                }
            }
        }
    }
}
