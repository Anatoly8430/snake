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

            Point p1 = new Point(4, 8, '*');
            p1.Draw();

            Point p2 = new Point(10, 12, '#');
            p2.Draw();

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(10);
            numList.Add(9);

            int x = numList[1];
            int y = numList[0];
            int z = numList[2];


            foreach (int i in numList)
            {
                Console.WriteLine(i);
                Console.ReadLine();

            }

            numList.RemoveAt(1);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
                Console.ReadLine();

            }


            Point p3 = new Point(10, 16, '&');

            Point p4 = new Point(18, 30, '%');
            

            List<Point> pList = new List<Point>();
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point p in pList)
            {
                Console.WriteLine(p);
                Console.ReadLine();
            }
            


            List<char> cList = new List<char>();
            cList.Add('?');
            cList.Add('%');


            foreach (char c in cList)
            {
                Console.WriteLine(c);
                Console.ReadLine();
            }

            Point p5 = new Point(1, 3, '*');
            p1.Draw();

            Point p6 = new Point(4, 5, '#');
            p2.Draw();

            Point p7 = new Point(2, 4, '+');
            Point p8 = new Point(5, 1, '/');

            
            pList.Add(p5);
            pList.Add(p6);
            pList.Add(p7);
            pList.Add(p8);

            foreach (Point p in pList)
            {
                Console.WriteLine(p);
                Console.ReadLine();
            }

            cList.Add('*');
            cList.Add('|');
            cList.Add('+');
            cList.Add('=');

            foreach (char c in cList)
            {
                Console.WriteLine(c);
                Console.ReadLine();
            }

            Console.ReadLine();

            List<char> chListChar = new List<char>();
            chListChar.Add('&');
            chListChar.Add('*');
            chListChar.Add('$');
            chListChar.Add('^');

            Point pPoint1 = new Point(1, 3, chListChar[0]);
            Point pPoint2 = new Point(2, 5, chListChar[1]);
            Point pPoint3 = new Point(3, 6, chListChar[2]);
            Point pPoint4 = new Point(4, 7, chListChar[3]);

            foreach (char p in chListChar)
            {
                Console.WriteLine(p);
                Console.ReadLine();
            }
            Console.ReadKey();

        }
    }
}
    


