using System;

namespace PlayerStats
{
    class Player
    {
        private float highScore;
        public float HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                if (value > highScore) highScore = value;
            }
        }
        private int playedGames;
        private int wonGames;
        public string Name { get; }
        public float WinRate
        {
            get
            {
                if (playedGames == 0 || wonGames == 0)
                {
                    return 0;
                }
                else
                {
                    return (float) wonGames / (float) playedGames;
                }
            }
        }
        public Player(string name)
        {
            Name = name;
            highScore = 0;
            wonGames = 0;
            playedGames = 0;
        }
        public void PlayGame(bool win)
        {
            playedGames++;
            if (win) wonGames++;
        }
    }
}
