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

        //static powerup counter
        private static int powerUpCount;

        //Constructor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
            
        }
        //static Constructor:
        //runs before any instancing is done.Only runs once
        static Enemy()
        {
            powerUpCount = 0;
        }
        public static int GetPowerUpCount()
        {
            return powerUpCount;
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
        //Set the name
        public void SetName(string name)
        {
            if (name.Length >= 8) this.name = name.Substring(0,8); 
            else
            {
                this.name = name;
            }
            
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
        public void PickupPowerUp(PowerUp pu, float boost)
        {
            if (pu == PowerUp.Health)
            {
                health += boost;
                if (health > 100) health = 100;

            }
            else if (pu == PowerUp.Shield)
            {
                shield += boost;
                if (shield > 100) shield = 100;
            }
            powerUpCount ++;
        }
    }
}