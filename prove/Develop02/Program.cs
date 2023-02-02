using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        bool revealMenu = true;
        while (revealMenu)
        MainMenu();
    }
    public static void MainMenu()
    {

        Random random = new Random();
        string[] journalQuestions = {
      "What was the best thing that happened to you today?",
      "What steps did you take today towards a goal you're working on?",
      "How did you see the Lord in your life today?",
      "What country would you like to visit for the first time?",
      "What do you feel is your purpose in life, and has that answer changed in the last five years?",
      "What is your happy place? Describe it in detail",
      "Where do you see yourself in 10 years? 20?",
      "What negative emotions am I holding onto? How can I let them go?",
      "What goals have you lost sight of? Are you interested in picking them up again?",
      "What do you want to be remembered for?" };

        int myIndex = random.Next(journalQuestions.Length);

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4 .Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?: ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {

        }
        else if (userInput == "2")
        {

        }
        else if (userInput == "3")
        {

        }
        else if (userInput == "4")
        {

        }
        else if (userInput == "5")
        {

        }

    }


}