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
            int rand = random.Next(1,4);

            Drawer figure = new FigureDrawer();
            figure.Draw(rand);
            
            Console.ReadKey();
        }
    }
}
