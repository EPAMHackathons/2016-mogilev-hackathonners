using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanHackathonners.Models
{
    class AntiVirus
    {
        int xCoordinate { get; set; }
        int yCoordinate { get; set; }
        bool isLive;
        public AntiVirus()
        {
            xCoordinate = 0;
            yCoordinate = 0;
            isLive = true;
        }
        public AntiVirus(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            isLive = true;
        }

        public void KillAntivirus()
        {
            isLive = false;
        }
        public void AliveAntivirus()
        {
            isLive = true;
        }
    }
}
