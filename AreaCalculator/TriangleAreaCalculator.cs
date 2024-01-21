using Figures;

namespace AreaCalculator
{
    /// <summary>
    /// Класс, содержащий методы, занимающиеся вычислением площади треугольника.
    /// </summary>
    public class TriangleAreaCalculator : AreaCalculator<Triangle>
    {
        /// <summary>
        /// Конструктор вычислителя площади треугольника.
        /// </summary>
        public TriangleAreaCalculator(Triangle triangle) : base(triangle)
        {
        }

        /// <summary>
        /// Вычисление площади треугольника по трем сторонам.
        /// Производится по формуле Math.Sqrt(p * (p - a) * (p - b) * (p - c)), где p - полупериметр треугольника.
        /// </summary>
        public override double Calculate()
        {
            ValidateFigure();

            var a = Figure.A;
            var b = Figure.B;
            var c = Figure.C;

            // Вычисление полупериметра
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));         
        }
    }
}
