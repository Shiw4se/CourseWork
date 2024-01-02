using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Accounts;
using CourseWork.DBContexts;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        private List<Account> AllAcounts;
        private AccountRepository Repository;

        private DBContext Base;

        private Account CurrentAccount;
        public LoginForm(DBContext db, AccountRepository accrep)
        {
            InitializeComponent();
            Repository = accrep;
            Base = db;
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            string UsrNm = textBox1.Text;
           
            
            string Psw = textBox2.Text;
            Account findacc = Base.FindAccountByLogin(UsrNm);
            findacc = Base.FindAccountByPassword(Psw);


            if (findacc != null && findacc.Password == Psw)
            {
                CurrentAccount = findacc;
                var menu = new MenuForm(Base, Repository, CurrentAccount);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password. Please try again.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm(Base,Repository);
            reg.Show();
            this.Hide();
        }
    }
}