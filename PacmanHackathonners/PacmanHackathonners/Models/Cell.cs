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
        public void Cell(int x, int y)
        {
            byte[,] cell = new byte[x, y];
            int bound_v = rnd.Next(0, 3);

            switch (bound_v)
            {
                case 0:
                    cell = Create_Bound(x - x / 5, 0, x, y); // vertical
                    break;

                case 2:
                    cell = Create_Bound(0, y - y / 5, x, y); // horizontal
                    break;
            }
        }

        private byte[,] Create_Bound(int x_n, int y_n, int x_k, int y_k)
        {
            byte[,] cell = new byte[x_k, y_k];

            for (int i = x_n; i < x_k; i++)
            {
                for (int j = y_n; j < y_k; j++)
                {
                    cell[i, j] = 1;
                }
            }
            return cell;
        }
    }
}