﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanHackathonners
{
    class Cell
    {
        Random rnd = new Random();
<<<<<<< HEAD

        private bool _right = false, _down = false;
        private int fill = 0;

        public Cell()
=======
        public Cell(int x, int y)
>>>>>>> 5c05842f9c319ed9cacf110e194494c468ecfed6
        {
            int bound_v = rnd.Next(0, 3);

            switch (bound_v)
            {
                case 0:
                    _right = true; // vertical
                    break;

                case 2:
                    _down = true; // horizontal
                    break;
            }
        }

        public int Fill
        {
            get { return fill; }
            set { fill = value; }
        }

    }
}