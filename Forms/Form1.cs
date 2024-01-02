using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounts;
using CourseWork.DBContexts;

namespace CourseWork
{
  public partial class Form1 : Form
  {
    private AccountRepository Repository;

    private DBContext Base;

    public Form1()
    {
      InitializeComponent();
      Repository = new AccountRepository();
      Base = new DBContext();
    }
    
    private void button14_Click(object sender, EventArgs e)
    {
      var RegisterForm = new RegisterForm(Base,Repository);
      RegisterForm.Show();
      this.Hide();
    }

    private void button15_Click(object sender, EventArgs e)
    {
      var LogForm = new LoginForm(Base,Repository);
      LogForm.Show();
      this.Hide();
    }
   
  }

  
}
