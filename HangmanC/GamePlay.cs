using System;
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
            string[] wordList = {"blue", "red", "black", "green", "yellow"};
            string wordGuess = wordList[random.Next(0, wordList.Length)];//random to pick words from wordlist
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
        int guesses = 3;
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
                    Console.WriteLine("'{0}' has been tried, Guess another letter", userGuess);
                    Console.WriteLine($"You have {guesses} unique guesses left");
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
                    Console.WriteLine("There is no '{0}' in the puzzle", userGuess);
                    guesses--;
                    Console.WriteLine($"You have {guesses} unique guesses left");
                }
                Console.WriteLine(displayToPlayer.ToString());//display letters written to users
            }
            if (won)
            {
                StandardMessages.WinMessage();
            }
            else
                StandardMessages.LoseMessage();
                Console.WriteLine("The word is: {0} ", wordGuess);
        }
        public static void ExitApp()//proceed or exit method
        {
            if (opSelect.ToUpper() == "X")
            {   
              StandardMessages.ExitAppConfirm();
              System.Environment.Exit(1);
            }
            else if (opSelect == "")
            {
              Console.WriteLine("Player Ready");
            }
            else
            {
            throw new Exception();
            }
        }
    }
}
