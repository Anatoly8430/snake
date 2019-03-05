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


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(syn);
            
            

        }

        
    }
}