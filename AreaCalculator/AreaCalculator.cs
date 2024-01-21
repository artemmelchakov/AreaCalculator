using AreaCalculator.Exceptions;
using Figures;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculator
{
    /// <summary>
    /// Абстрактный класс, от которого наследуются классы, занимающиеся вычислением площади фигуры.
    /// </summary>
    public abstract class AreaCalculator<T> where T : Figure
    {
        /// <summary>
        /// Экземпляр фигуры, с которой будут производиться вычисления. 
        /// </summary>
        public T Figure { get; set; }

        /// <summary>
        /// Конструктор вычислителя площади фигуры.
        /// </summary>
        /// <param name="figure"> Экземпляр фигуры, с которой будут производиться вычисления. </param>
        public AreaCalculator(T figure) => Figure = figure;

        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        /// <returns> Площадь фигуры. </returns>
        public abstract double Calculate();

        /// <summary>
        /// Выполнить валидацию объекта фигуры, с которой будут производиться вычисления.
        /// </summary>
        /// <exception cref="ValidationsException"></exception>
        protected void ValidateFigure()
        {
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(Figure, new ValidationContext(Figure), validationResults))
            {
                throw new ValidationsException(
                    "Невозможно проводить вычисления с фигурой, у которой параметры некорректны!", validationResults);
            }
        }
    }
}
