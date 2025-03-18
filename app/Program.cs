using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = Path.Combine("..", "SmallTestList.txt");

        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}