using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Player1 : Player
    {
        public string Name { get; set; }
        public string Symbol { get; }

        public Player1(string name,string symbol)
        {
            this.Name = name;
            this.Symbol = symbol;
        }
    }
}