using Shapes.Interfaces;

namespace Shapes.Models;

public sealed class Circle : IShape
{
    /// <summary>
    /// Радиус круга.
    /// </summary>
    private readonly double _radius;
    
    /// <summary>
    /// Круг.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <exception cref="ArgumentException">Если радиус круга меньше либо равен 0.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive.", nameof(radius));
        }
        
        _radius = radius;
    }

    /// <summary>
    /// Вычисление площади круга.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}