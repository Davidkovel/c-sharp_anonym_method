using System;
using System.Text;
using DelegateClass;

namespace Delegate
{

    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                var rgbColors = new Dictionary<string, (int, int, int)>
                {
                    { "Red", (255, 0, 0) },
                    { "Orange", (255, 165, 0) },
                    { "Yellow", (255, 255, 0) },
                    { "Green", (0, 255, 0) },
                    { "Blue", (0, 0, 255) },
                };

                Func<string, (int, int, int)> rbg = delegate (string s)
                {
                    if (rgbColors.ContainsKey(s))
                    {
                        return rgbColors[s];
                    }
                    else
                    {
                        throw new Exception($"There is no such color {s}");
                    }
                };


                var color = "Red";
                var rgb2 = rbg(color);
                Console.WriteLine($"The rgb {color} color is {rgb2}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {

                Console.WriteLine("\nProgram execution completed.");
            }
        }
    }
}

/*
The rgb Red color is (255, 0, 0)

Program execution completed.

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (process 10604) exited with code 0 (0x0).
Press any key to close this window . . .

*/