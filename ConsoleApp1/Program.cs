using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
                   // Creating and set the empty value in array >
                   START:
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
            Console.Write("Please enter the ODD VALUE which you want to see diamond ( row, column) ! row=column ! : ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
            Console.WriteLine($"Your diamond consist of {Number} -> ROW and {Number} -> COLUMN !");
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
            string[,] array = new string[Number, Number];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = " ";
                }
            }
                    // Algorythmic Process >
            for (int i = 0; i <= array.GetLength(0)/2; i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j==Number/2)
                    {
                        array[i, j - i] = "*";
                        array[i, j + i] = "*";
                    }
                }
            }
            for (int i = (Number / 2)-1; i >=0; i--)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j==Number/2)
                    {
                        array[(array.GetLength(0) - 1) - i, j - i] = "*";
                        array[(array.GetLength(0) - 1) - i, j + i] = "*";
                    }
                }
            }
                    // Array output >
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            CONTINUE:
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
            Console.Write("Please make decision which if you want to create another diamond choose 1 ( mean : YES ) , otherwise 2 ( mean : NOT ) : ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n-------------------------\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your answer is YES !");
                    Console.ResetColor();
                    goto START;
                case "2":
                    Console.WriteLine("\n-------------------------\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your answer is NOT.Thanks for all !");
                    Console.ResetColor();
                    Console.WriteLine("\n-------------------------\n");
                    break;
                default:
                    Console.WriteLine("\n-------------------------\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your answer {choice} is invalid. Please choose valid option !");
                    Console.ResetColor();
                    goto CONTINUE;
            }
            Console.ReadKey();
        }
    }
}
