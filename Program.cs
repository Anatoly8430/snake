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

            HorizontalLine Line = new HorizontalLine(5 , 10, 10, '*');
            Line.Draw();
            Console.ReadLine();

        }
    }
}
    


