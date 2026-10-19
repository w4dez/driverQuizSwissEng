using System;

public static class InputHelper
{
    public static string? ReadLineWithTimeout()
    {
        string input = "";
        DateTime end = DateTime.Now.AddSeconds(45);

        while (DateTime.Now < end)
        {
            int remaining = (int)(end - DateTime.Now).TotalSeconds + 1;
            Console.Write($"\rRemaining time: {remaining}s | Your input: {input} ");

            if(Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);

                if(key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return input;
                }

                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input[..^1];
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    input += key.KeyChar;
                }
            }
        }

        Console.WriteLine();
        return null;
    }
}
