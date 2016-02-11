using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    class Program
    {
        static void Main(string[] args)
        {

            //With more time I would implement a different interface to the user, atl least one that allow to use the Dependency inversion that I have implemented
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("FSL Code Exercise v1.0");
            Console.WriteLine();
            Console.WriteLine("Calculates and prints information for a user-supplied shape and width");
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Do you want a square (1), circle (2), or equilateral triangle (3): ");
            int selection = int.Parse(Console.ReadLine());
            if (selection > 0 && selection < 4)
            {
                ShapeType type = (ShapeType)selection;

                Console.WriteLine("Enter the shape's primary dimension (width, radius, or base): ");
                double width = double.Parse(Console.ReadLine());

                var shape = FactoryShape.Create(type, width);

                Console.WriteLine();
                Console.WriteLine("Shape properties:");
                Console.WriteLine("\tWidth: " + shape.Width);
                Console.WriteLine("\tArea: " + shape.Area);
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Wrong selection. ");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
