using System.Reflection.Emit;

namespace _12_T7_Lists_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            bool done = false;

            while (!done)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? (enter the number)");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1. List of Integers");
                Console.WriteLine("2. List of Strings");
                Console.WriteLine("3. Quit");

                while (!Int32.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 3);
                Console.WriteLine("Invalid input. Please try again");

                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Integers();
                        break;

                    case 2:
                        Console.Clear();
                        Strings();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        done = true;
                        break;
                }
            }
            
        }

        public static void Integers()
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();

            int userInputInt, removeNum, addNum, countNum, count = 0, max, min, sum;
            double average, roundedAverage;

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
                

                Console.WriteLine();

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

                while (!Int32.TryParse(Console.ReadLine(), out userInputInt) || userInputInt < 1 || userInputInt > 11);
                {
                    Console.WriteLine("Invalid Input. Please Try Again");
                }

                switch (userInputInt)
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
                        Console.WriteLine();
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
                            for (int i = 0; i < numbers.Count; i++)
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
                        sum = numbers.Sum();
                        average = numbers.Average();
                        roundedAverage = Math.Round(average, 2);
                        Console.WriteLine($"The sum of this list is {sum}");
                        Console.WriteLine($"The average of this list is {roundedAverage}");
                        Console.WriteLine();
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

        public static void Strings()
        {
            List<string> vegetables = new List<string>();
            vegetables.Add("CARROT");
            vegetables.Add("BEET");
            vegetables.Add("CELERY");
            vegetables.Add("RADISH");
            vegetables.Add("CABBAGE");

            bool doneString = false;

            int userInputStrings;

            string findVegetable, removeVegetable;

            Console.WriteLine("Here is your list of vegetables");
            for (int i = 0; i < vegetables.Count; i++)
                Console.WriteLine($"{i + 1}. {vegetables[i]}");

            while (!doneString)
            {
                Console.WriteLine("What would you like to do? (enter the number)");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1. Remove a vegetable by index");
                Console.WriteLine("2. Remove a vegetable by value");
                Console.WriteLine("3. Search for a vegetable");
                Console.WriteLine("4. Add a vegetable");
                Console.WriteLine("5. Sort the list");
                Console.WriteLine("6. Clear the list");
                Console.WriteLine("7. Quit");

                while (!Int32.TryParse(Console.ReadLine(), out userInputStrings) || userInputStrings < 1 || userInputStrings > 11) ;
                {
                    Console.WriteLine("Invalid Input. Please Try Again");
                }

                switch (userInputStrings)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Which vegetable would you like to remove by index?");
                        
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Which vegetable would you like to remove by value?");
                        removeVegetable = Console.ReadLine().ToUpper();
                        if (vegetables.Contains(removeVegetable))
                        {
                            vegetables.Remove(removeVegetable);
                            Console.WriteLine();
                            Console.WriteLine($"{removeVegetable} has been removed");
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{removeVegetable} is not in this list");
                        }

                        Console.WriteLine("Here is your list of vegetables");
                        for (int i = 0; i < vegetables.Count; i++)
                            Console.WriteLine($"{i + 1}. {vegetables[i]}");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Which vegetable would you like to search for?");
                        findVegetable = Console.ReadLine().ToUpper();
                        if (vegetables.Contains(findVegetable))
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{findVegetable} is in this list");
                            int index = vegetables.IndexOf(findVegetable);
                            Console.WriteLine();
                            Console.WriteLine($"The index of {findVegetable} is {index}");
                        }

                        else
                            Console.WriteLine($"{findVegetable} is not in this list");
                            break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("This is case 4");
                        break;

                    case 5:
                        Console.Clear();
                        vegetables.Sort();
                        Console.WriteLine();
                        Console.WriteLine("Here is your list of vegetables");
                        for (int i = 0; i < vegetables.Count; i++)
                            Console.WriteLine($"{i + 1}. {vegetables[i]}");
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("This is case 6");
                        break;

                    case 7:
                        Console.Clear();
                        doneString = true;
                        Console.WriteLine("Goodbye");
                        break;
                }
            }
        }
    }
}
