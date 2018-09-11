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

            var random = new Random();

            var x1 = random.Next(-10, 10);
            var x2 = random.Next(-10, 10);
            var x3 = random.Next(-10, 10);
            var x4 = random.Next(-10, 10);
            var y1 = random.Next(-10, 10);
            var y2 = random.Next(-10, 10);
            var y3 = random.Next(-10, 10);
            var y4 = random.Next(-10, 10);
            var radius = random.Next(-10,10);

            switch (rand)
            {
                case 1:
                {
                    figure = new Circle(x1, y1, radius);

                    if (figure.IsCreatable())
                    {
                        Console.WriteLine(figure.ToString());
                    }
                    else 
                        Console.WriteLine("Circle couldn't be created!");

                    break;
                }
                case 2:
                {
                    figure = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);

                    if (figure.IsCreatable())
                    {
                        Console.WriteLine(figure.ToString());
                    }
                    else
                        Console.WriteLine("Circle couldn't be created!");

                    break;
                }
                case 3:
                {
                    figure = new Triangle(x1, y1, x2, y2, x3, y3);

                    if (figure.IsCreatable())
                    {
                        Console.WriteLine(figure.ToString());
                    }
                    else
                        Console.WriteLine("Circle couldn't be created!");

                    break;
                }
                default:
                    Console.WriteLine("Figure couldn't be created!");
                    break;
            }

            return figure;
        }
    }
}
