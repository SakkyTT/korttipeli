using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korttipeli
{
    class Table
    {
        public List<Player> Players { get; set; }

        public Table(List<Player> listOfPlayers)
        {
            Players = listOfPlayers;
        }
    }
}
