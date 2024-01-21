using Figures;

namespace AreaCalculator.Tests.FigureTests
{
    public class TriangleTests
    {
        /// <summary>
        /// Проверка на то, что треугольники с неправильными параметрами не проходят валидацию.
        /// </summary>
        /// <param name="a"> Длина стороны треугольника A. </param>
        /// <param name="b"> Длина стороны треугольника B. </param>
        /// <param name="c"> Длина стороны треугольника C. </param>
        [Theory]

        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(1.0, 0.0, 0.0)]
        [InlineData(0.0, 1.0, 1.0)]

        [InlineData(-1.0, -1.0, -1.0)]
        [InlineData(-1.0, -1.0, 1.0)]
        [InlineData(1.0, 1.0, -1.0)]

        public void InvalidTriangleParametersTest(double a, double b, double c) => Assert.False(new Triangle(a, b, c).IsValid);

        /// <summary>
        /// Проверка на то, что треугольники с правильными параметрами проходят валидацию.
        /// </summary>
        [Fact]
        public void ValidTriangleParametersTest() => Assert.True(new Triangle(1.0, 1.0, 1.0).IsValid);
    }
}