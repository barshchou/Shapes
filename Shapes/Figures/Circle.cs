using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    class Circle : Figure
    {
        protected string name = "Circle";
        protected string color = "Red";
        protected int x1, y1, radius;

        public Circle()
        {

        }

        public Circle(int x1, int y1, int radius)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.radius = radius;
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius,2);
        }

        public override string ToString()
        {
            return "Figure: " + Name + " " + "Color: " + Color + " " + "Area: " + Area() + " " + "Perimeter: " + Perimeter();
        }

        public override bool IsCreatable()
        {
            return radius > 0;
        }
    }
}
