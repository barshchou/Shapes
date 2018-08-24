using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Figures;

namespace Shapes.Drawers
{
    class FigureDrawer : Drawer
    {
        public override Figure Draw(int rand)
        {
            Figure figure = null;

            Random random = new Random();

            int x1 = random.Next(-10, 10);
            int x2 = random.Next(-10, 10);
            int x3 = random.Next(-10, 10);
            int x4 = random.Next(-10, 10);
            int y1 = random.Next(-10, 10);
            int y2 = random.Next(-10, 10);
            int y3 = random.Next(-10, 10);
            int y4 = random.Next(-10, 10);
            int radius = random.Next(-10,10);

            if (rand == 1)
            {
                figure = new Circle(x1, y1, radius);

                if (figure.IsCreatable())
                {
                    Console.WriteLine(figure.ToString());
                }
                else 
                Console.WriteLine("Circle couldn't be created!");
            }
            else if (rand == 2)
            {
                figure = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);

                if (figure.IsCreatable())
                {
                    Console.WriteLine(figure.ToString());
                }
                else
                    Console.WriteLine("Circle couldn't be created!");
            }
            else if (rand == 3)
            {
                figure = new Triangle(x1, y1, x2, y2, x3, y3);

                if (figure.IsCreatable())
                {
                    Console.WriteLine(figure.ToString());
                }
                else
                    Console.WriteLine("Circle couldn't be created!");
            }
            else 
               Console.WriteLine("Figure couldn't be created!");

            return figure;
        }
    }
}
