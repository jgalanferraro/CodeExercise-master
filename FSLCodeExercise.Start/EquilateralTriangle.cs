using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    public class EquilateralTriangle : Shape
    {
        public override double Area
        {
            //The formula is wrong.
            //get { return (Math.Sqrt(4) / 3) * Width * Width; }
            get { return Math.Round((Math.Sqrt(3) / 4) * Width * Width, 2); }
        }

        public EquilateralTriangle(double width)
            : base(width)
        {
        }
    }
}
