using Shapes.Models;

namespace Shapes.Tests.Models;

public class TriangleTest
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(3, 3, 3, 3.89711D)]
    [InlineData(21, 45, 32, 305.44393D)]
    [InlineData(5.1254D, 8.42D, 12.3545D, 16.53229D)]
    [InlineData(23.54D, 65, 43, 220.67408D)]
    public void Triangle_CalculateArea_Theory(double a, double b, double c, double expected)
    {
        Triangle triangle = new(a, b, c);
        var result = triangle.Area;
        
        Assert.Equal(expected, result, 0.00001D);
    }

    [Fact]
    public void Triangle_CreateWithInvalidArguments_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 10));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 5, 5, false)]
    [InlineData(31.331D, 34.482D, 46.590126464D, true)]
    [InlineData(23.545134D, 26.4541214D, 35.512753D, false)]
    public void Triangle_IsRectangular_Theory(double a, double b, double c, bool expected)
    {
        Triangle triangle = new(a, b, c);
        var result = triangle.IsRectangular;
        
        Assert.Equal(expected, result);
    }
}