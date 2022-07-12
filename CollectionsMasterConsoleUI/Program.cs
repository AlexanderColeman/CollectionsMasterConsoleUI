using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            int[] ints = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(ints);

            //TODO: Print the first number of the array

            Console.WriteLine(ints[0]);

            //TODO: Print the last number of the array
            //

            Console.WriteLine(ints[ints.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(ints);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(ints);
            NumberPrinter(ints);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(ints);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(ints);
            NumberPrinter(ints);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(ints);

            NumberPrinter(ints);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> intList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("------------------Print capacity------------------");
            Console.WriteLine(intList.Capacity);
            Console.WriteLine("------------------Print capacity------------------");
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);

            //TODO: Print the new capacity
            NumberPrinter(intList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            NumberChecker(intList);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(intList);
            NumberPrinter(intList);

            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var convertedToArray = intList.ToArray();

            //TODO: Clear the list
            intList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 3 == 0)
                {
                    ints[i] = 0;
                    
                }
            }


        }

        private static void OddKiller(List<int> intList)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] % 2 == 1)
                {
                    intList.Remove(intList[i]);
                    i--;
                }
            }

        }

        private static void NumberChecker(List<int> intList)
        {
            Console.WriteLine("What number will you search for in the number list?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int output))
            {
                if (intList.Contains(output))
                {
                    Console.WriteLine($"{output} is in the list");
                }
                else
                {
                    Console.WriteLine($"{output} was not in the list");
                }
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numberedArray)
        {
            Random rng = new Random();

            for (int i = 0; i < numberedArray.Length; i++)
            {
                numberedArray[i] = rng.Next(0, 51);
            }

        }


        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                Console.WriteLine(array[i]);
            }

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
