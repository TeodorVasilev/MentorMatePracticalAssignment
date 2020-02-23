namespace MM_Logo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                try
                {
                    Console.Write("Enter parameter N: ");

                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Parameter N must be an integer number.");
                    continue;
                }

                if(ValidateN(n))
                {
                    break;
                }

                if (n < 0)
                {
                    Console.WriteLine("Parameter N must be a positive number.");
                }
                else if (n == 0)
                {
                    Console.WriteLine("Parameter N cannot be zero.");
                }
                else if (n % 2 == 0)
                {
                    Console.WriteLine("Parameter N must be an odd number.");
                }
                else if (n < 2)
                {
                    Console.WriteLine("Parameter N must be bigger than 2.");
                }
            }

            PrintTop(n);
            PrintBot(n);
        }

        static bool ValidateN(int n)
        {
            if(n > 0 && n > 2 && n % 2 != 0)
            {
                return true;
            }

            return false;
        }

        static void PrintTop(int n)
        {
            int stars = n;
            int dashes = n;
            int midDashes = n;

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    for (int i = 0; i < dashes; i++)
                    {
                        Console.Write('-');
                    }

                    for (int i = 0; i < stars; i++)
                    {
                        Console.Write('*');
                    }

                    for (int i = 0; i < midDashes; i++)
                    {
                        Console.Write('-');
                    }

                    for (int i = 0; i < stars; i++)
                    {
                        Console.Write('*');
                    }

                    for (int i = 0; i < dashes; i++)
                    {
                        Console.Write('-');
                    }
                }

                Console.WriteLine();

                midDashes -= 2;
                dashes--;
                stars += 2;
            }
        }

        static void PrintBot(int n)
        {
            int stars = n;
            int midStars = n * 2 - 1;
            int dashes = n / 2;
            int midDashes = 1;

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    for (int i = 0; i < dashes; i++)
                    {
                        Console.Write('-');
                    }

                    for (int i = 0; i < stars; i++)
                    {
                        Console.Write('*');
                    }

                    for (int i = 0; i < midDashes; i++)
                    {
                        Console.Write('-');
                    }

                    for (int i = 0; i < midStars; i++)
                    {
                        Console.Write('*');
                    }

                    for (int i = 0; i < midDashes; i++)
                    {
                        Console.Write('-');
                    }

                    for (int i = 0; i < stars; i++)
                    {
                        Console.Write('*');
                    }

                    for (int i = 0; i < dashes; i++)
                    {
                        Console.Write('-');
                    }
                }

                Console.WriteLine();

                dashes--;
                midDashes += 2;
                midStars -= 2;
            }
        }
    }
}
