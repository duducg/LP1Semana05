using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //use console input to get Enemy number:
            int n = int.Parse(args[0]);

            //Create an array with "n" number of indexes:
            Enemy[] enemies = new Enemy[n];
            
            for (int i = 0; i < n; i++)
            {
                //prompt user for name
                Console.Write($"Nome do inimigo {i + 1}: ");
                string user_in = Console.ReadLine();
                enemies[i] = new Enemy(user_in);
            }
            //after with we do another loop to print the array elements
            foreach(Enemy enemy in enemies)
            {
                string name = enemy.GetName();
                float health = enemy.GetHealth();
                float shield = enemy.GetShield();

                string output = $"{name} {health} {shield}";
                Console.WriteLine(output);
            }

            
            
            
        }
    }
}
