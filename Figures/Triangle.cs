using System.ComponentModel.DataAnnotations;

namespace Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Длина стороны треугольника A.
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Длина стороны треугольника B.
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Длина стороны треугольника C.
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Конструктор треугольника.
        /// </summary>
        /// <param name="a"> Длина стороны треугольника A. </param>
        /// <param name="b"> Длина стороны треугольника B. </param>
        /// <param name="c"> Длина стороны треугольника C. </param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (A <= 0.0 || B <= 0.0 || C <= 0.0)
            {
                yield return new ValidationResult("Значение длин сторон треугольника не может быть отрицательным.");
            }
        }
    }
}
