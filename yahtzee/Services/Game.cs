using System;

namespace Services
{

    public interface Player
    {
        public string pseudo { get; set; }
    }

    public interface Dice
    {
        public int value { get; set; }
    }

    public interface Score
    {
        public int score { get; set; }
    }

}