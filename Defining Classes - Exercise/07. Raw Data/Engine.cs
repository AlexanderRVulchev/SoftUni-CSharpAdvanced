using System;


namespace DefiningClasses
{
    public class Engine
    {
        private int speed;
        private int power;
        
        public int Speed { get { return speed; } set { speed = value; } }
        public int Power { get { return power; } set { power = value; } }

        public Engine(int speed, int power)
        {
            this.Power = power;
            this.Speed = speed;
        }
    }
}
