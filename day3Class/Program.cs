using System;
using System.Collections.Generic;

namespace day3Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Bolt");
            Console.WriteLine($"number of items in collection: {names.Count}");
            names.Add("Inga");
            names.Add("Prorochka");
            names.Add("Rei");
            names.Add("Yolsa");

            var angryRandom = new Random();
            Console.WriteLine($"Home theory will tell us {names[angryRandom.Next(0, names.Count)]}");
        }


        private static int GetNumberFromUser(string question)
        {
            Console.WriteLine(question);
            bool isResultValid = false;
            int result = 0;
            while (!isResultValid)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    isResultValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid number");
                }
            }

            return result;
        }

        private static void DiceThrower()
        {
            var random = new Random();
            var sum = 0;
            var diceNumber = GetNumberFromUser("how many dices?");
            var maxSide = GetNumberFromUser("Which dice is it?");
            for (int i = 0; i < diceNumber; i++)
            {
                int rndNumber = random.Next(1, maxSide + 1);
                Console.WriteLine(rndNumber);
                sum += rndNumber;
            }
            Console.WriteLine($"Total: {sum}");
        }
        private static void SimpleArray()
        {
            var array = new int[] { 4, 5, 123, 124, 66, 21, 2 };


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} - {array[i]}");
            }
        }

        private static void SimpleForeach()
        {
            var names = new string[] { "Bolt", "Inga", "Prorochka", "Rei", "Yolsa" };

            Console.WriteLine("Raschet Pezdukov:");
            foreach (var name in names)
            {
                Console.WriteLine(name);

                if (name.Length > 4)
                {
                    Console.WriteLine("AHAAA!");
                    break;
                }
            }
            Console.WriteLine("Raschet okonchen");
        }
    }
}
