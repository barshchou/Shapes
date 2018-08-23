using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Figure
    {
        protected string name;
        protected string color;

        public abstract double Perimeter();
        
        public abstract double Area();

    }
}
