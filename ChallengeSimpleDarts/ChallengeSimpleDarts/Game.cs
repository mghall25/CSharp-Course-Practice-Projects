using Darts;
using System;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public string GameDesc { get; set; }
        private Random _random  { get; set; }

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            _random = new Random();
            GameDesc = PlayGame();
        }

        public string PlayGame()
        {
            string gameDesc = "";           

            do
            {
                gameDesc += "------------------------------------- Round ------------------------------------------------<br>";
                //player 1 takes 3 throws
                gameDesc += "Player 1: three throws<br>";
                gameDesc += playRound(Player1);                

                // player 2 takes 3 throws
                gameDesc += "<br>Player 2: three throws<br>";
                gameDesc += playRound(Player2);                         

            } while (Player1.score < 300 && Player2.score < 300);
            gameDesc += "--------------------------------------------------------------------------------------------<br>";

            return gameDesc;
        }

        private string playRound(Player player)
        {
            int _currentThrowScore;
            string roundDesc ="";
            
            for (int i = 0; i< 3; i++)
            {                
                Dart dart = new Dart(_random);
                dart.ThrowDart();
                _currentThrowScore = Score.CalcDartThrow(dart);
                player.score += _currentThrowScore;
                roundDesc += String.Format(" Dart {0}: landed in section: {1}, ring: {2}  throwScore= {3}  Player's Score= {4}<br> ", i + 1, dart.ThrowScore, dart.ThrowInRing, _currentThrowScore, player.score);
            }
            return roundDesc;
        }
        
    }
}