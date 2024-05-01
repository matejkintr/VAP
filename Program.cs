using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Zadejte retezec cisel oddelenych carkou: ");
                    string userInput = Console.ReadLine();
                    string[] znakyVyrazu = userInput.Split(',');
                    int[] cisla = new int[znakyVyrazu.Length];
                    for (int i = 0; i < znakyVyrazu.Length; i++)
                    {
                        cisla[i] = int.Parse(znakyVyrazu[i]);
                    }
                    if (cisla.Length > 0)
                    {
                        int minNumber = cisla.Min();
                        int maxNumber = cisla.Max();

                        Console.WriteLine($"Nejmensi cislo: {minNumber}");
                        Console.WriteLine($"Nejvetsi cislo: {maxNumber}");
                    }
                    int currentStreak = 1;
                    int maxStreak = 1;

                    for (int i = 1; i < cisla.Length; i++)
                    {
                        if (cisla[i] > cisla[i - 1])
                        {
                            currentStreak++;
                            if (currentStreak > maxStreak)
                            {
                                maxStreak = currentStreak;
                            }
                        }
                        else
                        {
                            currentStreak = 1;
                        }
                    }

                    Console.WriteLine($"Nejdelsi vzestupny interval: {maxStreak}");
                    Console.WriteLine("Chcete pokracovat? Y/N");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        break;
                    }
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Chyba: Vstup neni platne cele cislo.");
                while (true)
                {
                    Console.Write("Zadejte retezec cisel oddelenych carkou: ");
                    string userInput = Console.ReadLine();
                    string[] znakyVyrazu = userInput.Split(',');
                    int[] cisla = new int[znakyVyrazu.Length];
                    for (int i = 0; i < znakyVyrazu.Length; i++)
                    {
                        cisla[i] = int.Parse(znakyVyrazu[i]);
                    }
                    if (cisla.Length > 0)
                    {
                        int minNumber = cisla.Min();
                        int maxNumber = cisla.Max();

                        Console.WriteLine($"Nejmensi cislo: {minNumber}");
                        Console.WriteLine($"Nejvetsi cislo: {maxNumber}");
                    }
                    int currentStreak = 1;
                    int maxStreak = 1;

                    for (int i = 1; i < cisla.Length; i++)
                    {
                        if (cisla[i] > cisla[i - 1])
                        {
                            currentStreak++;
                            if (currentStreak > maxStreak)
                            {
                                maxStreak = currentStreak;
                            }
                        }
                        else
                        {
                            currentStreak = 1;
                        }
                    }

                    Console.WriteLine($"Nejdelsi vzestupny interval: {maxStreak}");
                    Console.WriteLine("Chcete pokracovat? Y/N");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        break;
                    }
                }
            }
        }
    }
}
