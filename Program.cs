﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine UpLine = new HorizontalLine(0 , 118, 0, '#');
            UpLine.Draw();
            

            VerticalLine LeftLine = new VerticalLine(0, 29, 0, '#');
            LeftLine.Draw();
            

            HorizontalLine DownLine = new HorizontalLine(0, 118, 29, '#');
            DownLine.Draw();
            

            VerticalLine RightLine = new VerticalLine(0, 29, 118, '#');
            RightLine.Draw();


            Console.ReadLine();

            Point p = new Point(10, 15, '*');
            Snake snake = new Snake(p, 10, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            Console.ReadLine();
        }
    }
}
    


