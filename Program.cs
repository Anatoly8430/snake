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
            int X1 = 1;
            int Y1 = 3;
            char syn1 = '*';
            Draw(X1, Y1, syn1);

            int X2 = 4;
            int Y2 = 6;
            char syn2 = '*';
            Draw(X2, Y2, syn2);

            int X3 = 10;
            int Y3 = 16;
            char syn3='*';
            Draw(X3, Y3, syn3);

            int X4 = 20;
            int Y4 = 30;
            char syn4 = '*';
            Draw(X4, Y4, syn4);

        }
        static void Draw( int X, int  Y, char syn)
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(syn);
            Console.ReadLine();
        }
    }
}
