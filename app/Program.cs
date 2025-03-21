using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string path = Path.Combine("..", "LargeTestList.txt");

        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            try
            {
                var numbers = content.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(double.Parse)
                                     .ToList();

                double sum = numbers.Sum();
                double average = numbers.Average();
                double max = numbers.Max();
                double min = numbers.Min();

                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Gjennomsnitt: {average}");
                Console.WriteLine($"Største verdi: {max}");
                Console.WriteLine($"Minste verdi: {min}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Filen inneholder ugyldige tall.");
            }
        }
        else
        {
            Console.WriteLine("Filen ble ikke funnet.");
        }
    }
}