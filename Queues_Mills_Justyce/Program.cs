namespace Queues_Mills_Justyce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);// a Game object that sets its max players to 50 and current players to 49

            Queue<Player> waitingToJoinQ = new Queue<Player>();//a Queue of Player objects

            Player p1 = new Player(100, "TheGamer798");
            Player p2 = new Player(100, "SharkyBoi231");
            Player p3 = new Player(100, "Trigun5194");
            Player p4 = new Player(100, "xXtHat_gUyXx");
            //4 Player objects, giving them 100 health and a unique gamer tag
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);
            //call JoinGame on all 4 player objects; passing through the game and queue as arguments
            Console.WriteLine("Players in Queue:");//Print, Players in Queue, to console
            foreach(Player player in waitingToJoinQ)//loop through the queue and print all the players on a new line
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();//call KickPlayer on the game
            myGame.CheckQueue(waitingToJoinQ);//call CheckQueue on the game

            Console.WriteLine("\nPlayers in Queue:");//print, \nPlayers in Queue, to console
            foreach (Player player in waitingToJoinQ)//loop through the queue and print all the players on a new line
            {
                Console.WriteLine(player);
            }
        }
    }
}