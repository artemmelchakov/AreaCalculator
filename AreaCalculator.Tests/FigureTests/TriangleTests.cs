using Figures;

namespace AreaCalculator.Tests.FigureTests
{
    public class TriangleTests
    {
        /// <summary>
        /// �������� �� ��, ��� ������������ � ������������� ����������� �� �������� ���������.
        /// </summary>
        /// <param name="a"> ����� ������� ������������ A. </param>
        /// <param name="b"> ����� ������� ������������ B. </param>
        /// <param name="c"> ����� ������� ������������ C. </param>
        [Theory]

        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(1.0, 0.0, 0.0)]
        [InlineData(0.0, 1.0, 1.0)]

        [InlineData(-1.0, -1.0, -1.0)]
        [InlineData(-1.0, -1.0, 1.0)]
        [InlineData(1.0, 1.0, -1.0)]

        public void InvalidTriangleParametersTest(double a, double b, double c) => Assert.False(new Triangle(a, b, c).IsValid);

        /// <summary>
        /// �������� �� ��, ��� ������������ � ����������� ����������� �������� ���������.
        /// </summary>
        [Fact]
        public void ValidTriangleParametersTest() => Assert.True(new Triangle(1.0, 1.0, 1.0).IsValid);
    }
}