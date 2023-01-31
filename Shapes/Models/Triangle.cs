namespace Shapes.Models;

public sealed class Triangle : Shape
{
    /// <summary>
    /// Стороны треугольника.
    /// </summary>
    private readonly double _a, _b, _c;
    /// <summary>
    /// Является ли треугольник прямоугольным.
    /// </summary>
    private readonly Lazy<bool> _isRectangular;
    public bool IsRectangular => _isRectangular.Value;

    /// <summary>
    /// Треугольник.
    /// </summary>
    /// <param name="a">Первая сторона.</param>
    /// <param name="b">Вторая сторона.</param>
    /// <param name="c">Третья сторона.</param>
    /// <exception cref="ArgumentException">Если сторона треугольника меньше либо равна 0 или составить треугольник из
    /// заданых сторон невозможно.</exception>
    public Triangle(double a, double b, double c)
    {
        if (!(a + b > c) || !(a + c > b) || !(b + c > a) || a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Invalid arguments, triangle does not exist.");
        }

        _a = a;
        _b = b;
        _c = c;

        _isRectangular = new Lazy<bool>(CalculateIsRectangular);
    }
    
    /// <summary>
    /// Вычисление площади треугольника.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    protected override double CalculateArea()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    /// <summary>
    /// Вычисление является ли треугольник прямоугольным.
    /// </summary>
    /// <returns>Является ли треугольник прямоугольным.</returns>
    private bool CalculateIsRectangular()
    {
        List<double> cathetus = new(2);
        double hypotenuse;
        if (_a > _b && _a > _c)
        {
            hypotenuse = _a;
            cathetus.Add(_b);
            cathetus.Add(_c);
        }
        else if (_b > _a && _b > _c)
        {
            hypotenuse = _b;
            cathetus.Add(_a);
            cathetus.Add(_c);
        }
        else
        {
            hypotenuse = _c;
            cathetus.Add(_a);
            cathetus.Add(_b);
        }

        return Math.Abs(Math.Pow(cathetus[0], 2) + Math.Pow(cathetus[1], 2) - Math.Pow(hypotenuse, 2)) < 0.00001D;
    }
}