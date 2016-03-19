using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PacmanHackathonners.Models
{
    class Packman
    {
        int xCoordinate { get; set; }
        int yCoordinate { get; set; }
        int lives;
        bool isAlive;
        public Packman()
        {
            xCoordinate = 0;
            yCoordinate = 0;
            isAlive = true;
            lives = 3;
        }
        public Packman(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            isAlive = true;
            lives = 3;
        }

        public void MinusLive()
        {
            if (this.lives > 0)
            {
                lives--;
            }
            else
            {
                throw new Exception("Lives is wasted");
            }
        }
        public void AddLive()
        {
            if (lives <= 3)
            {
                lives++;
            }
            else
            {
                throw new Exception("You can't have more then 3 lives");
            }
        }
        public int GetLives()
        {
            return this.lives;
        }
        public void KillPackman()
        {
            isAlive = false;
        }
        public void AlivePackman()
        {
            isAlive = true;
        }
    }
}
