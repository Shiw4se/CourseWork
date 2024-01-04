
using System.Collections.Generic;
using Accounts;

namespace CourseWork.tic_tac_toe
{
    public class Game
    {
        

        private char[] board;

        public Game()
        {
            board = new char[]{ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }
        public char getValueFromBoard(int index)
            {
                return board[index];
            }
            private void SetValueInBoard(int index,char value)
            {
                if(index < board.Length) {
                    board[index] = value;
                }
            }
            public bool IsValidMove(int choice)
            {
                
                return getValueFromBoard(choice) != 'X' && getValueFromBoard(choice) != 'O';
            }
            public int IsWin()
            {
                #region Horzontal Winning Condtion
               
                if (board[1] == board[2] && board[2] == board[3])
                {
                    return 1;
                }
               
                else if (board[4] == board[5] && board[5] == board[6])
                {
                    return 1;
                }
              
                else if (board[6] == board[7] && board[7] == board[8])
                {
                    return 1;
                }
                #endregion
                #region vertical Winning Condtion
              
                else if (board[1] == board[4] && board[4] == board[7])
                {
                    return 1;
                }
                
                else if (board[2] == board[5] && board[5] == board[8])
                {
                    return 1;
                }
                
                else if (board[3] == board[6] && board[6] == board[9])
                {
                    return 1;
                }
                #endregion
                #region Diagonal Winning Condition
                else if (board[1] == board[5] && board[5] == board[9])
                {
                    return 1;
                }
                else if (board[3] == board[5] && board[5] == board[7])
                {
                    
                    return 1;
                }
                #endregion
                #region Checking For Draw
                // If all the cells or values filled with X or O then any player has won the match
                else if (board[1] != '1' && board[2] != '2' && board[3] != '3' && board[4] != '4' && board[5] != '5' && board[6] != '6' && board[7] != '7' && board[8] != '8' && board[9] != '9')
                {
                    return -1;
                }
                #endregion
                else
                {
                    return 0;
                }
                
                
            }

        public void Move(int choice,int move)
        {
            if (move % 2 == 0)
            {
                SetValueInBoard(choice, 'O');
            }
            else
            {
                SetValueInBoard(choice, 'X');
            }
            
           
        }
        
        
    }
}