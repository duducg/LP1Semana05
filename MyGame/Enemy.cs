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
        
        public string GetName()
        {
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }

        
        //Deal damage to enemy
        public void TakeDamage(float damage)
        {
            shield -= damage;
            //if damage > shield then shield will total negative numb
            if (shield < 0)
            {
                //this block only runs if the damage > shield
                //since shield is negative we have to multiply it by -1 first.
                float damageStillToInflict = -shield;
                //we used the above var to capture the excess damage.
                //We then reset the shield to 0. (Shield values can't be < 0)
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0; //if health goes below 0. reset it 0
                
            }
        }
    }
}