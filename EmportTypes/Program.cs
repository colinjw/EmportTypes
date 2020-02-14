using System;
using System.Collections.Generic;
using System.IO;

namespace EmportTypes
{
    class Program
    {
        static string data = "C:/cwscripts/C#/ExternalData/Data.txt";
        static string[] content;
        static List<string> choiceList = new List<string>();
        static int chosenNum;
        static void WriteOut(string message)
        {
            if (message.EndsWith(";soldier"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string newMessage = message.Remove(message.Length - 8);
                Console.WriteLine(newMessage);
                Console.ResetColor();
            }
            else if (message.EndsWith(";imp"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string newMessage = message.Remove(message.Length - 4);
                Console.WriteLine(newMessage);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(message);
            }
        }
        static void ChoiceBuilder(string choice)
        {
            if (choice.Contains("Choice?"))
            {
                string message = choice.Remove(0, 8);
                WriteOut(message);
                var input = Console.ReadLine();
                if (int.TryParse(input, out chosenNum))
                {
                    switch (chosenNum)
                    {
                        case 1:

                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    WriteOut("You must enter a number");
                }

            }
        }

        static void ReadFile()
        {
            content = File.ReadAllLines(data);
            foreach (string line in content)
            {
                if (line.StartsWith("Choice"))
                {
                    choiceList.Add(line);
                }
                else
                {
                    WriteOut(line);
                }
                //WriteOut(line);
            }
        }

        static void Main(string[] args)
        {
            ReadFile();
            Console.Read();
        }
    }
}
