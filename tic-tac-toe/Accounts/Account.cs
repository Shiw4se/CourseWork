using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Windows.Forms;
using CourseWork.tic_tac_toe;
using Newtonsoft.Json;

namespace Accounts
{
    public class Account 
    {
       private const int StartRating = 10;
        public int rating{ get; set; }
        
        public string Password { get; private set; }
        
        public string UserName { get; protected set; }
        
        [Newtonsoft.Json.JsonIgnore]
        public List<GameHistory> GameHistoryList { get; set; }
       
        
        private static int tick = Environment.TickCount;
        public int ID { get; set; }
       
        [System.Text.Json.Serialization.JsonConstructor]
        public Account(string userName,string password)
        {
           
            UserName = userName;
            rating = StartRating;
            setPassword(password);
            ID = Interlocked.Increment(ref tick);
            GameHistoryList = new List<GameHistory>();
        }
        
        
        private void setPassword(string NewPass)
        {
            Password = NewPass;
        }

        public void WinGame(Account acc)
        {
            acc.rating++;
        }
        
        
    }
}