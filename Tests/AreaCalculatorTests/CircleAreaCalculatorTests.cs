using AreaCalculators;
using Figures;

namespace Tests.AreaCalculatorTests
{
    public class CircleAreaCalculatorTests
    {
        /// <summary>
        /// Проверка на то, что при попытке вычислить площадь круга с некорректными параметрами будет выброшено исключение.
        /// </summary>
        [Fact]
        public void CircleAreaCalculatingWithInvalidFigureParametersTest() =>
            Assert.ThrowsAny<Exception>(() => new CircleAreaCalculator(new Circle(0.0)).Calculate());

        /// <summary>
        /// Проверка на то, что при попытке вычислить площадь круга с корректными параметрами не будет выброшено исключение.
        /// </summary>
        [Fact]
        public void CircleAreaCalculatingWithValidFigureParametersTest() => new CircleAreaCalculator(new Circle(1.0)).Calculate();
    }
}
