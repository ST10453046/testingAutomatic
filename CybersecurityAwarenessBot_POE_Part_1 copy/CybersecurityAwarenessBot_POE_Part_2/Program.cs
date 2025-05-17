using CybersecurityAwarenessBot_POE_Part_1;
using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Threading;

class Program
{
    public static void Main()
    {
        Arrays qaList = new Arrays();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
        @"
      ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██╗    ██╗██╗███████╗███████╗
     ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██║    ██║██║██╔════╝██╔════╝
     ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║ █╗ ██║██║███████╗█████╗
     ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║███╗██║██║╚════██║██╔══╝
     ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚███╔███╔╝██║███████║███████╗
      ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝╚══════╝╚══════╝
    ");
        Console.ResetColor();

        PrintSectionHeader("Welcome to the Cybersecurity Assistant!");

        try
        {
            SoundPlayer player = new SoundPlayer("intro.wav");
            player.Play();
        }
        catch (Exception ex)
        {
            ShowMessage("Unable to play intro sound. Reason: " + ex.Message, ConsoleColor.Red);
        }

        string name = "";
        while (true)
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"[a-zA-Z]"))
                break;

            ShowMessage("Invalid name. It must include at least one letter.", ConsoleColor.Red);
        }

        

        ShowMessage($"\nHello, {name}! Here are some questions you can ask me:", ConsoleColor.DarkBlue);
        qaList.DisplaySampleQuestions();

        while (true)
        {
            Console.Write("\nAsk me a cybersecurity question or type 'exit': ");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                ShowMessage("Input cannot be empty. Please enter a question or type 'exit'.", ConsoleColor.Red);
                continue;
            }
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                ShowMessage("\nGoodbye! Stay safe online.", ConsoleColor.Green);
                break;
            }

            if (input.Equals("show more questions", StringComparison.OrdinalIgnoreCase))
            {
                qaList.DisplayAllQuestions();
                continue;
            }
            
            //Get answer
            string answer = qaList.GetAnswer(input);


            
            

           
            TypewriterEffect(answer ?? "I'm not sure about that. Please ask another cybersecurity-related question.");
        }
    }

    static void PrintSectionHeader(string header)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string border = new string('═', header.Length + 6);
        Console.WriteLine($"\n╔{border}╗");
        Console.WriteLine($"║  {header.ToUpper()}  ║");
        Console.WriteLine($"╚{border}╝");
        Console.ResetColor();
    }

    static void ShowMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static void TypewriterEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }
}
