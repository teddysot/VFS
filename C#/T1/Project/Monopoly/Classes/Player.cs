using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Player
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public Player(int pId, string pName, int pBalance)
        {
            id = pId;
            Name = pName;
            Balance = pBalance;
        }
    }
}
