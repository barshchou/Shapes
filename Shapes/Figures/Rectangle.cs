using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    class Rectangle : Figure
    {
        protected string name = "Rectangle";
        protected string color = "Green";
        protected int x1,y1,x2,y2,x3,y3,x4,y4;

        public Rectangle()
        {

        }

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
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
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) * 2 +
                   Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)) * 2;
        }

        public override double Area()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) * 
                   Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        }

        public override bool IsCreatable()
        {
            double a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double b = Math.Sqrt((x4 - x2) * (x4 - x2) + (y4 - y2) * (y4 - y2));
            double c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            return (b - c == 0 && a < b);
        }

        public override string ToString()
        {
            return "Figure: " + Name + " " + "Color: " + Color + " " + "Area: " + Area() + " " + "Perimeter: " + Perimeter();
        }
    }
}
