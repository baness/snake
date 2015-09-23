using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(2, 4, '*');
            p1.Draw();
                
            point p2 = new point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

           /* int x1 = 1;
            int y1 = 3;
            char sym1 = '*';*/

            //Draw(x1, y1, sym1);

            Console.ReadLine();
        }
    }
}
