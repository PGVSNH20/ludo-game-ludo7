using System;

namespace LudoEngine
{
    public class Dice
    {
        Random rnd = new Random();
        public int Roll()
        {
            return rnd.Next(1, 7);
        }

    }
}