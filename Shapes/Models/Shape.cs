namespace Shapes.Models;

public abstract class Shape
{
    private readonly Lazy<double> _area;

    public double Area => _area.Value;

    protected Shape()
    {
        _area = new Lazy<double>(CalculateArea);
    }
    
    /// <summary>
    /// Вычисление площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    protected abstract double CalculateArea();
}