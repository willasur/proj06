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
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("Guess the secret word\nAttempts are limited");
            Console.WriteLine("Good luck");
        }
        public static void UserPrompt()
        {
            Console.WriteLine("Please type a letter");
        }
        public static void UserRightGuess()
        {
           Console.WriteLine("You already tried that letter");
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
            Console.WriteLine("Press Any Key to Close App");
            Console.ReadLine();
        }
        public static void ExceptionMessage()
        {
            Console.WriteLine("Please Try Again");
        }
    }
}
