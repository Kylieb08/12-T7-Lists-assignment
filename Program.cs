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

            int userInput, removeNum, addNum, countNum, count = 0, max, min;

            bool doneInt = false;

            for (int i = 0; i < 26; i++)
                numbers.Add(generator.Next(21));

            Console.WriteLine("Here is your list of numbers:");
            for (int i = 0; i < numbers.Count; i++)
                Console.Write($"{numbers[i]}, ");

            Console.WriteLine();
            Console.WriteLine();
            while (!doneInt)
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
                        Console.Clear();
                        numbers.Sort();
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write($"{numbers[i]}, ");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        numbers.Clear();
                        for (int i = 0; i < 26; i++)
                            numbers.Add(generator.Next(21));
                        Console.WriteLine("Here is your new list of numbers:");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write($"{numbers[i]}, ");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Which number would you like to remove?");

                        while (!Int32.TryParse(Console.ReadLine(), out removeNum) || removeNum < 0)
                            Console.WriteLine("Invalid Input. Please Try Again");
                        
                        while (numbers.Contains(removeNum))
                            numbers.Remove(removeNum);

                        Console.WriteLine("Here is your new list of numbers:");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write($"{numbers[i]}, ");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Which number would you like to add? (positive integers only)");
                        while (!Int32.TryParse(Console.ReadLine(), out addNum) || addNum < 0)
                            Console.WriteLine("Invalid Input. Please Try Again");
                        numbers.Add(addNum);
                        Console.WriteLine($"{ addNum} has been added to the list");
                        Console.WriteLine("Here is your new list");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write($"{numbers[i]}, ");
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Which value in the list would you like to count?");
                        while (!Int32.TryParse(Console.ReadLine(), out countNum) || countNum < 0)
                            Console.WriteLine("Invalid Input. Please Try Again");

                        if (!numbers.Contains(countNum))
                            Console.WriteLine($"Your list does not contain {countNum}");

                        else
                        {
                            for (int i = 0; i < numbers.Count;i++)
                            {
                                if (numbers[i] == countNum)
                                    count++;
                            }
                            Console.WriteLine();
                            Console.WriteLine($"The number {countNum} appears {count} time(s) in your list");
                        }
                        Console.WriteLine();
                            break;

                    case 6:
                        Console.Clear();
                        max = numbers.Max();
                        Console.WriteLine($"The largest value in this list is {max}");
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Clear();
                        min = numbers.Min();
                        Console.WriteLine($"The smallest value in this list is {min}");
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("this is case 8");
                        break;

                    case 9:
                        Console.Clear();
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
                        Console.Clear();
                        doneInt = true;
                        Console.WriteLine("Goodbye");
                        break;

                }
            }
        }
    }
}
