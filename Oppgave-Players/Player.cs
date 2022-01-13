using System;
using System.Reflection.PortableExecutable;

namespace Oppgave_Players
{
    public class Player
    {
        private string _name;
        private int _points; 
        private Random _random;

        public Player(string name, int points, Random random)
        {
            _name = name;
            _points = points;
            _random = random;
        }



        public void Play(Player player2)
        {
            var winner = _random.Next(2) == 0 ? this : player2;
            var loser = winner == this ? player2 : this;
            winner._points += 1;
            loser._points -= 1;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine(_name.PadRight(12) + _points.ToString().PadLeft(3));
        }
    }
}