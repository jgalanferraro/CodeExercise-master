using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    //Having this hierarchy allow us to implement new Shapes without changing the original code, just extending the hierarchy.
    public abstract class Shape
    {

        private double width;


        //Not needed with a hierarchy structure
        //private int type;
        //private const int SQUARE = 1;
        //private const int CIRCLE = 2;
        //private const int EQUILATERAL_TRIANGLE = 3;

        public Shape(/*int type,*/ double width)
        {
            //this.type = type;
            this.width = width;
        }

        public double Width
        {
            get
            {
                return width;
            }
        }

 
        //This must be abstract and be implemented in the specific class and satisfy the Open/Close and Dependency Inversion.  
        public abstract double Area { get; }
        //{
        //    get
        //    {
        //        switch (type)
        //        {
        //            case SQUARE:
        //                return width * width;
        //            case CIRCLE:
        //                return Math.PI * (width / 2) * (width / 2);
        //            case EQUILATERAL_TRIANGLE:
        //                return (Math.Sqrt(4) / 3) * width * width;
        //            default:
        //                throw new InvalidProgramException("Unknown shape type encountered: " + type);
        //        }
        //    }
        //}
    }
}
