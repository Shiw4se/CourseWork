using System;
using System.Windows.Forms;
using Accounts;
using CourseWork.DBContexts;

namespace CourseWork
{
    public partial class RegisterForm : Form
    {
        
        private AccountRepository Repository;

        private DBContext Base;

        private Account CurrentAccount;
       
        public RegisterForm(DBContext db, AccountRepository accrep)
        {
            InitializeComponent();
            Repository = accrep;
            Base = db;
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string UsrNm = textBox1.Text;
            string Psw = textBox2.Text;

            if (Base.DoesAccExist(UsrNm, Psw))
            {
                MessageBox.Show("Account Already exist!");
                return;
            }
            CurrentAccount = Repository.CreatePlayerAccountRep(UsrNm, Psw);
            Base.WritePlayerAccountToFile(CurrentAccount);
            textBox1.Clear();
            textBox2.Clear();
            var menu = new MenuForm(Base,Repository, CurrentAccount);
            menu.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        
    }
}
