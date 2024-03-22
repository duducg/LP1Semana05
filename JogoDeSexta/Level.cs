using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDeSexta
{
    public class Level
    {
        //vars
        //total number of rooms
        private Enemy[] rooms;
        //level toughness
        private Toughness toughness;
        
        


        //Constructor        
        public Level(int rooms_numb, Toughness toughness)
        {            
            this.rooms = new Enemy[rooms_numb];
            this.toughness = toughness;
        }

        public void SetEnemyInRoom(int roomindex, Enemy enemy)
        {
            //room can't have more then one enemy
            //sets that value to
            rooms[roomindex] = enemy;
                      
        }
        public string GetToughness()
        {
            return toughness.ToString();

        }
        public int GetNumRooms()
        {
            return rooms.Length;
        }
        public int GetNumEnemies()
        {
            return CountEnemy();
        }
        public void PrintEnemies()
        {
            for (int i = 0; i<rooms.Length;i++)
            {
                if (rooms[i] != null)               
                {
                    
                    string enemynName = rooms[i].GetName();
                    Console.WriteLine($"Room {i}: {enemynName}");

                }
                
            }
        }
        private int CountEnemy ()
        {
            int counter = 0;
            for (int i = 0; i<rooms.Length;i++)
            {
                if (rooms[i] != null) counter++;
            }
            return counter;
        }

    }
}