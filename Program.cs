using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 3;
            p1.Y = 8;
            p1.syn = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.X = 10;
            p2.Y = 14;
            p2.syn = '*';
            p2.Draw();

            

        }
        
    }
}
