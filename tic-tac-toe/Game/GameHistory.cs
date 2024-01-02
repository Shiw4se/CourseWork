using Accounts;
using Newtonsoft.Json;

namespace CourseWork.tic_tac_toe
{
   
    public class GameHistory
    {
        
        public Account CurrentPlayer;

      
        public Account Opponent;

        public int Rating;

        public GameHistory(Account _CurrentPlayer, Account _Opponent, int rating)
        {
            CurrentPlayer = _CurrentPlayer;
            Opponent = _Opponent;
            Rating = rating;
        }
    }
}
