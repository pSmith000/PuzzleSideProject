using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSideProject
{
    class Game
    {
        public void Run()
        {       
            Console.Write("Loading ");

            for (int i = 0; i < 101; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 75);
                Console.Write(i + "%");
                Thread.Sleep(num);
                Console.SetCursorPosition(7, 0);
                Console.Write(" ");
            }

            Console.Clear();

            TypeOutWords("Uh...\nHello! My name is Glorfax and I will be your Narrator!\n", 100);
            Thread.Sleep(500);
            TypeOutWords("...", 300);
            GetInput("If that's alright with you anyway.\n", "Yeah", "No");
        }

        public void TypeOutWords(string sentence, int timeBetweenLetters)
        {
            char[] chars = sentence.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
                Thread.Sleep(timeBetweenLetters);
            }
        }

        int GetInput(string description, string option1, string option2)
        {
            string input = "";
            int inputReceived = 0;

            while (inputReceived != 1 && inputReceived != 2)
            {//Print options
                TypeOutWords(description, 100);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                //Get input from player
                input = Console.ReadLine();

                //If player selected the first option...
                if (input == "1" || input == option1)
                {
                    //Set input received to be the first option
                    inputReceived = 1;
                }
                //Otherwise if the player selected the second option...
                else if (input == "2" || input == option2)
                {
                    //Set input received to be the second option
                    inputReceived = 2;
                }
                //If neither are true...
                else
                {
                    //...display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }

                Console.Clear();
            }
            return inputReceived;
        }
    }
}