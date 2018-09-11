using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Drawers;
using Shapes.Figures;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rand = random.Next(1,3);

            Drawer figure = new FigureDrawer();
            figure.Draw(rand);
            
            Figure figure1 = new Circle(0,0,10);
            Console.WriteLine(figure1.ToString());

            Figure figure2 = new Rectangle(0, 0, 0, 5, 5, 5, 0, 5);
            Console.WriteLine(figure2.ToString());

            Figure figure3 = new Triangle(0, 0, 3, 3, 0, 6);
            Console.WriteLine(figure3.ToString());

            Console.ReadKey();
        }
    }
}
