﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanC
{
    class GamePlay : StandardMessages
    {
        public static void RandomWords()
        {
            Random random = new Random();
            string[] wordList = { "blue", "red", "black", "abstraction"};
            string wordGuess = wordList[random.Next(0, wordList.Length)];
            string wordGuessUppercase = wordGuess.ToUpper();
            StringBuilder displayToPlayer = new StringBuilder(wordGuess.Length);
            string wordGuessChar = new String('-', wordGuess.Length);//display dashes
            Console.WriteLine($"Your Word has {wordGuess.Length} letters");
            Console.WriteLine(wordGuessChar);
          
            for (int i = 0; i < wordGuess.Length; i++)
            {
               displayToPlayer.Append('-');
            }

        List<char> rightGuess = new List<char>();
        List<char> wrongGuess = new List<char>();
        int guesses = 6;
        bool won = false;
        int lettersRevealed = 0;
        string userInput;
        char userGuess;

            while (!won && guesses > 0)
            {
                StandardMessages.UserPrompt();
                userInput = Console.ReadLine().ToUpper();
                userGuess = userInput[0];

                if (rightGuess.Contains(userGuess))
                {
                    StandardMessages.UserRightGuess();//typing a correct letter again
                }
                else if (wrongGuess.Contains(userGuess))
                {
                    Console.WriteLine("you already tried '{0}', and its wrong", userGuess);
                    Console.WriteLine($"You Have {guesses} Unique Guesses Left");
                    continue;
                }
                if (wordGuessUppercase.Contains(userGuess))
                {
                    rightGuess.Add(userGuess);
                    for (int i = 0; i < wordGuess.Length; i++)
                    {
                        if (wordGuessUppercase[i] == userGuess)
                        {
                            displayToPlayer[i] = wordGuess[i];
                            lettersRevealed++;
                        }
                    }
                    if (lettersRevealed == wordGuess.Length)
                        won = true;
                }
                else
                {
                    wrongGuess.Add(userGuess);
                    Console.WriteLine("No {0} in the puzzle", userGuess);
                    guesses--;
                    Console.WriteLine($"You Have {guesses} Unique Guesses Left");
                }
                Console.WriteLine(displayToPlayer.ToString());//display letters written to users
            }
            if (won)
            {
                StandardMessages.WinMessage();
            }
            else
                StandardMessages.LoseMessage();
                Console.WriteLine("The Word Is '{0}'", wordGuess);
        }
        public static void ExitApp()
        {
            if (opSelect.ToUpper() == "X")
            {
                //Console.WriteLine("Swell");
              StandardMessages.ExitAppConfirm();
              System.Environment.Exit(1);
            }
            else if (opSelect == "")
            {
              Console.WriteLine("ok computer");
            }
            else
            {
            throw new Exception();
            }
        }
    }
}
