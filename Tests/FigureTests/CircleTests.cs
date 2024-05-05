using Figures;

namespace Tests.FigureTests
{
    public class CircleTests
    {
        /// <summary>
        /// Проверка на то, что круг с неправильным параметром не проходит валидацию.
        /// </summary>
        /// <param name="r"> Радиус. </param>
        [Theory]
        [InlineData(0.0)]
        [InlineData(-1.0)]
        public void InvalidCircleParametersTest(double r) => Assert.False(new Circle(r).IsValid);

        /// <summary>
        /// Проверка на то, что круг с правильным параметром проходит валидацию.
        /// </summary>
        [Fact]
        public void ValidCircleParametersTest() => Assert.True(new Circle(1.0).IsValid);
    }
}
