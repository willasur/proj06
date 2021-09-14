using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanC
{
    class StandardMessages 
    {
        public static string opSelect { get; private set; }
        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello Hangman!");
        }
        public static void UserPrompt()
        {
            Console.WriteLine("Please type a Letter");
        }
        public static void UserRightGuess()
        {
           Console.WriteLine("You Already Tried That letter");
        }
        public static void WinMessage()
        {
            Console.WriteLine("You WIN!");
        }
        public static void LoseMessage()
        {
            Console.WriteLine("You LOSE!");
        }
        public static void UserMessage()
        {
            Console.WriteLine("Press Enter to Continue or X to Exit");
        }
        public static void UserExit()
        {
            opSelect = Console.ReadLine();
        }
        public static void ExitAppConfirm()
        {
            Console.WriteLine("Press X Again to Close App");
            Console.ReadLine();
        }
    }
}
