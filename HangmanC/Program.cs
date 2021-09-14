using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HangmanC
{
    public class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            while (true)
            try
            {
                StandardMessages.UserMessage();
                StandardMessages.UserExit();
                GamePlay.ExitApp();
                GamePlay.RandomWords();    
            }
            //catch (FormatException)
            //{
            //    Console.WriteLine("oh");//change to method
            //}
            catch (Exception)
            {
                StandardMessages.ExceptionMessage();
            }
        }
    }
}
