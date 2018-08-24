using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    class Triangle : Figure
    {
        protected string name = "Triangle";
        protected string color = "Blue";
        protected int x1, y1, x2, y2, x3, y3;

        public Triangle()
        {

        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
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
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) + 
                   Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)) + 
                   Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        }

        public override double Area()
        {
            double a = Convert.ToDouble(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            double b = Convert.ToDouble(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)));
            double c = Convert.ToDouble(Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            return 2 / a * Math.Sqrt(Perimeter() * (Perimeter() - a) * (Perimeter() - b) * (Perimeter() - c));
        }

        public override bool IsCreatable()
        {
            double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double eps = 1e-3;

            return (b + c - a > eps) && (a + c - b > eps) && (a + b - c > eps);
        }

        public override string ToString()
        {
            return "Figure: " + Name + " " + "Color: " + Color + " " + "Area: " + Area() + " " + "Perimeter: "+ Perimeter();
        }
    }
}
