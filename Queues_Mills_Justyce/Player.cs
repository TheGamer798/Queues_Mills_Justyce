using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Mills_Justyce
{
    class Player
    {
        public int Health { get; set; }//an automatic property called Health of integer type

        public string GamerTag { get; }//another property called GamerTag, with an automatic getter, of string type

        public Player(int healthParam, string nameParam)//a constructor that takes one int parameter and one string parameter
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue)//a public method called JoinGame that takes two parameters
        {
            if(game.CurrentPlayers == game.MaxPlayers)//If the game's current players is equal to the max players, then add 'this' player to the queue
            {
                queue.Enqueue(this);
            }
            else//Else, print, Joining Game, and increase current players by 1
            {
                Console.WriteLine("Joining Game");
                game.CurrentPlayers++;
            }
        }

        public override string ToString()//Override the ToString method and return GamerTag
        {
            return GamerTag;
        }
    }
}
