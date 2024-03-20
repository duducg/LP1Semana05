using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        //internal vars
        private string name;
        private float health;
        private float shield;

        //Constructor
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}