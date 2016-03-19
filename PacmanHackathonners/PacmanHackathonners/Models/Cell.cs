﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanHackathonners
{
    class Cell
    {
        Random rnd = new Random();

        private bool _right = false, _down = false;
        private int fill = 0;

        public Cell()
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