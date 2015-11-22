using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;

namespace Snake_and_Ladder
{
    public partial class Form2 : Form
    {
        bool PlayerTurn = true;
        int DiceNumber = 0;
        int Playerturncount = 0;
        int Player1Locat = 0;
        int Player2Locat = 0;
        SpeechSynthesizer ss2 = new SpeechSynthesizer();
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            if (Player1Name.Text.Equals(""))
            {
                ss2.SpeakAsync("Welcome to the board ! Click the roll dice button to start playing. Player 1 has no name . And Player 2 is me. I mean. Computer");
            }
            else if (Player2Name.Text.Equals("COM"))
            {
                ss2.SpeakAsync("Welcome to the board ! Click the roll dice button to start playing. Player 1 is : " + Player1Name.Text.ToString() + ". And Player 2 is me. I mean. Computer");
            }
            
            else
            {
                ss2.SpeakAsync("Welcome to the board ! Click the roll dice button to start playing. Player 1 is : " + Player1Name.Text.ToString() + ". And Player 2 is : "+ Player2Name.Text.ToString());
            }
            Random rn = new Random();
            int random = rn.Next(1, 5);
            switch (random)
            {
                case 1:
                    Board1.Visible = true;
                    Board2.Visible = false;
                    Board3.Visible = false;
                    Board4.Visible = false;
                    Board5.Visible = false;
                    break;

                case 2:
                    Board1.Visible = false;
                    Board2.Visible = true;
                    Board3.Visible = false;
                    Board4.Visible = false;
                    Board5.Visible = false;
                    break;

                case 3:
                    Board1.Visible = false;
                    Board2.Visible = false;
                    Board3.Visible = true; ;
                    Board4.Visible = false;
                    Board5.Visible = false;
                    break;

                case 4:
                    Board1.Visible = false;
                    Board2.Visible = false;
                    Board3.Visible = false;
                    Board4.Visible = true;
                    Board5.Visible = false;
                    break;

                case 5:
                    Board1.Visible = false;
                    Board2.Visible = false;
                    Board3.Visible = false;
                    Board4.Visible = false;
                    Board5.Visible = true;
                    break;
            }
            Player1.Location = new Point(45, 525);
            Player2.Location = new Point(45, 525 + 32);

        }
        //roll dice method
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Player2Name.Text.Equals("COM"))
            {
                playPlayer();
                Thread.Sleep(1000);
                playPlayer();
            }
            else
            {
                playPlayer();
            }
        }
        // player vs player
        public void playPlayer()
        {
            Random rn = new Random();
            int RandomDiceNumber = rn.Next(1, 6);


            switch (RandomDiceNumber)
            {
                case 1:
                    Dice1.Visible = true;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 2:
                    Dice1.Visible = false;
                    Dice2.Visible = true;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 3:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = true;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 4:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = true;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 5:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = true;
                    Dice6.Visible = false;
                    break;
                case 6:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = true;
                    break;
            }


            DiceNumber = RandomDiceNumber;
            Playerturncount++;
            if (Playerturncount % 2 == 0)
            {

                PlayerTurn = true;
                CurrentPlayer.Text = Player1Name.Text;
            }

            else
            {

                PlayerTurn = false;
                CurrentPlayer.Text = Player2Name.Text;
            }
            //player 1 rules
            if (PlayerTurn == true)
            {

                Player1Locat = Player1Locat + RandomDiceNumber;
                PlayerLocation.Player1Location(Player1Locat, Player1);
                if (Board1.Visible == true)
                {
                    rulesBoard1First(Player1Locat);

                }
                else if (Board2.Visible == true)
                {
                    rulesBoard2First(Player1Locat);
                }
                else if (Board3.Visible == true)
                {
                    rulesBoard3First(Player1Locat);
                }
                else if (Board4.Visible == true)
                {
                    rulesBoard4First(Player1Locat);
                }
                else if (Board5.Visible == true)
                {
                    rulesBoard5First(Player1Locat);
                }

                #region Winning
                if (Player1Locat >= 99)
                {
                    MessageBox.Show("Player 1 win !","Finish");
                    Player1Locat = 66;
                    Player2Locat = 66;
                    ss2.SpeakAsync(Player1Name.Text.ToString()+"Win ! Congratulations!");

                }
                #endregion

            }
            //player 2 rules


            else if (PlayerTurn == false)
            {



                Player2Locat = Player2Locat + RandomDiceNumber;
                PlayerLocation.Player2Location(Player2Locat, Player2);
                if (Board1.Visible == true)
                {
                    rulesBoard1Second(Player2Locat);
                }
                else if (Board2.Visible == true)
                {
                    rulesBoard2Second(Player2Locat);

                }
                else if (Board3.Visible == true)
                {
                    rulesBoard3Second(Player2Locat);
                }
                else if (Board4.Visible == true)
                {
                    rulesBoard4second(Player2Locat);
                }
                else if (Board5.Visible == true)
                {
                    rulesBoard5Second(Player2Locat);
                }

                #region Winning
                if (Player2Locat >= 99)

                {
                    if (Player2Name.Text.Equals("COM"))
                    {
                        MessageBox.Show("Computer win ! :( ","Finish !");
                        Player1Locat = 66;
                        Player2Locat = 66;
                        ss2.SpeakAsync("Computer Win ! Try Again !");
                    }
                    else
                    {
                        MessageBox.Show("Player 2 win !","Finish !");
                        Player1Locat = 66;
                        Player2Locat = 66;
                        ss2.SpeakAsync(Player1Name.Text.ToString() + " Win ! Congratulations!");
                    }

                }
                #endregion

            }
        }

        //rules board 1 player 1
        public void rulesBoard1First(int location)
        {


            switch (location)
            {
                case 98:
                    Player1.Location = new Point(293, 528);
                    MessageBox.Show("You got busted");
                    Player1Locat = 4;
                    break;

                case 78:
                    Player1.Location = new Point(355, 415);
                    MessageBox.Show("You got busted");
                    Player1Locat = 25;
                    break;
                case 71:
                    Player1.Location = new Point(417, 188);
                    MessageBox.Show("You got busted");
                    Player1Locat = 66;
                    break;
                case 64:
                    Player1.Location = new Point(108, 301);
                    MessageBox.Show("You got busted");
                    Player1Locat = 41;
                    break;

                case 14:
                    Player1.Location = new Point(232, 301);

                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 43;
                    break;
                case 21:
                    Player1.Location = new Point(479, 245);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 52;
                    break;
                case 36:
                    Player1.Location = new Point(605, 245);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 50;
                    break;
                case 82:
                    Player1.Location = new Point(479, 20);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 92;
                    break;
            }

        }
        //rules board 1 player 2
        public void rulesBoard1Second(int location)
        {

            switch (location)
            {
                case 98:
                    Player2.Location = new Point(293, 528 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 4;
                    break;

                case 78:
                    Player2.Location = new Point(355, 415 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 25;
                    break;
                case 71:
                    Player2.Location = new Point(417, 188 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 66;
                    break;
                case 64:
                    Player2.Location = new Point(108, 301 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 41;
                    break;

                case 14:
                    Player2.Location = new Point(232, 301 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 43;
                    break;
                case 21:
                    Player2.Location = new Point(479, 245 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 52;
                    break;
                case 36:
                    Player2.Location = new Point(605, 245 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 50;
                    break;
                case 82:
                    Player2.Location = new Point(479, 20 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 92;
                    break;
            }

        }
        //rules board 2 player 1
        public void rulesBoard2First(int location)
        {


            switch (location)
            {
                case 96:
                    Player1.Location = new Point(542, 132);
                    MessageBox.Show("You got busted");
                    Player1Locat = 71;
                    break;

                case 86:
                    Player1.Location = new Point(232, 188);
                    MessageBox.Show("You got busted");
                    Player1Locat = 63;
                    break;
                case 61:
                    Player1.Location = new Point(542, 301);
                    MessageBox.Show("You got busted");
                    Player1Locat = 48;
                    break;
                case 32:
                    Player1.Location = new Point(605, 528);
                    MessageBox.Show("You got busted");
                    Player1Locat = 9;
                    break;

                case 8:
                    Player1.Location = new Point(417, 472);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 13;
                    break;
                case 15:
                    Player1.Location = new Point(355, 301);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 45;
                    break;
                case 22:
                    Player1.Location = new Point(479, 188);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 67;
                    break;
                case 76:
                    Player1.Location = new Point(417, 20);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 93;
                    break;
            }

        }
        //rules board 2 player 2
        public void rulesBoard2Second(int location)
        {


            switch (location)
            {
                case 96:
                    Player2.Location = new Point(542, 132 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 71;
                    break;

                case 86:
                    Player2.Location = new Point(232, 188 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 63;
                    break;
                case 61:
                    Player2.Location = new Point(542, 301 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 48;
                    break;
                case 32:
                    Player2.Location = new Point(605, 528 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 9;
                    break;

                case 8:
                    Player2.Location = new Point(417, 472 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 13;
                    break;
                case 15:
                    Player2.Location = new Point(355, 301 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 45;
                    break;
                case 22:
                    Player2.Location = new Point(479, 188 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 67;
                    break;
                case 76:
                    Player2.Location = new Point(417, 20 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 93;
                    break;
            }

        }
        //rules board 3 player 1
        public void rulesBoard3First(int location)
        {

            switch (location)
            {
                case 26:
                    Player1.Location = new Point(232, 528);
                    MessageBox.Show("You got busted");
                    Player1Locat = 3;
                    break;

                case 51:
                    Player1.Location = new Point(108, 301);
                    MessageBox.Show("You got busted");
                    Player1Locat = 41;
                    break;
                case 74:
                    Player1.Location = new Point(232, 245);
                    MessageBox.Show("You got busted");
                    Player1Locat = 56;
                    break;
                case 90:
                    Player1.Location = new Point(479, 132);
                    MessageBox.Show("You got busted");
                    Player1Locat = 72;
                    break;

                case 15:
                    Player1.Location = new Point(542, 415);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 28;
                    break;
                case 23:
                    Player1.Location = new Point(355, 245);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 54;
                    break;
                case 63:
                    Player1.Location = new Point(355, 20);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 94;
                    break;
                case 71:
                    Player1.Location = new Point(108, 76);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 81;
                    break;
            }
        }
        //rules board 3 player 2
        public void rulesBoard3Second(int location)
        {

            switch (location)
            {
                case 26:
                    Player2.Location = new Point(232, 528 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 3;
                    break;

                case 51:
                    Player2.Location = new Point(108, 301 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 41;
                    break;
                case 74:
                    Player2.Location = new Point(232, 245 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 56;
                    break;
                case 90:
                    Player2.Location = new Point(479, 132 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 72;
                    break;

                case 15:
                    Player2.Location = new Point(542, 415 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 28;
                    break;
                case 23:
                    Player2.Location = new Point(355, 245 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 54;
                    break;
                case 63:
                    Player2.Location = new Point(355, 20 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 94;
                    break;
                case 71:
                    Player2.Location = new Point(108, 76 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 81;
                    break;
            }

        }

        //rules board 5 player 1
        public void rulesBoard5First(int location)
        {

            switch (location)
            {
                case 45:
                    Player1.Location = new Point(605, 528);
                    MessageBox.Show("You got busted");
                    Player1Locat = 9;
                    break;

                case 57:
                    Player1.Location = new Point(542, 358);
                    MessageBox.Show("You got busted");
                    Player1Locat = 31;
                    break;
                case 61:
                    Player1.Location = new Point(293, 415);
                    MessageBox.Show("You got busted");
                    Player1Locat = 24;
                    break;
                case 84:
                    Player1.Location = new Point(542, 245);
                    MessageBox.Show("You got busted");
                    Player1Locat = 51;
                    break;

                case 3:
                    Player1.Location = new Point(479, 415);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 27;
                    break;
                case 38:
                    Player1.Location = new Point(542, 188);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 68;
                    break;
                case 63:
                    Player1.Location = new Point(479, 20);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 92;
                    break;
                case 73:
                    Player1.Location = new Point(45, 76);

                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 80;
                    break;
            }
        }
        //rules board 5 player 2
        public void rulesBoard5Second(int location)
        {

            switch (location)
            {
                case 45:
                    Player2.Location = new Point(605, 528 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 9;
                    break;

                case 57:
                    Player2.Location = new Point(542, 358 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 31;
                    break;
                case 61:
                    Player2.Location = new Point(293, 415 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 24;
                    break;
                case 84:
                    Player2.Location = new Point(542, 245 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 51;
                    break;

                case 3:
                    Player2.Location = new Point(479, 415 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 27;
                    break;
                case 38:
                    Player2.Location = new Point(542, 188 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 68;
                    break;
                case 63:
                    Player2.Location = new Point(479, 20 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 92;
                    break;
                case 73:
                    Player2.Location = new Point(45, 76 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 80;
                    break;
            }
        }
        //rules board 4 player 1
        public void rulesBoard4First(int location)
        {
            switch (location)
            {
                case 7:
                    Player1.Location = new Point(168, 358);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player1Locat = 37;
                    break;
                case 13:
                    Player1.Location = new Point(605, 528);
                    MessageBox.Show("You got busted");
                    Player1Locat = 9;
                    break;
                case 45:
                    Player1.Location = new Point(108, 472);
                    MessageBox.Show("You got busted");
                    Player1Locat = 18;
                    break;
                case 25:
                    Player1.Location = new Point(542, 301);
                    MessageBox.Show("Yeah,it's getting closer");
                    Player1Locat = 48;
                    break;

                case 57:
                    Player1.Location = new Point(479, 20);
                    MessageBox.Show("Yeah,it's getting closer");
                    Player1Locat = 92;
                    break;
                case 67:
                    Player1.Location = new Point(232, 76);
                    MessageBox.Show("Yeah,it's getting closer");
                    Player1Locat = 83;
                    break;
                case 75:
                    Player1.Location = new Point(232, 301);
                    MessageBox.Show("You got busted");
                    Player1Locat = 43;
                    break;
                case 93:
                    Player1.Location = new Point(45, 245);
                    MessageBox.Show("You got busted");
                    Player1Locat = 59;
                    break;
            }
        }

        //rules board 4 player 2
        public void rulesBoard4second(int location)
        {
            switch (location)
            {
                case 7:
                    Player2.Location = new Point(168, 358 + 28);
                    MessageBox.Show("Yeah, it's getting closer");
                    Player2Locat = 37;
                    break;
                case 13:
                    Player2.Location = new Point(605, 528 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 9;
                    break;

                case 25:
                    Player2.Location = new Point(542, 301 + 28);
                    MessageBox.Show("Yeah,it's getting closer");
                    Player2Locat = 48;
                    break;
                case 45:
                    Player2.Location = new Point(108, 472 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 18;
                    break;
                case 57:
                    Player2.Location = new Point(479, 20 + 28);
                    MessageBox.Show("Yeah,it's getting closer");
                    Player2Locat = 92;
                    break;
                case 67:
                    Player2.Location = new Point(232, 76 + 28);
                    MessageBox.Show("Yeah,it's getting closer");
                    Player2Locat = 83;
                    break;
                case 75:
                    Player2.Location = new Point(232, 301 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 43;
                    break;
                case 93:
                    Player2.Location = new Point(45, 245 + 28);
                    MessageBox.Show("You got busted");
                    Player2Locat = 59;
                    break;
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            PlayerTurn = true;
            DiceNumber = 0;
            Playerturncount = 0;
            Player1Locat = 0;
            Player2Locat = 0;
            Player1.Location = new Point(45, 525);
            Player2.Location = new Point(45, 525 + 31);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ss2.Speak("Exit initiated. Thank you for playing !");
            Application.Exit();
        }



    }
}
