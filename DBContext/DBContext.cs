using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Accounts;
using CourseWork.tic_tac_toe;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace CourseWork.DBContexts
{
    public class DBContext
    {
        private string pathaccs = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.json");
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history.json");

        public List<Account> GetAllAccounts()
        {
            if (!File.Exists(pathaccs))
            {
                
                return new List<Account>();
            }

            string json = File.ReadAllText(pathaccs);
            return JsonConvert.DeserializeObject<List<Account>>(json);
        }

        public List<GameHistory> GetAllHistory()
        {
            if (!File.Exists(path))
            {
               
                return new List<GameHistory>();
            }

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<GameHistory>>(json);
        }

        public void WritePlayerAccountToFile(Account account)
        {
            
            List<Account> allAccounts = GetAllAccounts();

         
            allAccounts.Add(account);

           
            string serializedAccount = JsonConvert.SerializeObject(allAccounts);
            File.WriteAllText(pathaccs, serializedAccount);
        }
            
        public void WriteGameHistory(GameHistory history)
        {
           
            List<GameHistory> allGameHistory = GetAllHistory();

           
            allGameHistory.Add(history);

            string serializedGameHistory = JsonConvert.SerializeObject(allGameHistory);
            File.WriteAllText(path, serializedGameHistory);
        }

        public Account GetAccountById(int accountId)
        {
            List<Account> allAccounts = GetAllAccounts();
            return allAccounts.FirstOrDefault(account => account.ID == accountId);
        }

        public Account FindAccountByLogin(string login)
        {
            List<Account> allAccounts = GetAllAccounts();
            return allAccounts.FirstOrDefault(account => account.UserName == login);
        }

        public Account FindAccountByPassword(string password)
        {
            List<Account> allAccounts = GetAllAccounts();
            return allAccounts.FirstOrDefault(account => account.Password == password);
        }
        
        public List<GameHistory> GetGamesByAccountId(int accountId)
        {
            List<GameHistory> allGameHistory = GetAllHistory();
    
           
            List<GameHistory> accountGames = allGameHistory.Where(history => history.CurrentPlayer.ID == accountId || history.Opponent.ID == accountId).ToList();

            return accountGames;
        }

        public bool DoesAccExist(string login, string password)
        {
            List<Account> allAccounts = GetAllAccounts();

         
            return allAccounts.Any(account => account.UserName == login && account.Password == password);
        }
        
        
        public void UpdateRating(int accountId, int newRating)
        {
            
            List<Account> allAccounts = GetAllAccounts();

           
            Account existingAccount = allAccounts.FirstOrDefault(account => account.ID == accountId);

            
            if (existingAccount != null)
            {
                existingAccount.rating = newRating;

                
                string serializedAccounts = JsonConvert.SerializeObject(allAccounts);
                File.WriteAllText(pathaccs, serializedAccounts);
            }
        }


        
       
        
    }
}
