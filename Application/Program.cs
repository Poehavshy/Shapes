using Shapes.Interfaces;
using Shapes.Models;

IShape shape;

Console.WriteLine("Выберите фигуру:");
Console.WriteLine("1. Круг");
Console.WriteLine("2. Треугольник");
var choose = Console.ReadLine() ?? "1";

switch (choose[0])
{
    case '1':
        shape = new Circle(5);
        break;
    case '2':
        shape = new Triangle(3, 4, 5);
        break;
    default:
        Console.WriteLine("Некорректный выбор.");
        return;
}

Console.WriteLine($"Площадь равна: {shape.CalculateArea()}");
