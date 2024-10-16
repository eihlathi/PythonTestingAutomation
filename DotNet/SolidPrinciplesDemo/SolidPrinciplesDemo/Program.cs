using SolidPrinciplesDemo;

ShapeCalculator calculator = new();

double rectangleArea = calculator.CalculateArea(ShapeType.Rectangle, 5, 10, 0);
double circleArea = calculator.CalculateArea(ShapeType.Circle, 0, 0, 5);

Console.WriteLine($"Rectangle Area: {rectangleArea}");
Console.WriteLine($"Circle Area: {circleArea}");

calculator.PrintShapeInfo("Rectangle", 5, 10, 0);
calculator.PrintShapeInfo("Circle", 0, 0, 5);
