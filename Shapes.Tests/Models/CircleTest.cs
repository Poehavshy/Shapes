using Shapes.Models;

namespace Shapes.Tests.Models;

public class CircleTest
{
    [Theory]
    [InlineData(1, 3.14159D)]
    [InlineData(3, 28.27433D)]
    [InlineData(14, 615.75216D)]
    [InlineData(1.15D, 4.15475D)]
    [InlineData(3.185934672894537D, 31.88773D)]
    public void Circle_CalculateArea_Theory(double radius, double expected)
    {
        Circle circle = new(radius);
        var result = circle.Area;
        
        Assert.Equal(expected, result, 0.00001D);
    }
    
    [Fact]
    public void Circle_CreateWithInvalidArguments_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-3));
    }
}