using System;

namespace Enemies
{
    /// <summary>
    /// Zombie Class, inherits from Enemy
    /// Do me a heckin zombie
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie livelihood established
        /// </summary>
        private int health;

        /// <summary>
        /// Zombie name
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Zombie starts at 0 health
        /// </summary>
        public Zombie()
        {
        health = 0;
        }

        /// <summary>
        /// Zombie instantialization
        /// </summary>
        public Zombie(int value) 
        {
            if (value < 0)
            {
            throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Do me a healthy zombie
        /// </summary>
        public int GetHealth()
        {
        return health;
        }

        /// <summary>
        /// Do a zombie a naming
        /// </summary>
        public string Name {
            get { return name; }
            set { name = value; }
        }
        
        /// <summary>
        /// Makes a redefined string version of the zombie on toString
        /// </summary>
        public override string ToString()
        {
        return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}

