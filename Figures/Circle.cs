using System.ComponentModel.DataAnnotations;

namespace Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга. 
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Конструктор круга.
        /// </summary>
        /// <param name="radius"> Радиус круга. </param>
        public Circle(double radius) => Radius = radius;

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Radius <= 0.0)
            {
                yield return new ValidationResult("Значение радиуса круга не может быть отрицательным.");
            }
        }
    }
}
