using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
   public class Square : Shape
    {
        public override double Area
        {
            get { return Width * Width; }
        }

        public Square(double width)
            : base(width)
        {
        }
    }
}
