using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    public class Circle : Shape
    {
        public override double Area
        {
            //get { return Math.PI * (Width / 2) * (Width / 2); }
            // That't not the formula.
            get { return Math.Round(Math.PI * Width * Width, 2);}
        }

        public Circle(double width)
            : base(width)
        {
        }
    }
}
