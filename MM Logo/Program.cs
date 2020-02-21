namespace MM_Logo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTop(n);
            PrintBot(n);
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
