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
            int rand = random.Next(1,1);

            Drawer figure = new FigureDrawer();
            Console.WriteLine(figure.Draw(rand).ToString());
            
            //Figure figure1 = new Circle(0,0,10);
            //Console.WriteLine(figure1.ToString());
            
            Console.ReadKey();
        }
    }
}
