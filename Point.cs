using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char syn;
        internal static Point tall;

        public Point()
        {
            Console.WriteLine("Введена новая точка");
        }

        public Point(int _X, int _Y, char _syn)
        {
            x = _X;
            y = _Y;
            syn = _syn;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            syn = p.syn;
        }
         public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
             else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }

            else if (direction == Direction.UP)
            {
                y = y - offset;
            }

            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit( Point p)
        {
            return p.x == this.x && p.y == this.y ;
        }

        public void Clear()
        {
            syn = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(syn);
            
            

        }

        public override string ToString()
        {
            return x + "," + y + "," + syn;
        }



    }
}