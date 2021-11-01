using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8._5_Assingment___Hangman_Lite
{
    public partial class HangManLite : Form
    {
        Random generator = new Random();
        List<string> words = new List<string>();
       

        string word;
        string displayWord;
        int lives = 6;
        int wordlength;
        
        List<string> guesses = new List<string>();
       
        public HangManLite()
        {
            InitializeComponent();
        }

        

        private void HangManLite_Load(object sender, EventArgs e)
        {
            lblLivesLeft.Text = "Lives Left : 6";
            lstUsedLetters.DataSource = guesses;
            lblSecretWord.Text = displayWord;
            words.Add("JONAH");
            words.Add("BIRCH");
            words.Add("CODING");
            words.Add("JOKER");
            words.Add("AZURE");
            words.Add("APEX");
            int randWord = generator.Next(words.Count);
            word = (words[randWord]);
            wordlength = word.Length;
            string underscore = new String('_', wordlength);
            displayWord = underscore;
            lblSecretWord.Text = underscore;


        }


        private void RefreshNumberListbox()
        {
            lstUsedLetters.DataSource = null;
            lstUsedLetters.DataSource = guesses;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            txtGuess.MaxLength = 1;
            txtGuess.Text = txtGuess.Text.ToUpper();
            int index = word.IndexOf(txtGuess.Text);
                

            
            if (word.IndexOf(txtGuess.Text) != -1)
            {
                for (int i = 1; i <= 5; i++)
                {
                    displayWord = displayWord.Remove(index, 1);
                    lblSecretWord.Text = displayWord;
                    displayWord = displayWord.Insert(index, txtGuess.Text);
                    lblSecretWord.Text = displayWord;

                    
                }
                

               

               

            }
            else if (guesses.Contains(txtGuess.Text))
            {

            }
            else if (displayWord == word)
            {
                lblLivesLeft.Text = "You Win!";
                btnExit.Visible = true;

                lstUsedLetters.Visible = false;
                
                lblGuessedLetters.Visible = false;
            }

            
            else
            {
                guesses.Add(txtGuess.Text);
                RefreshNumberListbox();
                lives = lives - 1;
                lblLivesLeft.Text = ("Lives Left : " + lives + ".");
            }


            
            
                
            if (lives == 5)
            {
                    this.BackgroundImage = Properties.Resources.Hangman1_copy;
            }
            else if (lives == 6)
            {

            }
            else if (lives == 4)
            {
                    this.BackgroundImage = Properties.Resources.Hangman2_copy;

            }
            else if (lives == 3)
            {
                    this.BackgroundImage = Properties.Resources.Hangman3_copy;
            }
            else if (lives == 2)
            {
                    this.BackgroundImage = Properties.Resources.Hangman4_copy;
            }
            else if (lives == 1)
            {
                    this.BackgroundImage = Properties.Resources.Hangman5_copy;
            }
            else
            {
                    lblLivesLeft.Text = "You Lose!";
                    btnExit.Visible = true;
                    
                    lstUsedLetters.Visible = false;
                    this.BackgroundImage = Properties.Resources.Hangman6_copy;
                    lblGuessedLetters.Visible = false;
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }         
}
