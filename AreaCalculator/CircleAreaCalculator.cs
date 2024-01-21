using Figures;

namespace AreaCalculator
{
    /// <summary>
    /// Класс, содержащий методы, занимающиеся вычислением площади круга.
    /// </summary>
    public class CircleAreaCalculator : AreaCalculator<Circle>
    {
        /// <summary>
        /// Конструктор вычислителя площади круга.
        /// </summary>
        /// <param name="circle"> Экземпляр объекта - круга. </param>
        public CircleAreaCalculator(Circle circle) : base(circle)
        {
        }

        /// <summary>
        /// Вычисление площади круга. Производится по формуле Math.PI * r * r (r - радиус, Math.PI - число Пи).
        /// </summary>
        public override double Calculate()
        {
            ValidateFigure();

            var r = Figure.Radius;
            return Math.PI * r * r;
        }
    }
}
