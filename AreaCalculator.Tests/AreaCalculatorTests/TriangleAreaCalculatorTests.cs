using Figures;

namespace AreaCalculator.Tests.AreaCalculatorTests
{
    public class TriangleAreaCalculatorTests
    {
        /// <summary>
        /// Проверка на то, что при попытке вычислить площадь треугольника с некорректными параметрами будет выброшено исключение.
        /// </summary>
        [Fact]
        public void TriangleAreaCalculatingWithInvalidFigureParametersTest() =>
            Assert.ThrowsAny<Exception>(() => new TriangleAreaCalculator(new Triangle(0.0, 0.0, 0.0)).Calculate());

        /// <summary>
        /// Проверка на то, что при попытке вычислить площадь треугольника с корректными параметрами не будет выброшено исключение.
        /// </summary>
        [Fact]
        public void TriangleAreaCalculatingWithValidFigureParametersTest() => new TriangleAreaCalculator(new Triangle(1.0, 1.0, 1.0)).Calculate();
    }
}
