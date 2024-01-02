using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Accounts;
using CourseWork.DBContexts;

namespace CourseWork
{
    public partial class MenuForm : Form
    {
        private AccountRepository Repository;

        private DBContext Base;

        private Account CurrentAccount;

        private Account Opponent;
        public MenuForm(DBContext db, AccountRepository accrep, Account acc)
        {
            InitializeComponent();
            
            Repository = accrep;
            Base = db;
            CurrentAccount = acc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartRandomGame();
        }
        
        private void StartRandomGame()
        {
            
            List<Account> allAccounts = Base.GetAllAccounts();

            
            List<Account> eligibleAccounts = allAccounts.Where(acc => !IsSameAccount(acc, CurrentAccount)).ToList();


            
            if (eligibleAccounts.Count > 1)
            {
                Random random = new Random();
                Opponent = eligibleAccounts[random.Next(eligibleAccounts.Count)];

               
                StartGameWithOpponent();
            }
            else
            {
                MessageBox.Show("No eligible opponents found.");
            }
        }
        
        private bool IsSameAccount(Account account1, Account account2)
        {
            return account1.ID == account2.ID; 
        }


        private void StartGameWithOpponent()
        {
            
            var gameForm = new GameForm(Base, Repository, CurrentAccount, Opponent);

            
            gameForm.Show();

            
            this.Hide();
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            var id = CurrentAccount.ID;
            var account = Base.GetAccountById(id);

            // Создание формы для отображения информации об аккаунте
            StatisticForm accountInfoForm = new StatisticForm(account, Base);
      
            accountInfoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

    }
}