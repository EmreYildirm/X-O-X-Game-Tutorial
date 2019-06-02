using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Game
    {
        public event xoxGameHandler GameStart;
        public event xoxGameOverHandler GameOver;
        public Player1 Player1;
        public Player2 Player2;
        public bool ActivePlayer;
        public bool ısOver;
        public int TurnCount = 0;
        public bool ısDraw;

        public Game()
        {
            Player1 = new Player1("Player1", "X");
            Player2 = new Player2("Player2", "O");

        }
        public void StartGame()
        {
            ActivePlayer = true;
            GameStart(this);
        }
        private List<List<int>> gameOverConditions = new List<List<int>>()
        {
            new List<int>() {0,1,2},
            new List<int>() {3,4,5},
            new List<int>() {6,7,8},
            new List<int>() {0,3,6},
            new List<int>() {1,4,7},
            new List<int>() {2,5,8},
            new List<int>() {0,4,8},
            new List<int>() {2,4,6},
        };

        private string[] symbolArray = new string[9];

        public void PlayTurn(int fieldİndex)
        {
            if (ActivePlayer)
            {
                symbolArray[fieldİndex] = Player1.Symbol;
                TurnCount++;
                if (IsGameOver(fieldİndex))
                {
                    GameOver(this, GetWinninConditions());
                    return;
                }
            }
            else
            {
                symbolArray[fieldİndex] = Player2.Symbol;
                TurnCount++;
                if (IsGameOver(fieldİndex))
                {
                    GameOver(this, GetWinninConditions());
                    return;
                }
            }
             
            ActivePlayer = !ActivePlayer;
        }
        public bool IsGameOver(int fieldİndex)
        {
            foreach (var item in gameOverConditions.Where(x=>x.Contains(fieldİndex)))
            {
                if (symbolArray[item[0]] == symbolArray[item[1]] &&
                    symbolArray[item[1]] == symbolArray[item[2]])
                {
                    ısOver = true;
                    ısDraw = false;
                    break;
                }
                else if(symbolArray[item[0]] == symbolArray[item[1]] &&
                     symbolArray[item[1]] == symbolArray[item[2]] && TurnCount == 9)
                     {
                            ısOver = true;
                            ısDraw = false;
                            break;
                     }
                else if (symbolArray[item[0]] != symbolArray[item[1]] &&
                     symbolArray[item[1]] != symbolArray[item[2]] && TurnCount == 9)
                {
                    ısOver = true;
                    ısDraw = true;
                    break;
                }  
            }
            return ısOver;
        }

        private List<List<int>> GetWinninConditions()
        {
            List<List<int>> result = new List<List<int>>();
            foreach (var item in gameOverConditions)
            {
                if (symbolArray[item[0]] == symbolArray[item[1]] &&
                    symbolArray[item[1]] == symbolArray[item[2]])    
                        result.Add(item);
            }
            return result;
        }
    }
    
}
