using System.ComponentModel.DataAnnotations;

namespace AreaCalculator.Exceptions
{
    /// <summary>
    /// Исключение с дополнительной информацией в виде результатов валидации.
    /// </summary>
    internal class ValidationsException : Exception
    {
        /// <summary>
        /// Коллекция результатов валидации.
        /// </summary>
        private IEnumerable<ValidationResult> ValidationResults { get; set; }
        /// <summary>
        /// Исключение <see cref="ValidationException"/> с дополнительной информацией в виде результатов валидации.
        /// </summary>
        /// <param name="message"><see cref="Exception.Message"/></param>
        /// <param name="validationResults"> Коллекция результатов валидации. </param>
        public ValidationsException(string message, IEnumerable<ValidationResult> validationResults) : base(message) => 
            ValidationResults = validationResults;
    }
}
