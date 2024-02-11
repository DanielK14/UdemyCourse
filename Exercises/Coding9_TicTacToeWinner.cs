using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Soon, you will try to create your own Tic Tac Toe game, so let's prepare a bit!

This time, you have to write only a checker for the game. It will be a method that takes a 2D array and returns a boolean. If there is a winner, it returns true otherwise false.

We use "X" and "O" as signs of our players. The empty places will be filled with numbers from 1 to 9.

You have to check 3 types of cases:
    horizontal;
    vertical;
    diagonal;

Hint: you can use more than one condition inside of one if, and don't hesitate to use loop;
*/

namespace UdemyCourse.Exercises
{
    internal class Coding9_TicTacToeWinner
    {
        public class TicTacToe
        {
            public static bool Checker(string[,] board)
            {
                string[] playerChars = { "X", "O" };

                foreach (string playerChar in playerChars)
                {
                    if (((board[0, 0] == playerChar) && (board[0, 1] == playerChar) && (board[0, 2] == playerChar))
                        || ((board[1, 0] == playerChar) && (board[1, 1] == playerChar) && (board[1, 2] == playerChar))
                        || ((board[2, 0] == playerChar) && (board[2, 1] == playerChar) && (board[2, 2] == playerChar))
                        || ((board[0, 0] == playerChar) && (board[1, 0] == playerChar) && (board[2, 0] == playerChar))
                        || ((board[0, 1] == playerChar) && (board[1, 1] == playerChar) && (board[2, 1] == playerChar))
                        || ((board[0, 2] == playerChar) && (board[1, 2] == playerChar) && (board[2, 2] == playerChar))
                        || ((board[0, 0] == playerChar) && (board[1, 1] == playerChar) && (board[2, 2] == playerChar))
                        || ((board[0, 2] == playerChar) && (board[1, 1] == playerChar) && (board[2, 0] == playerChar))
                        )
                    {
                        return true;
                    }

                }
                return false;
            }
        }
    }
}
