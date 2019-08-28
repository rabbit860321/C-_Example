using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24switchEnum
{
    class Monster
    {
        private int X;
        private int Y;

        public void move(int direction)
        {
            switch (direction)
            {
                case 1:
                    Y += 1;
                    break;
                case 2:
                    Y -= 1;
                    break;
                case 3:
                    X -= 1;
                    break;
                case 4:
                    X += 1;
                    break;
            }
        }

        public void Move1(Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    Y += 1;
                    break;
                case Direction.DOWN:
                    Y -= 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
            }
        }

        public string ReportPosition()
        {
            return "怪物在(" + X + ", " + Y + ")";
        }
    }
}
