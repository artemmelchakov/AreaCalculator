namespace AreaCalculator
{
    /// <summary>
    /// Класс, содержащий методы, занимающиеся вычислением площади треугольника.
    /// </summary>
    public class TriangleAreaCalculator : IAreaCalculator
    {
        /// <summary>
        /// Длина стороны треугольника a.
        /// </summary>
        private double _a;
        /// <summary>
        /// Длина стороны треугольника b.
        /// </summary>
        private double _b;
        /// <summary>
        /// Длина стороны треугольника c.
        /// </summary>
        private double _c;

        /// <summary>
        /// Конструктор вычислителя площади треугольника по трем сторонам <paramref name="a"/>, <paramref name="b"/> и <paramref name="c"/>.
        /// </summary>
        public TriangleAreaCalculator(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// <inheritdoc cref="IAreaCalculator.Calculate"/>
        /// Вычисление площади треугольника по трем сторонам <paramref name="a"/>, <paramref name="b"/> и <paramref name="c"/>
        /// производится по формуле Math.Sqrt(p * (p - a) * (p - b) * (p - c)), где p - полупериметр треугольника.
        /// </summary>
        public double Calculate()
        {
            // Вычисление полупериметра
            var p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));         
        }
    }
}
