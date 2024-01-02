using System;
using System.Windows.Forms;
using Accounts;
using CourseWork.DBContexts;

namespace CourseWork
{
    public partial class StatisticForm : Form
    {
        private DBContext dbContext;

        private Account CurrentAccount;

        public StatisticForm(Account account, DBContext db)
        {
            InitializeComponent();

            
            dbContext = db;
            CurrentAccount = account;
            
            label2.Text = $"{CurrentAccount.ID}";

            
            label4.Text = $"{CurrentAccount.UserName}";

            
            label6.Text = $"{CurrentAccount.rating}";
            
            UpdateListBox();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = $" {CurrentAccount.ID}";
        }


        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = $"{CurrentAccount.UserName}";
        }


        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = $"{CurrentAccount.rating}";
        }

        private void UpdateListBox()
        {
            var gameHistoryList = dbContext.GetGamesByAccountId(CurrentAccount.ID);

            listBox1.Items.Clear();

            
            foreach (var gameHistory in gameHistoryList)
            {
                listBox1.Items.Add($"Opponent: {gameHistory.Opponent.UserName}\t| Rating: {gameHistory.Rating}");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gameHistoryList = dbContext.GetGamesByAccountId(CurrentAccount.ID);

            listBox1.Items.Clear();
            
           
            foreach (var gameHistory in gameHistoryList)
            {
               
                
                listBox1.Items.Add($"Opponent: {gameHistory.Opponent.UserName}\t| Rating: {gameHistory.Rating}");
                
            }
            
        }
    }
}
