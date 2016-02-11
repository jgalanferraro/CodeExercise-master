using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    //The factory allow us to disconnect the hierarchy and the enum as different components
    public class FactoryShape
    {
        public static Shape Create(ShapeType type, double width)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle(width);;
                case ShapeType.EquilateralTriangle:
                    return new EquilateralTriangle(width);;
                default:
                     return new Square(width);;
            }
        }
    }
}
