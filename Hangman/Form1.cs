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
    public partial class Hangman : Form
    {
        int attemptsLeft = 10;
        string word;
        string[] words = { "test", "coding", "programmer", "csharp" };
        char[] guessedLetters;

        public Hangman()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            lblGuesses.Text = $"{attemptsLeft}";

            Random random = new Random();
            word = words[random.Next(words.Length)];
            guessedLetters = new string('_', word.Length).ToCharArray();

            lblWord.Text = new string(guessedLetters);
        }

        private void GuessLetter(char letter)
        {
            bool correctGuess = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    guessedLetters[i] = letter;
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                attemptsLeft--;
            }

            lblGuesses.Text = $"{attemptsLeft}";
            lblWord.Text = new string(guessedLetters);

            CheckGameOver();
        }

        private void CheckGameOver()
        {
            if (attemptsLeft <= 0)
            {
                MessageBox.Show("Game Over! The word was: " + word);
                InitializeGame();
            }
            else if (!new string(guessedLetters).Contains('_'))
            {
                MessageBox.Show("Congratulations! You've guessed the word: " + word);
                InitializeGame();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                char guessedLetter = txtboxGuess.Text[0];
                GuessLetter(guessedLetter);
            } else
            {
                MessageBox.Show("Enter a character");
            }
        }
    }
}
