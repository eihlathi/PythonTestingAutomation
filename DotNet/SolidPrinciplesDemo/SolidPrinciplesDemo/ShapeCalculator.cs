using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public enum ShapeType
    {
        Rectangle,
        Circle
    }

    public class ShapeCalculator
    {
        public double CalculateArea(ShapeType shapeType, double width, double height, double radius)
        {
            if (shapeType == ShapeType.Rectangle)
            {
                return width * height;
            }
            else if (shapeType == ShapeType.Circle)
            {
                return Math.PI * radius * radius;
            }
            else
            {
                throw new Exception("Invalid shape type");
            }
        }

        public void PrintShapeInfo(string shapeType, double width, double height, double radius)
        {
            if (shapeType == "Rectangle")
            {
                Console.WriteLine($"Rectangle with width {width} and height {height}");
            }
            else if (shapeType == "Circle")
            {
                Console.WriteLine($"Circle with radius {radius}");
            }
            else
            {
                throw new Exception("Invalid shape type");
            }
        }
    }
}
