using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PacmanHackathonners.Models
{
    class Field
    {
        public Field()
        {
            int x = Convert.ToInt32(SystemParameters.WorkArea.Height);
            int y = Convert.ToInt32(SystemParameters.WorkArea.Width);

            Create_Field(x, y);
        }

        private void Create_Field(int x, int y)
        {
            object[,] field = new object[(int)(x / 50), (int)(y / 50)];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Cell cell = new Cell();
                    field[i, j] = cell;
                }
            }
        }

    }
}