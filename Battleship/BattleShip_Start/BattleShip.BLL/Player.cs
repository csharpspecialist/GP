using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;

namespace BattleShip.BLL
{
   public class Player
    {
        public string Name { get; set; }
        public Board Board { get; set; }

       public Player()
       {
           this.Board = new Board();
       }


    }
}
