using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake :  Figur
    {
        

        Direction direction;

        public Snake (Point tall, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();

            for (int i =0; i < lenght; i++ )
            {
                Point p = new Point(tall);
                p.Move(i , direction );
                pList.Add( p );
            }
        }

        internal void Move()
        {
            Point tall = pList.First();
            pList.Remove(tall);
            Point head = GetNextPoint();
            pList.Add(head);

            tall.Clear();
            head.Draw();

        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat (Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.syn = head.syn;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        internal bool Eat(object food)
        {
            throw new NotImplementedException();
        }

        public void HandleKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }

            if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }

            if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }

            if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }



    }
}
