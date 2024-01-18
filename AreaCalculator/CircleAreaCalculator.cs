namespace AreaCalculator
{
    /// <summary>
    /// Класс, содержащий методы, занимающиеся вычислением площади круга.
    /// </summary>
    public class CircleAreaCalculator : IAreaCalculator
    {
        /// <summary>
        /// Радиус круга. 
        /// </summary>
        private double _radius = 0.0;

        /// <summary>
        /// Конструктор вычислителя площади круга.
        /// </summary>
        /// <param name="radius"> Радиус круга. </param>
        public CircleAreaCalculator(double radius) => _radius = radius;

        /// <summary>
        /// <inheritdoc cref="IAreaCalculator.Calculate"/>
        /// Вычисление площади круга производится по формуле Math.PI * r * r (r - радиус, Math.PI - число Пи).
        /// </summary>
        public double Calculate() => Math.PI * _radius * _radius;
    }
}
