using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Snake_and_Ladder
{
    public partial class Form1 : Form
    {
        Form2 StartGame;
        public Form1()
        {
            InitializeComponent();
          StartGame =new Form2();
            
        }

        private void Play_Click(object sender, EventArgs e)
        {
          
            if (this.Player2Name.Text == "")
            {
                StartGame.Player1Name.Text = this.Player1Name.Text;
                StartGame.Player2Name.Text ="COM";
                Form1 OpenForm = new Form1();
                this.Hide();
                OpenForm.Close();
                StartGame.Show();
            }
            else {
                StartGame.Player1Name.Text = this.Player1Name.Text;
                StartGame.Player2Name.Text = this.Player2Name.Text;
                Form1 OpenForm = new Form1();
                this.Hide();
                OpenForm.Close();
                StartGame.Show();
            }
                   
        
        }

        private void Aboutus_Click(object sender, EventArgs e)
        {
           
            Process.Start("firefox.exe", "http://nearkevin.cu.cc/Temp/");
            
        }

        private void Instruction_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
