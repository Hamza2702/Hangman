using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] words = { "tutorial", "coding", "programmer", "csharp" };

            Random random = new Random();
            string selectedWord = words[random.Next(words.Length)];
            char[] wordToGuess = selectedWord.ToCharArray();
            char[] guessedLetters = new char[wordToGuess.Length];

            for (int i = 0; i < guessedLetters.Length; i++)
            {
                guessedLetters[i] = '_';

            }

            //code of the Game

            int attemptsLeft = 10;

            while (attemptsLeft > 0)
            {
                Console.WriteLine("Current word: " + new string(guessedLetters));

                Console.WriteLine("Guess a letter: ");
                char guess = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool correctGuess = false;

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedLetters[i] = guess;
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    attemptsLeft--;
                    Console.WriteLine("Incorrect! Attempts left: " + attemptsLeft);
                }
                if (new string(guessedLetters) == selectedWord)
                {
                    Console.WriteLine("Congratulations! You guessed the word: " + selectedWord);
                    Console.ReadLine();
                    break;
                }
            }

            // Show the outcome of the game

            if (attemptsLeft == 0)
            {
                Console.WriteLine("Sorry, you have ran out of attempts.- The word was: " + selectedWord);
                Console.ReadLine();
            }

            Console.WriteLine("Thanks for playing Hangman!");
            Console.ReadLine();
        }
    }
}
