using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Date = DateTime.Today.ToString("D");
            string input;
            Introduction();
            while (true)
            {
                input = Console.ReadLine();
                if (input == "start" || input == "Start") break;
            }
            using (StreamWriter Journal = new StreamWriter(Date + ".txt", true))
            {
                Console.Clear();
                Console.WriteLine("Start Writing");
                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "stop" || input == "Stop") break;
                    Journal.WriteLine(input);
                    Journal.Flush();
                }
            }
            ByeScreen();


        }
        static void Introduction()
        {
            Console.WriteLine("Today we going to make a journal. You will be the author.");
            Console.WriteLine("Type 'start' to begin writing");
            Console.WriteLine("Type 'stop' to end writing and save the txt file with today's date");
        }
        static void ByeScreen()
        {
            Console.Clear();
            Console.WriteLine("Good page for the journal!");
            Console.WriteLine("If you want to restart the programm and write additional information to today's file push any key");
            Console.ReadKey();
        }
    }
}
