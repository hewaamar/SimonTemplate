using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        int guess = 0;

        //buttons
        Button[] squares = new Button[4];

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()

            // clear pattern list, refresh, pause
            Form1.patternList.Clear();
            Refresh();
            Thread.Sleep(1000);


            //load buttons
            squares[0] = redButton;
            squares[1] = yellowButton;
            squares[2] = blueButton;
            squares[3] = greenButton;

            // run computer turn
            ComputerTurn();
   
        } 

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            
            Random randomNum = new Random();
            int num = randomNum.Next(0,4);
            Form1.patternList.Add(0);
            Form1.patternList.Add(1);
            Form1.patternList.Add(2);
            Form1.patternList.Add(3);

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.patternList.Count ; i++)
            {
                // light up
                if (Form1.patternList[i] == 0)
                {
                    redButton.BackColor = Color.LightPink;

                    Refresh();
                    Thread.Sleep(1000);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();

                    Thread.Sleep(300);
                }

                if (Form1.patternList[i] == 1)
                {
                    blueButton.BackColor = Color.LightPink;

                    Refresh();
                    Thread.Sleep(1000);
                    blueButton.BackColor = Color.DarkRed;
                    Refresh();

                    Thread.Sleep(300);
                }

                if (Form1.patternList[i] == 2)
                {
                    yellowButton.BackColor = Color.LightPink;

                    Refresh();
                    Thread.Sleep(1000);
                    yellowButton.BackColor = Color.DarkRed;
                    Refresh();

                    Thread.Sleep(300);
                }

                if (Form1.patternList[i] == 3)
                {
                    greenButton.BackColor = Color.LightPink;

                    Refresh();
                    Thread.Sleep(1000);
                    greenButton.BackColor = Color.DarkRed;
                    Refresh();

                    Thread.Sleep(300);
                }
                



            }

            //TODO: get guess index value back to 0 (tracks number of guesses made by player)
           
        }

        public void GameOver()
        {
            //TODO: Play a game over sound

            //TODO: close this screen and open the GameOverScreen

            Application.Exit();
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value at current guess index equal to a green. If so:
   
            if (Form1.patternList[guess]==3)
            {
                // light up button, play sound, and pause
                greenButton.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                // set button colour back to original
                greenButton.BackColor = Color.DarkGreen;
                // add one to the guess index
                guess++;

                // call ComputerTurn() method
                ComputerTurn();
            }

            else 
            {
                GameOver();
            }
  
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {


            if (Form1.patternList[guess] == 1)
            {
                // light up button, play sound, and pause
                greenButton.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                // set button colour back to original
                greenButton.BackColor = Color.DarkGreen;
                // add one to the guess index
                guess++;

                // call ComputerTurn() method
                ComputerTurn();
            }

            else
            {
                GameOver();
            }

        }

        private void redButton_Click(object sender, EventArgs e)
        {
           
            if (Form1.patternList[guess] == 0)
            {
                // light up button, play sound, and pause
                greenButton.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                // set button colour back to original
                greenButton.BackColor = Color.DarkGreen;
                // add one to the guess index
                Refresh();
                // add one to the guess index
                guess++;
                // another refresh somewhere
                ComputerTurn();

               
            }

            else
            {
                GameOver();
            }

        }

        private void blueButton_Click(object sender, EventArgs e)
        {

            if (Form1.patternList[guess] == 2)
            {
                // light up button, play sound, and pause
                greenButton.BackColor = Color.LightGreen;
                //refresh
                Refresh();
                Thread.Sleep(1000);
                // set button colour back to original
                greenButton.BackColor = Color.DarkGreen;
                Refresh();
                // add one to the guess index
                guess++;
                // another refresh somewhere
                ComputerTurn();
            }
            else
            {
                GameOver();
            }
            // if pattern list.  count == guess

            if (Form1.patternList.Count == guess )
            {
                ComputerTurn();


            }



        }
    }
}
