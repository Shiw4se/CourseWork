using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accounts;
using CourseWork.DBContexts;
using CourseWork.tic_tac_toe;

namespace CourseWork
{
    public partial class GameForm : Form
    {
        private int t = 0;
        private Account CurrentAccount;
        private Account Opponent;
        private AccountRepository Repository;
        private DBContext Base;
        private Game TicTac;
       
        public GameForm(DBContext db,AccountRepository repacc, Account acc, Account opp)
        {
            InitializeComponent();
            CurrentAccount = acc;
            Repository = repacc;
            Base = db;
            TicTac = new Game();
            Opponent = opp;
            this.Load += Form1_Load;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            Button clickedButton = (Button)sender;
            
            string buttonName = clickedButton.Name;

            
            if (buttonName.Contains("button"))
            {
                
                int buttonNumber = int.Parse(buttonName.Replace("button", ""));

                if (TicTac.IsValidMove(buttonNumber))
                {
                    
                    
                    TicTac.Move(buttonNumber, t);
                    if (t % 2 == 0)
                    {
                        
                        clickedButton.Text = "X";
                        t++;
                    }
                    else
                    {
                        
                        clickedButton.Text = "O";
                        t++;
                    }

                    
                }
                int result = TicTac.IsWin();
                if (result == 1 && t%2!=0)
                {
                    
                    
                    MessageBox.Show("X wins!");
                    CurrentAccount.WinGame(CurrentAccount);
                    Opponent.LoseGame(Opponent);
                    var history = new GameHistory(CurrentAccount,Opponent,CurrentAccount.rating);
                    Base.WriteGameHistory(history);
                    CurrentAccount.GameHistoryList.Add(history);
                    Opponent.GameHistoryList.Add(history);
                    Base.UpdateRating(CurrentAccount.ID, CurrentAccount.rating);
                    Clear();
                    ShowResultAndReturn();
                }
                else if(result==-1)
                {
                    MessageBox.Show("Draw!");
                    ShowResultAndReturn();
                }
                else if(result==1 &&t%2==0)
                {
                    
                    MessageBox.Show("O wins!");
                    CurrentAccount.LoseGame(CurrentAccount);
                    Opponent.WinGame(Opponent);
                    var history = new GameHistory(CurrentAccount,Opponent,CurrentAccount.rating);
                    CurrentAccount.GameHistoryList.Add(history);
                    Base.WriteGameHistory(history);
                    Base.UpdateRating(Opponent.ID, Opponent.rating);
                    Clear();
                    ShowResultAndReturn();
                }

            }
        }
        
        private void ShowResultAndReturn()
        {
            Clear();
            var menu = new MenuForm(Base, Repository, CurrentAccount);
            menu.Show();
            this.Hide();
        }
        
        private void Clear()
        {
            t = 0;
            
            for (int i = 1; i <= 9; i++)
            {
                Button btn = Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Text = "";
                }
            }
        }
       

        private void button11_Click(object sender, EventArgs e)
        {
            var menu = new MenuForm(Base, Repository, CurrentAccount);
            menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender,e);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string message = $"{CurrentAccount.UserName} playing against {Opponent.UserName}";
            label1.Text = message;
            label1.Visible = true; 
        }


    }
}