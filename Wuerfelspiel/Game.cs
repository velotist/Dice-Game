using System;

namespace Wuerfelspiel
{
    class Game
    {
        public static Random estimateEyes = new Random();

        public static void Main(String[] args)
        {    
            //var wuerfeln = new Dice[2] { new Dice(), new Dice() };
            Player player1 = new Player("Konstantin");
            Player player2 = new Player("Marcus");
            var resultPlayer1 = DiceNow();
            Console.WriteLine(player1.Name + " hat " + resultPlayer1 + " Augen erwürfelt.");
            var resultPlayer2 = DiceNow();
            Console.WriteLine(player2.Name + " hat " + resultPlayer2 + " Augen erwürfelt.");
            if (resultPlayer1 > resultPlayer2)
                Console.WriteLine(player1.Name + " hat gewonnen mit " + resultPlayer1 + " Augen.");
            else if(resultPlayer2 > resultPlayer1)
                Console.WriteLine(player2.Name + " hat gewonnen mit " + resultPlayer2 + " Augen.");
            else
                Console.WriteLine("Remis.");
        }

        public static int DiceNow()
        {
            int result = 0;
            int wurf = 0;
            for(int i = 0; i < 3; i++)
            {
                wurf = estimateEyes.Next(1, 6);
                Console.WriteLine(wurf);
                result = result + wurf;
            }
            return result;
        }
    }
}