using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Mills_Justyce
{
    class Game
    {
        public int MaxPlayers { get; }//property called MaxPlayers with an automatic getter

        public int CurrentPlayers { get; set; }//property called CurrentPlayers with an automatic getter and setter

        public Game(int maxP, int currentP)//constructor that takes two int parameters, maxPlayers and currentPlayers
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer()//method called KickPlayer. in the body decrement CurrentPlayers by 1
        {
            CurrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue)// method called CheckQueue that takes a Queue<Player> parameter
        {
            if(CurrentPlayers < MaxPlayers)//if CurrentPlayers is less than MaxPlayers, then check if the queue has elements in it
            {
                if(playerQueue.Count > 0)//If the queue has players in it, call Dequeue on the queue and increment current players by 1
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else//Else, print, No Players in the Queue
                {
                    Console.WriteLine("No players in the queue");
                }
            }
        }


    }
}
